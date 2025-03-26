using FreelancePlatform.Models;
using FreelancePlatform.Repository;
using static FreelancePlatform.Repository.ProjectRepository;

namespace FreelancePlatform.Services;

public class FreelancerService
{
    private readonly FreelancerRepository repository;

    public FreelancerService()
    {
        repository = new FreelancerRepository();
    }

    public bool RegisterFreelancer(Freelancer freelancer)
    {
        if (string.IsNullOrWhiteSpace(freelancer.UserName) || freelancer.UserID <= 0 ||
            string.IsNullOrWhiteSpace(freelancer.UserSkillsIndustry) || string.IsNullOrWhiteSpace(freelancer.UserSkillsOne) ||
            string.IsNullOrWhiteSpace(freelancer.UserSkillsTwo) || string.IsNullOrWhiteSpace(freelancer.UserSkillsThree) ||
            string.IsNullOrWhiteSpace(freelancer.UserRole) || string.IsNullOrWhiteSpace(freelancer.UserBio) ||
            string.IsNullOrWhiteSpace(freelancer.UserCountry) || string.IsNullOrWhiteSpace(freelancer.UserRegion) ||
            string.IsNullOrWhiteSpace(freelancer.UserAddress) || string.IsNullOrWhiteSpace(freelancer.UserPhone))
        {
            throw new ArgumentException("All fields must be provided.");
        }

        int result = repository.AddFreelancer(freelancer);
        return result > 0;
    }

    public bool CheckFreelancerProfile(int userID)
    {
        FreelancerRepository repository = new FreelancerRepository();
        return repository.DoesFreelancerProfileExist(userID);
    }

    public List<Project> GetFreelancerOngoingProjects(int freelancerID)
    {
        return repository.GetOngoingProjectsForFreelancer(freelancerID);
    }

    public Freelancer? GetFreelancerProfile(int userID)
    {
        return repository.GetFreelancerProfile(userID);
    }

    public List<Freelancer> GetAllFreelancers()
    {
        return repository.GetAllFreelancers();
    }

    public List<Project> GetFreelancerCompletedProjects(int freelancerID)
    {
        return repository.GetFreelancerCompletedProjects(freelancerID);
    }

}
