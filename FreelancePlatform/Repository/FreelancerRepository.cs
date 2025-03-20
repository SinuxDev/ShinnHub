using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class FreelancerRepository
    {
        public int AddFreelancer(string userName, int userID, string userSkillsIndustry, string userSkillsOne, string userSkillsTwo, string userSkillsThree, string userRole, string userBio, string userCountry, string userRegion, string userAddress, string userPhone)
        {
            string query = "INSERT INTO UserSkills (userName, userID, userSkillsIndustry, userSkillsOne, userSkillsTwo, userSkillsThree, userRole, userBio, userCountry, userRegion, userAddress, userPhone) " +
                           "VALUES (@userName, @userID, @userSkillsIndustry, @userSkillsOne, @userSkillsTwo, @userSkillsThree, @userRole, @userBio, @userCountry, @userRegion, @userAddress, @userPhone)";

            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@userName", userName),
                    new MySqlParameter("@userID", MySqlDbType.Int32) { Value = userID },
                    new MySqlParameter("@userSkillsIndustry", userSkillsIndustry),
                    new MySqlParameter("@userSkillsOne", userSkillsOne),
                    new MySqlParameter("@userSkillsTwo", userSkillsTwo),
                    new MySqlParameter("@userSkillsThree", userSkillsThree),
                    new MySqlParameter("@userRole", userRole),
                    new MySqlParameter("@userBio", userBio),
                    new MySqlParameter("@userCountry", userCountry),
                    new MySqlParameter("@userRegion", userRegion),
                    new MySqlParameter("@userAddress", userAddress),
                    new MySqlParameter("@userPhone", userPhone)
                };

                rowsAffected = db.ExecuteNonQuery(query, parameters);
                db.Close();
            }
            return rowsAffected;
        }

    }
}
