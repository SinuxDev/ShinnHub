using FreelancePlatform.Models;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.Repository
{
    public class ProjectRequestRepository
    {
        public int AddProjectRequest(ProjectRequest projectRequest)
        {
            string query = "INSERT INTO ProjectRequest (relatedProject, relatedProjectTitle, relatedClientID, relatedFreelancer) VALUES (@relatedProject, @relatedProjectTitle, @relatedClientID, @relatedFreelancer)";
            int rowsAffected = 0;
            using (var db = new dbConnection())
            {
                db.Open();
                var paramRelatedProject = new MySqlParameter("@relatedProject", projectRequest.RelatedProject);
                var paramRelatedProjectTitle = new MySqlParameter("@relatedProjectTitle", projectRequest.RelatedProjectTitle);
                var paramRelatedClientID = new MySqlParameter("@relatedClientID", projectRequest.RelatedClientID);
                var paramRelatedFreelancer = new MySqlParameter("@relatedFreelancer", projectRequest.RelatedFreelancer);
                rowsAffected = db.ExecuteNonQuery(query, paramRelatedProject, paramRelatedClientID, paramRelatedProjectTitle, paramRelatedFreelancer);
                db.Close();
            }
            return rowsAffected;
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
            string updateProjectQuery = "UPDATE Project SET isApply = 1, relatedProjectFreelancerID = (SELECT relatedFreelancer FROM ProjectRequest WHERE projectRequestID = @requestID) WHERE projectID = @projectID";

            using (var db = new dbConnection())
            {
                db.Open();

                // Execute the first query
                var paramRequestID1 = new MySqlParameter("@requestID", requestID);
                int requestUpdated = db.ExecuteNonQuery(updateRequestQuery, new MySqlParameter[] { paramRequestID1 });

                // Execute the second query
                var paramRequestID2 = new MySqlParameter("@requestID", requestID);
                var paramProjectID = new MySqlParameter("@projectID", projectID);
                int projectUpdated = db.ExecuteNonQuery(updateProjectQuery, new MySqlParameter[] { paramRequestID2, paramProjectID });

                db.Close();
                return requestUpdated > 0 && projectUpdated > 0;
            }
        }


    }
}
