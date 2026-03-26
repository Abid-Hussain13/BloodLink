using BloodLink.Models;
using Microsoft.Data.Sqlite;

namespace BloodLink.Database
{
    public class DonationHistoryRepository
    {
        // ─────────────────────────────────────────────────
        // ADD DONATION HISTORY
        // Called by: DonorProfilePage when donor logs a donation
        // Returns: true if saved successfully
        // ─────────────────────────────────────────────────
        public bool AddDonationHistory(DonationHistory history)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = @"
                    INSERT INTO DonationHistory (DonorId, DonationDate, Hospital, Notes)
                    VALUES (@donorId, @donationDate, @hospital, @notes);
                ";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@donorId", history.DonorId);
                command.Parameters.AddWithValue("@donationDate", history.DonationDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@hospital", history.Hospital ?? "");
                command.Parameters.AddWithValue("@notes", history.Notes ?? "");

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving donation history: {ex.Message}");
                return false;
            }
        }

        // ─────────────────────────────────────────────────
        // GET HISTORY BY DONOR ID
        // Called by: DonorProfilePage to show past donations
        // Returns: list sorted newest first
        // ─────────────────────────────────────────────────
        public List<DonationHistory> GetHistoryByDonorId(int donorId)
        {
            var history = new List<DonationHistory>();
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = @"
                    SELECT * FROM DonationHistory
                    WHERE DonorId = @donorId
                    ORDER BY DonationDate DESC;
                ";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@donorId", donorId);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                    history.Add(MapHistory(reader));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching donation history: {ex.Message}");
            }
            return history;
        }

        // ─────────────────────────────────────────────────
        // GET TOTAL DONATIONS COUNT
        // Called by: DonorDashboardPage stat card
        // ─────────────────────────────────────────────────
        public int GetTotalDonationsByDonorId(int donorId)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT COUNT(*) FROM DonationHistory WHERE DonorId = @donorId;";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@donorId", donorId);

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error counting donations: {ex.Message}");
                return 0;
            }
        }

        // ─────────────────────────────────────────────────
        // PRIVATE — MAP ROW TO DONATIONHISTORY OBJECT
        // ─────────────────────────────────────────────────
        private DonationHistory MapHistory(SqliteDataReader reader)
        {
            return new DonationHistory
            {
                Id = Convert.ToInt32(reader["Id"]),
                DonorId = Convert.ToInt32(reader["DonorId"]),
                DonationDate = DateTime.Parse(reader["DonationDate"].ToString()!),
                Hospital = reader["Hospital"].ToString(),
                Notes = reader["Notes"].ToString()
            };
        }
    }
}