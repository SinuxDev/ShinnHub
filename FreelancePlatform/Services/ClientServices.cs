using FreelancePlatform.Models;
using FreelancePlatform.Repository;

namespace FreelancePlatform.Services;

public class ClientServices
{
    private readonly ClientRepository repository;

    public ClientServices()
    {
        repository = new ClientRepository();
    }

    public bool RegisterClient(Client client)
    {
        if (string.IsNullOrWhiteSpace(client.ClientName) || string.IsNullOrWhiteSpace(client.ClientEmail) ||
            string.IsNullOrWhiteSpace(client.ClientCompany) || string.IsNullOrWhiteSpace(client.ClientIndustry) || client.RelatedUser <= 0)
        {
            throw new ArgumentException("All fields must be provided.");
        }
        int result = repository.AddClient(client);
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

