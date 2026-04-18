using BloodLink.Database;
using BloodLink.Helpers;
using BloodLink.Models;
namespace BloodLink.Services
{
    public class DonorService
    {
        private readonly DonorRepository _donorRepo;
        private readonly DonationHistoryRepository _historyRepo;

        public DonorService()
        {
            _donorRepo = new DonorRepository();
            _historyRepo = new DonationHistoryRepository();
        }

        // Register a donor (simple validation + repository call).
        // Returns (success, message, donorId)
        public (bool success, string message, int donorId) RegisterDonor(Donor donor)
        {
            // Basic validation
            if (donor == null)
                return (false, "Invalid donor data.", -1);

            if (string.IsNullOrWhiteSpace(donor.FullName))
                return (false, "Full name is required.", -1);

            if (string.IsNullOrWhiteSpace(donor.Phone))
                return (false, "Phone number is required.", -1);

            if (string.IsNullOrWhiteSpace(donor.City))
                return (false, "City is required.", -1);

            // Prevent duplicate donor profile for same user
            if (donor.UserId.HasValue)
            {
                var existing = _donorRepo.GetDonorByUserId(donor.UserId.Value);
                if (existing != null && existing.Id != donor.Id)
                    return (false, "A donor profile already exists for this account.", -1);
            }

            // Normalize and set defaults
            donor.FullName = donor.FullName.Trim();
            donor.City = donor.City.Trim();
            donor.Area = donor.Area?.Trim();
            donor.IsAvailable = donor.IsAvailable; // caller decides
            donor.CreatedAt = donor.CreatedAt == default ? DateTime.Now : donor.CreatedAt;

            int id = _donorRepo.AddDonor(donor);
            if (id <= 0)
                return (false, "Failed to save donor. See logs.", -1);

            return (true, "Donor registered.", id);
        }

        // Search donors with optional bloodGroup filter (uses compatibility expansion)
        // If bloodGroup == null => any blood group.
        public List<Donor> SearchDonors(BloodGroup? bloodGroup, string? city, bool availableOnly)
        {
            List<string>? bloodGroupDescriptions = null;

            if (bloodGroup.HasValue)
            {
                // Expand to compatible donor groups (requested + compatible donors)
                var compatibles = GetCompatibleBloodGroupDescriptions(bloodGroup.Value);
                bloodGroupDescriptions = compatibles;
            }

            return _donorRepo.SearchDonors(bloodGroupDescriptions, city, availableOnly);
        }

        // Expose stats for dashboard (delegates to repository)
        public DonorStats GetDashboardStats()
        {
            return _donorRepo.GetDonorStats();
        }

        // Helper: map requested BloodGroup to list of compatible donor group descriptions
        // Example: requesting A+ should return ["A+", "A-", "O+", "O-"]
        private List<string> GetCompatibleBloodGroupDescriptions(BloodGroup requested)
        {
            // Compatibility mapping (donor-compatible groups for a GIVEN required group)
            // This mapping is conservative and easy to extend or replace with a proper compatibility table.
            List<BloodGroup> donors = requested switch
            {
                BloodGroup.APositive => new[] { BloodGroup.APositive, BloodGroup.ANegative, BloodGroup.OPositive, BloodGroup.ONegative }.ToList(),
                BloodGroup.ANegative => new[] { BloodGroup.ANegative, BloodGroup.ONegative }.ToList(),
                BloodGroup.BPositive => new[] { BloodGroup.BPositive, BloodGroup.BNegative, BloodGroup.OPositive, BloodGroup.ONegative }.ToList(),
                BloodGroup.BNegative => new[] { BloodGroup.BNegative, BloodGroup.ONegative }.ToList(),
                BloodGroup.ABPositive => Enum.GetValues(typeof(BloodGroup)).Cast<BloodGroup>().ToList(), // AB+ accepts all
                BloodGroup.ABNegative => new[] { BloodGroup.ABNegative, BloodGroup.ABPositive }.ToList(), // fallback if needed
                BloodGroup.OPositive => new[] { BloodGroup.OPositive, BloodGroup.ONegative }.ToList(),
                BloodGroup.ONegative => new[] { BloodGroup.ONegative }.ToList(),
                _ => new[] { requested }.ToList()
            };

            // Convert to DB-stored descriptions (EnumHelper.GetDescription)
            var descriptions = donors.Select(d => EnumHelper.GetDescription(d)).Distinct().ToList();
            return descriptions;
        }
    }

    // NOTE: The switch above references a couple of enum values that must match your BloodGroup enum.
    // If your BloodGroup enum names differ, update the mapping accordingly.
}