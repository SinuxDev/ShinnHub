using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

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
    }
}
