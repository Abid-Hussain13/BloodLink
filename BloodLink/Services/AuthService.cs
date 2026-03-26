using BloodLink.Database;
using BloodLink.Models;

namespace BloodLink.Services
{
    public class AuthService
    {
        // UserRepository is our only way to touch the database
        // AuthService never writes SQL directly — that's the repository's job
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        // ─────────────────────────────────────────
        // LOGIN
        // Called by: LoginForm when user clicks Login
        // Returns: User object if success, null if failed
        // ─────────────────────────────────────────
        public (bool success, string message, User? user) Login(string email, string password)
        {
            // Step 1 — basic input validation
            // No point hitting the database with empty fields
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return (false, "Email and password are required.", null);

            // Step 2 — check if user exists in database
            User? user = _userRepository.GetUserByEmail(email.Trim().ToLower());

            if (user == null)
                return (false, "No account found with this email.", null);

            // Step 3 — verify password against stored hash
            // BCrypt compares plain text password with the stored hash
            // We never decrypt — BCrypt just checks if they match
            bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (!passwordMatch)
                return (false, "Incorrect password.", null);

            // Step 4 — all good, return the user
            return (true, "Login successful.", user);
        }

        // ─────────────────────────────────────────
        // REGISTER
        // Called by: RegisterForm when user clicks Register
        // Returns: success flag + message
        // ─────────────────────────────────────────
        public (bool success, string message) Register(string fullName, string email, string password, string confirmPassword, Role role)
        {
            // Step 1 — validate all fields are filled
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
                return (false, "All fields are required.");

            // Step 2 — validate email format
            if (!IsValidEmail(email))
                return (false, "Please enter a valid email address.");

            // Step 3 — check passwords match
            if (password != confirmPassword)
                return (false, "Passwords do not match.");

            // Step 4 — enforce minimum password length
            if (password.Length < 6)
                return (false, "Password must be at least 6 characters.");

            // Step 5 — check email not already registered
            if (_userRepository.EmailExists(email.Trim().ToLower()))
                return (false, "An account with this email already exists.");

            // Step 6 — hash the password before saving
            // NEVER save plain text passwords
            // BCrypt turns "password123" → "$2a$11$xK9mN..."
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Step 7 — build the User object
            User newUser = new User
            {
                FullName = fullName.Trim(),
                Email = email.Trim().ToLower(),
                Password = hashedPassword,
                Role = role,
                IsAdmin = false,        // nobody can self-assign admin
                IsVerified = false,     // admin verifies donors later
                CreatedAt = DateTime.Now
            };

            // Step 8 — save to database via repository
            bool created = _userRepository.CreateUser(newUser);

            if (!created)
                return (false, "Something went wrong. Please try again.");

            return (true, "Account created successfully.");
        }

        // ─────────────────────────────────────────
        // HELPER — basic email format check
        // Private — only used inside AuthService
        // ─────────────────────────────────────────
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email.Trim().ToLower();
            }
            catch
            {
                return false;
            }
        }
    }
}