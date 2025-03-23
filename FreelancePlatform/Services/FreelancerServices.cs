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

    public bool RegisterFreelancer(string userName, int userID, string userSkillsIndustry, string userSkillsOne, string userSkillsTwo, string userSkillsThree, string userRole, string userBio, string userCountry, string userRegion, string userAddress, string userPhone)
    {
        if (string.IsNullOrWhiteSpace(userName) || userID <= 0 ||
            string.IsNullOrWhiteSpace(userSkillsIndustry) || string.IsNullOrWhiteSpace(userSkillsOne) ||
            string.IsNullOrWhiteSpace(userSkillsTwo) || string.IsNullOrWhiteSpace(userSkillsThree) ||
            string.IsNullOrWhiteSpace(userRole) || string.IsNullOrWhiteSpace(userBio) ||
            string.IsNullOrWhiteSpace(userCountry) || string.IsNullOrWhiteSpace(userRegion) ||
            string.IsNullOrWhiteSpace(userAddress) || string.IsNullOrWhiteSpace(userPhone))
        {
            throw new ArgumentException("All fields must be provided.");
        }

        int result = repository.AddFreelancer(userName, userID, userSkillsIndustry, userSkillsOne, userSkillsTwo, userSkillsThree, userRole, userBio, userCountry, userRegion, userAddress, userPhone);
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
}
