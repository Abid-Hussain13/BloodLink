using BloodLink.Helpers;
using BloodLink.Models;
using Microsoft.Data.Sqlite;

namespace BloodLink.Database
{
    public class DonorRepository
    {
        // ─────────────────────────────────────────────────
        // ADD DONOR
        // Called by: DonorService.RegisterDonor()
        // Returns: new donor's Id, or -1 on failure
        // ─────────────────────────────────────────────────
        public int AddDonor(Donor donor)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = @"
                    INSERT INTO Donors (FullName, BloodGroup, Phone, City, Area, Age, Gender,
                                        IsAvailable, LastDonationDate, UserId, CreatedAt)
                    VALUES (@fullName, @bloodGroup, @phone, @city, @area, @age, @gender,
                            @isAvailable, @lastDonationDate, @userId, @createdAt);
                    SELECT last_insert_rowid();
                ";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@fullName", donor.FullName);
                command.Parameters.AddWithValue("@bloodGroup", EnumHelper.GetDescription(donor.BloodGroup));
                command.Parameters.AddWithValue("@phone", donor.Phone);
                command.Parameters.AddWithValue("@city", donor.City);
                command.Parameters.AddWithValue("@area", donor.Area ?? "");
                command.Parameters.AddWithValue("@age", donor.Age);
                command.Parameters.AddWithValue("@gender", donor.Gender.ToString());
                command.Parameters.AddWithValue("@isAvailable", donor.IsAvailable ? 1 : 0);
                command.Parameters.AddWithValue("@lastDonationDate", donor.LastDonationDate.HasValue
                                                                        ? donor.LastDonationDate.Value.ToString("yyyy-MM-dd")
                                                                        : (object)DBNull.Value);
                command.Parameters.AddWithValue("@userId", donor.UserId.HasValue
                                                                        ? (object)donor.UserId.Value
                                                                        : DBNull.Value);
                command.Parameters.AddWithValue("@createdAt", donor.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));

                object? result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding donor: {ex.Message}");
                return -1;
            }
        }

        // ─────────────────────────────────────────────────
        // GET DONOR BY USER ID
        // Called by: DonorDashboardPage to load logged-in donor's profile
        // Returns: Donor if found, null if user has no donor profile yet
        // ─────────────────────────────────────────────────
        public Donor? GetDonorByUserId(int userId)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT * FROM Donors WHERE UserId = @userId LIMIT 1;";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@userId", userId);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return MapDonor(reader);

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching donor: {ex.Message}");
                return null;
            }
        }

        // ─────────────────────────────────────────────────
        // GET DONOR BY ID
        // Called by: DonorProfilePage, DonorDetailPopup
        // ─────────────────────────────────────────────────
        public Donor? GetDonorById(int donorId)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT * FROM Donors WHERE Id = @id LIMIT 1;";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@id", donorId);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return MapDonor(reader);

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching donor: {ex.Message}");
                return null;
            }
        }

        // ─────────────────────────────────────────────────
        // GET ALL DONORS
        // Called by: AdminDashboardPage, SearchDonorsPage
        // Returns: all donors sorted newest first
        // ─────────────────────────────────────────────────
        public List<Donor> GetAllDonors()
        {
            var donors = new List<Donor>();
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT * FROM Donors ORDER BY CreatedAt DESC;";

                using var command = new SqliteCommand(sql, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                    donors.Add(MapDonor(reader));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching donors: {ex.Message}");
            }
            return donors;
        }

        // ─────────────────────────────────────────────────
        // SEARCH DONORS
        // Called by: DonorService.SearchDonors()
        // bloodGroup = null means "any blood group"
        // city = null or empty means "any city"
        // availableOnly = true filters IsAvailable = 1
        // bloodGroups = list (for compatibility search — multiple groups at once)
        // ─────────────────────────────────────────────────
        public List<Donor> SearchDonors(List<string>? bloodGroups, string? city, bool availableOnly)
        {
            var donors = new List<Donor>();
            try
            {
                using var connection = DatabaseHelper.GetConnection();

                // Build query dynamically based on filters
                var conditions = new List<string>();
                var parameters = new Dictionary<string, object>();

                if (bloodGroups != null && bloodGroups.Count > 0)
                {
                    // Build: BloodGroup IN (@bg0, @bg1, ...)
                    var placeholders = bloodGroups.Select((_, i) => $"@bg{i}").ToList();
                    conditions.Add($"BloodGroup IN ({string.Join(", ", placeholders)})");
                    for (int i = 0; i < bloodGroups.Count; i++)
                        parameters[$"@bg{i}"] = bloodGroups[i];
                }

                if (!string.IsNullOrWhiteSpace(city))
                {
                    conditions.Add("City LIKE @city");
                    parameters["@city"] = $"%{city.Trim()}%";
                }

                if (availableOnly)
                    conditions.Add("IsAvailable = 1");

                string whereClause = conditions.Count > 0
                    ? "WHERE " + string.Join(" AND ", conditions)
                    : "";

                string sql = $"SELECT * FROM Donors {whereClause} ORDER BY CreatedAt DESC;";

                using var command = new SqliteCommand(sql, connection);
                foreach (var param in parameters)
                    command.Parameters.AddWithValue(param.Key, param.Value);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                    donors.Add(MapDonor(reader));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching donors: {ex.Message}");
            }
            return donors;
        }

        // ─────────────────────────────────────────────────
        // UPDATE DONOR
        // Called by: AddDonorPage (edit mode)
        // Returns: true if success
        // ─────────────────────────────────────────────────
        public bool UpdateDonor(Donor donor)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = @"
                    UPDATE Donors SET
                        FullName         = @fullName,
                        BloodGroup       = @bloodGroup,
                        Phone            = @phone,
                        City             = @city,
                        Area             = @area,
                        Age              = @age,
                        Gender           = @gender,
                        LastDonationDate = @lastDonationDate
                    WHERE Id = @id;
                ";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@fullName", donor.FullName);
                command.Parameters.AddWithValue("@bloodGroup", EnumHelper.GetDescription(donor.BloodGroup));
                command.Parameters.AddWithValue("@phone", donor.Phone);
                command.Parameters.AddWithValue("@city", donor.City);
                command.Parameters.AddWithValue("@area", donor.Area ?? "");
                command.Parameters.AddWithValue("@age", donor.Age);
                command.Parameters.AddWithValue("@gender", donor.Gender.ToString());
                command.Parameters.AddWithValue("@lastDonationDate", donor.LastDonationDate.HasValue
                                                                        ? donor.LastDonationDate.Value.ToString("yyyy-MM-dd")
                                                                        : (object)DBNull.Value);
                command.Parameters.AddWithValue("@id", donor.Id);

                int rows = command.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating donor: {ex.Message}");
                return false;
            }
        }

        // ─────────────────────────────────────────────────
        // TOGGLE AVAILABILITY
        // Called by: DonorProfilePage toggle button
        // Flips IsAvailable between 0 and 1
        // ─────────────────────────────────────────────────
        public bool ToggleAvailability(int donorId, bool newStatus)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "UPDATE Donors SET IsAvailable = @status WHERE Id = @id;";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@status", newStatus ? 1 : 0);
                command.Parameters.AddWithValue("@id", donorId);

                int rows = command.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error toggling availability: {ex.Message}");
                return false;
            }
        }

        // ─────────────────────────────────────────────────
        // GET DONOR STATS
        // Called by: DonorService.GetDashboardStats()
        // Returns: Dictionary of BloodGroup label → count
        //          + totals for dashboard cards
        // ─────────────────────────────────────────────────
        public DonorStats GetDonorStats()
        {
            var stats = new DonorStats();
            try
            {
                using var connection = DatabaseHelper.GetConnection();

                // Total donors
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM Donors;", connection))
                    stats.TotalDonors = Convert.ToInt32(cmd.ExecuteScalar());

                // Available donors
                using (var cmd = new SqliteCommand("SELECT COUNT(*) FROM Donors WHERE IsAvailable = 1;", connection))
                    stats.AvailableDonors = Convert.ToInt32(cmd.ExecuteScalar());

                // Distinct cities
                using (var cmd = new SqliteCommand("SELECT COUNT(DISTINCT City) FROM Donors;", connection))
                    stats.CitiesCovered = Convert.ToInt32(cmd.ExecuteScalar());

                // Count per blood group
                string bgSql = "SELECT BloodGroup, COUNT(*) as Count FROM Donors GROUP BY BloodGroup;";
                using var bgCmd = new SqliteCommand(bgSql, connection);
                using var reader = bgCmd.ExecuteReader();
                while (reader.Read())
                {
                    string bg = reader["BloodGroup"].ToString()!;
                    int count = Convert.ToInt32(reader["Count"]);
                    stats.ByBloodGroup[bg] = count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching stats: {ex.Message}");
            }
            return stats;
        }

        // ─────────────────────────────────────────────────
        // PRIVATE — MAP ROW TO DONOR OBJECT
        // ─────────────────────────────────────────────────
        private Donor MapDonor(SqliteDataReader reader)
        {
            return new Donor
            {
                Id = Convert.ToInt32(reader["Id"]),
                FullName = reader["FullName"].ToString()!,
                BloodGroup = EnumHelper.GetValueFromDescription<BloodGroup>(reader["BloodGroup"].ToString()!),
                Phone = reader["Phone"].ToString()!,
                City = reader["City"].ToString()!,
                Area = reader["Area"].ToString(),
                Age = reader["Age"] != DBNull.Value ? Convert.ToInt32(reader["Age"]) : 0,
                Gender = Enum.Parse<Gender>(reader["Gender"].ToString()!),
                IsAvailable = Convert.ToInt32(reader["IsAvailable"]) == 1,
                LastDonationDate = reader["LastDonationDate"] != DBNull.Value
                                    ? DateTime.Parse(reader["LastDonationDate"].ToString()!)
                                    : null,
                UserId = reader["UserId"] != DBNull.Value
                                    ? Convert.ToInt32(reader["UserId"])
                                    : null,
                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()!)
            };
        }
    }

    // ─────────────────────────────────────────────────
    // DONOR STATS — simple data bag for dashboard cards
    // ─────────────────────────────────────────────────
    public class DonorStats
    {
        public int TotalDonors { get; set; }
        public int AvailableDonors { get; set; }
        public int CitiesCovered { get; set; }
        public Dictionary<string, int> ByBloodGroup { get; set; } = new();
    }
}