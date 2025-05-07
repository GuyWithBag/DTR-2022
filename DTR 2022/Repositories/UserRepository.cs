using DTR_2022.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

namespace DTR_2022.Repositories
{
    class UserRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public bool IsValidUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = SHA1(@password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public string getUserRole(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT role FROM Users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                object execute = cmd.ExecuteScalar();
                return execute?.ToString() ?? string.Empty;
            }
        }

        public User GetUserByUsername(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT name, photo FROM Users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Name = reader["name"]?.ToString(),
                            Photo = reader["photo"]?.ToString()
                        };
                    }
                }
                return null; // Return null if user not found
            }
        }

        public string RegisterUser(User user)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
                {
                    Console.WriteLine("Validation Error: Name and Password are required.");
                    return "400"; // Bad Request: Missing required fields
                }

                // Generate snake_case username from name
                string username = ToSnakeCase(user.Name);
                if (string.IsNullOrWhiteSpace(username) || username.Length > 50)
                {
                    Console.WriteLine("Validation Error: Invalid or too long username generated.");
                    return "400"; // Bad Request: Invalid username
                }

                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Users (username, name, password, role, address, sex, birthdate, contact_info, position, hourly_rate, photo) 
                                VALUES (@username, @name, SHA1(@password), @role, @address, @sex, @birthdate, @contact_info, @position, @hourly_rate, @photo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        char sex = user.Sex?.Length > 0 ? user.Sex[0] : 'M';
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@name", user.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@password", user.Password ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@role", user.Role ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", user.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.Parameters.AddWithValue("@birthdate", user.Birthdate == default ? (object)DBNull.Value : user.Birthdate);
                        cmd.Parameters.AddWithValue("@contact_info", user.ContactInfo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@position", user.Position ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@hourly_rate", user.HourlyRate == 0 ? (object)DBNull.Value : user.HourlyRate);
                        cmd.Parameters.AddWithValue("@photo", user.Photo ?? (object)DBNull.Value);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            return "201"; // Created
                        else
                            return "400"; // Bad Request
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Number} - {ex.Message}");
                if (ex.Number == 1062)
                    return "409"; // Conflict
                return "500"; // Internal Server Error
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return "500"; // Internal Server Error
            }
        }

        private string ToSnakeCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            string result = input.ToLowerInvariant();
            result = Regex.Replace(result, @"[^a-z0-9\s-]", "");
            result = Regex.Replace(result, @"\s+|-+", "_");
            result = Regex.Replace(result, @"_+", "_");
            return result.Trim('_');
        }

        public void LogLogin(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string userIdQuery = "SELECT id FROM Users WHERE username = @username";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                object userIdObj = userIdCmd.ExecuteScalar();
                if (userIdObj == null) return;

                int userId = Convert.ToInt32(userIdObj);

                string query = "INSERT INTO user_log (user_id, event_time, event_type) VALUES (@userId, @eventTime, @eventType)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@eventTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@eventType", "IN");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void LogLogout(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string userIdQuery = "SELECT id FROM Users WHERE username = @username";
                MySqlCommand userIdCmd = new MySqlCommand(userIdQuery, conn);
                userIdCmd.Parameters.AddWithValue("@username", username);
                object userIdObj = userIdCmd.ExecuteScalar();
                if (userIdObj == null) return;

                int userId = Convert.ToInt32(userIdObj);

                string query = "INSERT INTO user_log (user_id, event_time, event_type) VALUES (@userId, @eventTime, @eventType)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@eventTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@eventType", "OUT");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetUserLogs()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT ul.log_id, u.username, ul.event_time, ul.event_type " +
                               "FROM user_log ul " +
                               "JOIN Users u ON ul.user_id = u.id " +
                               "ORDER BY ul.event_time DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}