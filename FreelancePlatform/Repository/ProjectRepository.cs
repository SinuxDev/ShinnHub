﻿using FreelancePlatform.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace FreelancePlatform.Repository
{
    public class ProjectRepository
    {
        public int AddProject(Project project)
        {
            string query = "INSERT INTO Project (projectTitle, projectDescription, projectSkills, projectBudget, projectDeadline, relatedClient) VALUES (@projectTitle, @projectDescription, @projectSkills, @projectBudget, @projectDeadline, @relatedClient)";

            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var paramProjectTitle = new MySqlParameter("@projectTitle", project.ProjectTitle);
                var paramProjectDescription = new MySqlParameter("@projectDescription", project.ProjectDescription);
                var paramProjectSkills = new MySqlParameter("@projectSkills", project.ProjectSkills);
                var paramProjectBudget = new MySqlParameter("@projectBudget", project.ProjectBudget);
                var paramProjectDeadline = new MySqlParameter("@projectDeadline", project.ProjectDeadline);
                var paramRelatedClient = new MySqlParameter("@relatedClient", project.RelatedClientID);

                rowsAffected = db.ExecuteNonQuery(query, paramProjectTitle, paramProjectDescription, paramProjectSkills, paramProjectBudget, paramProjectDeadline, paramRelatedClient);
                db.Close();
            }
            return rowsAffected;
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
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills, relatedClient, isDone, isApply FROM Project WHERE projectID = @ProjectID";

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
                                isDone = reader.GetInt32("isDone"),
                                isApply = reader.GetInt32("isApply")
                            };
                        }
                    }
                }
            }

            return project ?? throw new Exception("Project not found");
        }

        public bool AddProjectReview(int projectID, int clientID, string reviewText, decimal rating)
        {
            string query = "UPDATE Project SET reviewText = @reviewText, rating = @rating, reviewedByClientID = @clientID, reviewDate = NOW() WHERE projectID = @projectID";

            using (var db = new dbConnection())
            {
                db.Open();
                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@reviewText", reviewText),
            new MySqlParameter("@rating", rating),
            new MySqlParameter("@clientID", clientID),
            new MySqlParameter("@projectID", projectID)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);
                db.Close();
                return rowsAffected > 0;
            }
        }

        public List<Project> GetAllProjectsToSubmit()
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT projectID, projectTitle, projectDescription, projectBudget, projectDeadline, projectSkills FROM Project WHERE isDone = 1";

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

        public bool UpdateProjectProgress(int projectID, bool isCompleted)
        {
            string query = "UPDATE Project SET isDone = @isDone, isShow = @isShow WHERE projectID = @projectID";

            using (var db = new dbConnection())
            {
                db.Open();
                using (var cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@isDone", isCompleted ? 1 : 0);
                    cmd.Parameters.AddWithValue("@isShow", isCompleted ? 1 : 0);
                    cmd.Parameters.AddWithValue("@projectID", projectID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
