using FreelancePlatform.Models;
using MySql.Data.MySqlClient;
using System.Data;
using static FreelancePlatform.Repository.ProjectRepository;

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


        public bool DoesFreelancerProfileExist(int userID)
        {
            string query = "SELECT COUNT(*) FROM UserSkills WHERE userID = @userID";

            using (var db = new dbConnection())
            {
                db.Open();
                var parameter = new MySqlParameter("@userID", MySqlDbType.Int32) { Value = userID };

                object result = db.ExecuteScalar(query, parameter);
                db.Close();

                return Convert.ToInt32(result) > 0; // If count > 0, profile exists
            }
        }

        public List<Project> GetOngoingProjectsForFreelancer(int freelancerID)
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT * FROM Project WHERE relatedProjectFreelancerID = @FreelancerID AND isDone = 0";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@FreelancerID", freelancerID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new Project
                            {
                                ProjectID = reader.GetInt32("projectID"),
                                ProjectTitle = reader.GetString("projectTitle"),
                                ProjectDeadline = reader.IsDBNull("projectDeadline") ? null : reader.GetString("projectDeadline"),
                                ProjectDescription = reader.IsDBNull("projectDescription") ? null : reader.GetString("projectDescription"),
                                ProjectBudget = reader.GetDecimal("projectBudget"),
                                isDone = reader.GetInt32("isDone")
                            });
                        }
                    }
                }
            }
            return projects;
        }

    }
}
