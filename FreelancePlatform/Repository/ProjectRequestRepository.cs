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


        public class ProjectRequest
        {
            public int ID { get; set; }
            public int RelatedProject { get; set; }
            public string? RelatedProjectTitle { get; set; }
            public int RelatedFreelancer { get; set; }
            public string? Status { get; set; }
        }

        public List<ProjectRequest> GetRequestsForClient(int clientID)
        {
            List<ProjectRequest> requests = new List<ProjectRequest>();
            string query = "SELECT * FROM ProjectRequest WHERE relatedClientID = @clientID AND status = 'pending'";

            using (var db = new dbConnection())
            {
                db.Open();
                var paramClientID = new MySqlParameter("@clientID", clientID);
                using (var reader = db.ExecuteReader(query, paramClientID))
                {
                    while (reader.Read())
                    {
                        ProjectRequest request = new ProjectRequest
                        {
                            ID = reader.GetInt32("projectRequestID"),
                            RelatedProject = reader.GetInt32("relatedProject"),
                            RelatedProjectTitle = reader.GetString("relatedProjectTitle"),
                            RelatedFreelancer = reader.GetInt32("relatedFreelancer"),
                            Status = reader.GetString("status")
                        };
                        requests.Add(request);
                    }
                }
                db.Close();
            }
            return requests;
        }


        public bool AcceptProjectRequest(int requestID, int projectID)
        {
            string updateRequestQuery = "UPDATE ProjectRequest SET status = 'accepted' WHERE projectRequestID = @requestID";
            string updateProjectQuery = "UPDATE Project SET isShow = 1 WHERE projectID = @projectID";

            using (var db = new dbConnection())
            {
                db.Open();
                var paramRequestID = new MySqlParameter("@requestID", requestID);
                var paramProjectID = new MySqlParameter("@projectID", projectID);

                int requestUpdated = db.ExecuteNonQuery(updateRequestQuery, paramRequestID);
                int projectUpdated = db.ExecuteNonQuery(updateProjectQuery, paramProjectID);

                db.Close();
                return requestUpdated > 0 && projectUpdated > 0;
            }
        }
    }
}
