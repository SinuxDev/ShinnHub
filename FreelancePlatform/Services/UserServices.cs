using FreelancePlatform.Repository;

namespace FreelancePlatform.Services;

public class UserService
{
    private readonly UserRepository repository;

    public UserService()
    {
        repository = new UserRepository();
    }


    public bool RegisterUser(string username, string password)
    {

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Username and password must be provided.");
        }

        string CustomSalt = BCrypt.Net.BCrypt.GenerateSalt(12);

        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, CustomSalt);


        int result = repository.AddUser(username, hashedPassword);
        return result > 0;
    }
}
