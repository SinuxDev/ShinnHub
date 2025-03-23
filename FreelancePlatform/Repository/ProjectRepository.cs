using FreelancePlatform.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace FreelancePlatform.Repository
{
    public class ProjectRepository
    {
        public int AddProject(string projectTitle, string projectDescription, string projectSkills, decimal projectBudget, string projectDeadline, int relatedClient)
        {
            string query = "INSERT INTO Project (projectTitle, projectDescription, projectSkills, projectBudget, projectDeadline, relatedClient) VALUES (@projectTitle, @projectDescription, @projectSkills, @projectBudget, @projectDeadline, @relatedClient)";

            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var paramProjectTitle = new MySqlParameter("@projectTitle", projectTitle);
                var paramProjectDescription = new MySqlParameter("@projectDescription", projectDescription);
                var paramProjectSkills = new MySqlParameter("@projectSkills", projectSkills);
                var paramProjectBudget = new MySqlParameter("@projectBudget", projectBudget);
                var paramProjectDeadline = new MySqlParameter("@projectDeadline", projectDeadline);
                var paramRelatedClient = new MySqlParameter("@relatedClient", relatedClient);

                rowsAffected = db.ExecuteNonQuery(query, paramProjectTitle, paramProjectDescription, paramProjectSkills, paramProjectBudget, paramProjectDeadline, paramRelatedClient);
                db.Close();
            }
            return rowsAffected;
        }

        public class Project
        {
            public int ProjectID { get; set; }
            public string? ProjectTitle { get; set; }
            public string? ProjectDescription { get; set; }
            public decimal ProjectBudget { get; set; }
            public string? ProjectDeadline { get; set; }
            public string? ProjectSkills { get; set; }
            public int RelatedClientID { get; set; }
            public int isDone { get; set; }
        }



        public List<Project> GetProjectsByClientID(int clientID)
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills FROM Project WHERE relatedClient = @ClientID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientID);
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

        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills FROM Project WHERE isShow = 0";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
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

        public Project GetProjectDetails(int projectID)
        {
            Project? project = null;
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills, relatedClient, isDone FROM Project WHERE projectID = @ProjectID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            project = new Project
                            {
                                ProjectID = reader.GetInt32("projectID"),
                                ProjectTitle = reader.IsDBNull("projectTitle") ? "Untitled Project" : reader.GetString("projectTitle"),
                                ProjectDescription = reader.IsDBNull("projectDescription") ? null : reader.GetString("projectDescription"),
                                ProjectBudget = reader.GetDecimal("projectBudget"),
                                ProjectDeadline = reader.IsDBNull("projectDeadline") ? null : reader.GetString("projectDeadline"),
                                ProjectSkills = reader.IsDBNull("projectSkills") ? null : reader.GetString("projectSkills"),
                                RelatedClientID = reader.GetInt32("relatedClient"),
                                isDone = reader.GetInt32("isDone")
                            };
                        }
                    }
                }
            }

            return project ?? throw new Exception("Project not found");
        }


    }
}
