using Microsoft.Data.Sqlite;

namespace BloodLink.Database
{
    public static class DatabaseHelper
    {
        private static readonly string DbFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "BloodLink"
        );

        public static readonly string DbPath = Path.Combine(DbFolder, "bloodlink.db");

        public static readonly string ConnectionString = $"Data Source={DbPath}";

        public static void Initialize()
        {
            if (!Directory.Exists(DbFolder))
                Directory.CreateDirectory(DbFolder);

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            CreateTables(connection);
            SeedAdminUser(connection);
        }

        private static void CreateTables(SqliteConnection connection)
        {
            string sql = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName    TEXT NOT NULL,
                    Email       TEXT UNIQUE NOT NULL,
                    Password    TEXT NOT NULL,
                    Role        TEXT NOT NULL,
                    IsAdmin     INTEGER NOT NULL DEFAULT 0,
                    IsVerified  INTEGER NOT NULL DEFAULT 0,
                    CreatedAt   TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Donors (
                    Id               INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName         TEXT NOT NULL,
                    BloodGroup       TEXT NOT NULL,
                    Phone            TEXT NOT NULL,
                    City             TEXT NOT NULL,
                    Area             TEXT,
                    Age              INTEGER,
                    Gender           TEXT,
                    IsAvailable      INTEGER NOT NULL DEFAULT 1,
                    LastDonationDate TEXT,
                    UserId           INTEGER,
                    CreatedAt        TEXT NOT NULL,
                    FOREIGN KEY (UserId) REFERENCES Users(Id)
                );

                CREATE TABLE IF NOT EXISTS DonationHistory (
                    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                    DonorId      INTEGER NOT NULL,
                    DonationDate TEXT NOT NULL,
                    Hospital     TEXT,
                    Notes        TEXT,
                    FOREIGN KEY (DonorId) REFERENCES Donors(Id)
                );
            ";

            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        private static void SeedAdminUser(SqliteConnection connection)
        {
            string checkSql = "SELECT COUNT(*) FROM Users WHERE IsAdmin = 1;";
            using var checkCmd = new SqliteCommand(checkSql, connection);
            long adminCount = (long)checkCmd.ExecuteScalar();

            if (adminCount > 0) return;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("Admin@123");

            string insertSql = @"
                INSERT INTO Users (FullName, Email, Password, Role, IsAdmin, IsVerified, CreatedAt)
                VALUES ('Administrator', 'admin@bloodlink.com', @password, 'Donor', 1, 1, @createdAt);
            ";

            using var insertCmd = new SqliteCommand(insertSql, connection);
            insertCmd.Parameters.AddWithValue("@password", hashedPassword);
            insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            insertCmd.ExecuteNonQuery();
        }

        public static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}