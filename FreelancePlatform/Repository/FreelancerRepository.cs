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

        public Freelancer? GetFreelancerProfile(int userID)
        {
            Freelancer? freelancer = null;
            string query = "SELECT * FROM UserSkills WHERE userID = @userID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            freelancer = new Freelancer
                            {
                                UserID = reader.GetInt32("userID"),
                                UserName = reader.GetString("userName"),
                                UserSkillsIndustry = reader.IsDBNull("userSkillsIndustry") ? "" : reader.GetString("userSkillsIndustry"),
                                UserSkillsOne = reader.IsDBNull("userSkillsOne") ? "" : reader.GetString("userSkillsOne"),
                                UserSkillsTwo = reader.IsDBNull("userSkillsTwo") ? "" : reader.GetString("userSkillsTwo"),
                                UserSkillsThree = reader.IsDBNull("userSkillsThree") ? "" : reader.GetString("userSkillsThree"),
                                UserRole = reader.IsDBNull("userRole") ? "" : reader.GetString("userRole"),
                                UserBio = reader.IsDBNull("userBio") ? "" : reader.GetString("userBio"),
                                UserCountry = reader.IsDBNull("userCountry") ? "" : reader.GetString("userCountry"),
                                UserRegion = reader.IsDBNull("userRegion") ? "" : reader.GetString("userRegion"),
                                UserAddress = reader.IsDBNull("userAddress") ? "" : reader.GetString("userAddress"),
                                UserPhone = reader.IsDBNull("userPhone") ? "" : reader.GetString("userPhone")
                            };
                        }
                    }
                }
            }
            return freelancer;
        }

        public List<Freelancer> GetAllFreelancers()
        {
            List<Freelancer> freelancers = new List<Freelancer>();
            string query = "SELECT * FROM UserSkills";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            freelancers.Add(new Freelancer
                            {
                                UserID = reader.GetInt32("userID"),
                                UserName = reader.GetString("userName"),
                                UserSkillsIndustry = reader.GetString("userSkillsIndustry"),
                                UserSkillsOne = reader.GetString("userSkillsOne"),
                                UserSkillsTwo = reader.GetString("userSkillsTwo"),
                                UserSkillsThree = reader.GetString("userSkillsThree"),
                                UserRole = reader.GetString("userRole"),
                                UserBio = reader.GetString("userBio"),
                                UserCountry = reader.GetString("userCountry"),
                                UserRegion = reader.GetString("userRegion"),
                                UserAddress = reader.GetString("userAddress"),
                                UserPhone = reader.GetString("userPhone")
                            });
                        }
                    }
                }
            }
            return freelancers;
        }

        public List<Project> GetFreelancerCompletedProjects(int freelancerID)
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills " +
                           "FROM Project WHERE isDone = 1 AND relatedProjectFreelancerID = @freelancerID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@freelancerID", freelancerID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projects.Add(new Project
                            {
                                ProjectID = reader.GetInt32("projectID"),
                                ProjectTitle = reader.GetString("projectTitle"),
                                ProjectDescription = reader.GetString("projectDescription"),
                                ProjectBudget = reader.GetDecimal("projectBudget"),
                                ProjectDeadline = reader.GetString("projectDeadline"),
                                ProjectSkills = reader.GetString("projectSkills")
                            });
                        }
                    }
                }
            }
            return projects;
        }


    }
}
