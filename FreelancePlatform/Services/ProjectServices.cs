using FreelancePlatform.Models;

namespace FreelancePlatform.Repository;

public class ProjectServices
{
    private readonly ProjectRepository repository;

    public ProjectServices()
    {
        repository = new ProjectRepository();
    }

    public bool AddProject(Project project)
    {
        if (string.IsNullOrWhiteSpace(project.ProjectTitle) || string.IsNullOrWhiteSpace(project.ProjectDescription) || string.IsNullOrWhiteSpace(project.ProjectSkills) || project.ProjectBudget <= 0 || string.IsNullOrWhiteSpace(project.ProjectDeadline) || project.RelatedClientID <= 0)
        {
            throw new ArgumentException("All fields must be provided.");
        }

        int result = repository.AddProject(project);
        return result > 0;
    }

    public List<Project> GetProjectsByClientID(int clientID)
    {
        return repository.GetProjectsByClientID(clientID);
    }

    public List<Project> GetAllProjects()
    {
        return repository.GetAllProjects();
    }

    public List<Project> GetAllProjectsToSubmit()
    {
        return repository.GetAllProjectsToSubmit();
    }

    public Project GetProjectDetails(int projectID)
    {
        return repository.GetProjectDetails(projectID);
    }

    public bool SubmitReview(int projectID, int clientID, string reviewText, decimal rating)
    {
        return repository.AddProjectReview(projectID, clientID, reviewText, rating);
    }

    public bool UpdateProjectProgress(int projectID, bool isCompleted)
    {
        return repository.UpdateProjectProgress(projectID, isCompleted);
    }


}
