using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class ProjectRequestRepository
    {
        public int AddProjectRequest(int relatedProject, string relatedProjectTitle, int relatedClientID, int relatedFreelancer)
        {
            string query = "INSERT INTO ProjectRequest (relatedProject, relatedProjectTitle, relatedClientID, relatedFreelancer) VALUES (@relatedProject, @relatedProjectTitle, @relatedClientID, @relatedFreelancer)";
            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var paramRelatedProject = new MySqlParameter("@relatedProject", relatedProject);
                var paramRelatedProjectTitle = new MySqlParameter("@relatedProjectTitle", relatedProjectTitle);
                var paramRelatedClientID = new MySqlParameter("@relatedClientID", relatedClientID);
                var paramRelatedFreelancer = new MySqlParameter("@relatedFreelancer", relatedFreelancer);
                rowsAffected = db.ExecuteNonQuery(query, paramRelatedProject, paramRelatedClientID, paramRelatedProjectTitle, paramRelatedFreelancer);
                db.Close();
            }
            return rowsAffected;
        }
    }
}
