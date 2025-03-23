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
    }
}
