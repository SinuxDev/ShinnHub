using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class ClientRepository
    {
        public int AddClient(string clientName, string clientEmail, string clientCompany, string clientIndustry, int relatedUser)
        {
            string query = "INSERT INTO Client (clientName, clientEmail, clientCompany, clientIndustry, relatedUser) VALUES (@clientName, @clientEmail, @clientCompany, @clientIndustry, @relatedUser)";
            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var paramClientName = new MySqlParameter("@clientName", clientName);
                var paramClientEmail = new MySqlParameter("@clientEmail", clientEmail);
                var paramClientCompany = new MySqlParameter("@clientCompany", clientCompany);
                var paramClientIndustry = new MySqlParameter("@clientIndustry", clientIndustry);
                var paramRelatedUser = new MySqlParameter("@relatedUser", relatedUser);
                rowsAffected = db.ExecuteNonQuery(query, paramClientName, paramClientEmail, paramClientCompany, paramClientIndustry, paramRelatedUser);
                db.Close();
            }
            return rowsAffected;
        }

        public bool CheckClientProfile(int userID)
        {
            string query = "SELECT COUNT(*) FROM Client WHERE relatedUser = @userID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Return true if client profile exists
                }
            }
        }

    }
}
