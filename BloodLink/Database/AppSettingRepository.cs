using BloodLink.Database;
using Microsoft.Data.Sqlite;

namespace BloodLink.Database
{
    public static class AppSettingsRepository
    {
        public static void SaveSetting(string key, string value)
        {
            using var conn = DatabaseHelper.GetConnection();
            string sql = @"INSERT INTO AppSettings (Key, Value) VALUES (@key, @value)
                           ON CONFLICT(Key) DO UPDATE SET Value = @value;";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@key", key);
            cmd.Parameters.AddWithValue("@value", value);
            cmd.ExecuteNonQuery();
        }

        public static string? GetSetting(string key)
        {
            using var conn = DatabaseHelper.GetConnection();
            string sql = "SELECT Value FROM AppSettings WHERE Key = @key;";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@key", key);
            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }
    }
}