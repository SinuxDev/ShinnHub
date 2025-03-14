using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class UserRepository
    {

        public int AddUser(string username, string password)
        {

            string query = "INSERT INTO Users (userName, userPassword) VALUES (@username, @password)";
            int rowsAffected = 0;

            using (var db = new dbConnection())
            {
                db.Open();

                var paramUsername = new MySqlParameter("@username", username);
                var paramPassword = new MySqlParameter("@password", password);

                rowsAffected = db.ExecuteNonQuery(query, paramUsername, paramPassword);
                db.Close();
            }

            return rowsAffected;
        }

        // (Optionally, add other CRUD methods here...)
    }
}
