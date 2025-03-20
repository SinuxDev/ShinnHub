namespace FreelancePlatform.Repository;

public class ProjectServices
{
    private readonly ProjectRepository repository;

    public ProjectServices()
    {
        repository = new ProjectRepository();
    }

    public bool AddProject(string projectTitle, string projectDescription, string projectSkills, decimal projectBudget, string projectDeadline, int relatedClient)
    {
        if (string.IsNullOrWhiteSpace(projectTitle) || string.IsNullOrWhiteSpace(projectDescription) || string.IsNullOrWhiteSpace(projectSkills) || projectBudget <= 0 || string.IsNullOrWhiteSpace(projectDeadline) || relatedClient <= 0)
        {
            throw new ArgumentException("All fields must be provided.");
        }
        int result = repository.AddProject(projectTitle, projectDescription, projectSkills, projectBudget, projectDeadline, relatedClient);
        return result > 0;
    }

}
