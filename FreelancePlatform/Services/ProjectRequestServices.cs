using FreelancePlatform.Models; // ✅ Import the separate ProjectRequest model
using FreelancePlatform.Repository;

namespace FreelancePlatform.Services
{
    public class ProjectRequestServices
    {
        private readonly ProjectRequestRepository repository;

        public ProjectRequestServices()
        {
            repository = new ProjectRequestRepository();
        }

        public bool AddProjectRequest(int relatedProject, string relatedProjectTitle, int relatedClientID, int relatedFreelancer)
        {
            if (relatedProject <= 0 || string.IsNullOrWhiteSpace(relatedProjectTitle) || relatedClientID <= 0 || relatedFreelancer <= 0)
            {
                throw new ArgumentException("All fields must be provided.");
            }

            int result = repository.AddProjectRequest(relatedProject, relatedProjectTitle, relatedClientID, relatedFreelancer);
            return result > 0;
        }

        public List<ProjectRequest> GetRequestsForClient(int clientID)
        {
            var repoRequests = repository.GetRequestsForClient(clientID);

            var serviceRequests = repoRequests.Select(r => new ProjectRequest
            {
                ID = r.ID,
                RelatedProject = r.RelatedProject,
                RelatedProjectTitle = r.RelatedProjectTitle,
                RelatedFreelancer = r.RelatedFreelancer,
                Status = r.Status
            }).ToList();

            return serviceRequests;
        }

        public bool AcceptProjectRequest(int requestID, int projectID)
        {
            if (requestID <= 0 || projectID <= 0)
            {
                throw new ArgumentException("Request ID and Project ID must be provided.");
            }

            return repository.AcceptProjectRequest(requestID, projectID);
        }
    }
}
