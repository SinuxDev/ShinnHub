using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class UserRepository
    {

        public int AddUser(string username, string password, string email, string userType)
        {

            string query = "INSERT INTO Users (userName, userPassword, userEmail, userType) VALUES (@username, @password, @email, @userType)";
            int rowsAffected = 0;

            using (var db = new dbConnection())
            {
                db.Open();

                var paramUsername = new MySqlParameter("@username", username);
                var paramPassword = new MySqlParameter("@password", password);
                var paramEmail = new MySqlParameter("@email", email);
                var paramUserType = new MySqlParameter("@userType", userType);

                rowsAffected = db.ExecuteNonQuery(query, paramUsername, paramPassword, paramEmail, paramUserType);
                db.Close();
            }

            return rowsAffected;
        }

        public bool UserExists(string username, string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE userName = @username OR userEmail = @mail";
            int count = 0;

            using (var db = new MySqlConnection("server=localhost;port=3306;uid=root;password=root;database=freelanceplatform"))
            {
                db.Open();

                using (var cmd = new MySqlCommand(query, db))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@mail", email);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return count > 0;
        }

        public string? GetPasswordByUserEmail(string email)
        {
            string query = "SELECT userPassword FROM Users WHERE userEmail = @mail";
            string? storedHashedPassword = null;

            using (var db = new dbConnection())
            {
                db.Open();

                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@mail", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedHashedPassword = reader.GetString("userPassword");
                        }
                    }
                }

                db.Close();
            }


            return storedHashedPassword;
        }

        public string? GetUserTypeByEmail(string email)
        {
            string query = "SELECT userType FROM Users WHERE userEmail = @userEmail";
            string? userType = null;

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userEmail", email);
                    object? result = cmd.ExecuteScalar();

                    if (result is string userTypeStr) // Null-safe cast
                    {
                        userType = userTypeStr;
                    }
                }
                db.Close();
            }

            return userType; // userType may still be null if no matching record is found
        }

    }
}
