using FreelancePlatform.Repository;

namespace FreelancePlatform.Services;

public class ClientServices
{
    private readonly ClientRepository repository;

    public ClientServices()
    {
        repository = new ClientRepository();
    }

    public bool RegisterClient(string clientName, string clientEmail, string clientCompany, string clientIndustry, int relatedUser)
    {
        if (string.IsNullOrWhiteSpace(clientName) || string.IsNullOrWhiteSpace(clientEmail) ||
            string.IsNullOrWhiteSpace(clientCompany) || string.IsNullOrWhiteSpace(clientIndustry) || relatedUser <= 0)
        {
            throw new ArgumentException("All fields must be provided.");
        }
        int result = repository.AddClient(clientName, clientEmail, clientCompany, clientIndustry, relatedUser);
        return result > 0;
    }

    public bool ClientProfileExists(int userID)
    {
        return repository.CheckClientProfile(userID);
    }

    public (string clientName, string clientEmail, string clientCompany, string clientIndustry)? SelectClientProfile(int clientID)
    {
        return repository.SelectClientProfile(clientID);
    }

}

