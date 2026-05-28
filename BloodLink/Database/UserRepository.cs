using BloodLink.Helpers;
using BloodLink.Models;
using Microsoft.Data.Sqlite;
using System.CodeDom;

namespace BloodLink.Database
{
    public class UserRepository
    {
        public bool CreateUser(User user)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = @"
    INSERT INTO Users (Id, FullName, Email, Password, Role, CreatedAt)
    VALUES (@Id, @fullName, @email, @password, @role, @createdAt);
";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@fullName", user.FullName);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role.ToString());
                command.Parameters.AddWithValue("@createdAt", user.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}");
                return false;
            }
        }
        public User? GetUserByEmail(string email)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT * FROM Users WHERE Email = @email;";

                using var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@email", email);

                using var reader = command.ExecuteReader();

                if (reader.Read())
                    return MapUser(reader);

                return null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user: {ex.Message}");
                return null;
            }
        }

        public bool EmailExists(string email)
        {
            using var connection = DatabaseHelper.GetConnection();
            string sql = "SELECT COUNT(*) FROM Users WHERE Email = @email;";

            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@email", email);

            long count = (long)command.ExecuteScalar();
            return count > 0;
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            try
            {
                using var connection = DatabaseHelper.GetConnection();
                string sql = "SELECT * FROM Users ORDER BY CreatedAt DESC;";

                using var command = new SqliteCommand(sql, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                    users.Add(MapUser(reader));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching users: {ex.Message}");
            }

            return users;
        }

        public int DeleteUser(string userId)
        {
            try
            {
                using var conn = BloodLink.Database.DatabaseHelper.GetConnection();
                var cmd = new Microsoft.Data.Sqlite.SqliteCommand(
                    "DELETE FROM Users WHERE Id = @id AND Role != 'Admin';", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting Operator. {ex.Message}");
                throw;
            }
        }

        public bool UpdateUser(User user)
        {
            using var connection = DatabaseHelper.GetConnection();

            string query = @"
                UPDATE Users 
                SET FullName = @FullName, 
                    Email = @Email, 
                    Role = @Role, 
                    Password = @Password 
                WHERE Id = @Id;";

            using SqliteCommand command = new SqliteCommand(query, connection);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Role", user.Role.ToString());
            command.Parameters.AddWithValue("@Password", user.Password); 
            command.Parameters.AddWithValue("@Id", user.Id);

            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }

        public string GetPasswordHashById(string userId)
        {
            using var connection = DatabaseHelper.GetConnection();

            string query = "SELECT Password FROM Users WHERE Id = @Id;";
            using SqliteCommand command = new SqliteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", userId);

            object result = command.ExecuteScalar();
            return result?.ToString() ?? string.Empty;
        }

        private User MapUser(SqliteDataReader reader)
        {
            return new User
            {
                Id = reader["Id"].ToString()!,
                FullName = reader["FullName"].ToString()!,
                Email = reader["Email"].ToString()!,
                Password = reader["Password"].ToString()!,
                Role = Enum.Parse<Role>(reader["Role"].ToString()!),
                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString()!)
            };
        }
    }
}