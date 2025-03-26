using FreelancePlatform.Models;
using FreelancePlatform.Repository;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace FreelancePlatform.Services;

public class UserService
{
    private readonly UserRepository repository;

    public UserService()
    {
        repository = new UserRepository();
    }


    public bool RegisterUser(User user)
    {

        if (string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.UserPassword) || string.IsNullOrWhiteSpace(user.UserEmail))
        {
            throw new ArgumentException("Username, password, and email must be provided.");
        }


        if (!IsValidEmail(user.UserEmail))
        {
            throw new ArgumentException("Invalid email format.");
        }


        if (repository.UserExists(user.UserName, user.UserEmail))
        {
            throw new ArgumentException("Username or email already exists.");
        }


        if (!IsValidPassword(user.UserPassword))
        {
            throw new ArgumentException("Password must be 8 to 12 characters long and contain at least one lowercase and one uppercase letter.");
        }

        // Hash the password using BCrypt
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.UserPassword);

        // Pass the hashed password to the repository for storage
        int result = repository.AddUser(user);
        return result > 0;
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var mailAddress = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    private bool IsValidPassword(string password)
    {
        // Password must be between 8 and 12 characters long
        if (password.Length < 8 || password.Length > 12)
        {
            return false;
        }

        // Password must contain at least one lowercase and one uppercase letter
        bool hasLowercase = Regex.IsMatch(password, "[a-z]");
        bool hasUppercase = Regex.IsMatch(password, "[A-Z]");

        return hasLowercase && hasUppercase;
    }


    public bool AuthenticateUser(string email, string password)
    {
        string? storedHashedPassword = repository.GetPasswordByUserEmail(email);

        if (string.IsNullOrEmpty(storedHashedPassword))
        {
            return false;
        }

        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

        return isPasswordValid;
    }

    public string? GetUserTypeByEmail(string email)
    {
        return repository.GetUserTypeByEmail(email);
    }

    public (int UserID, string UserName)? GetUserDetailsByEmail(string email)
    {
        string query = "SELECT userID, userName FROM Users WHERE userEmail = @userEmail";

        using (var db = new dbConnection())
        {
            db.Open();
            using (var cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@userEmail", email);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userID = reader.GetInt32("userID");
                        string userName = reader.GetString("userName");
                        return (userID, userName);
                    }
                }
            }
            db.Close();
        }

        return null; // Return null if no user is found
    }


    public (int UserID, string UserName, string UserEmail)? GetClientDetailsByEmail(string email)
    {
        string query = "SELECT ClientID, clientName, clientEmail FROM Client WHERE clientEmail = @clientEmail";

        using (var db = new dbConnection())
        {
            db.Open();
            using (var cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@clientEmail", email);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int clientID = reader.GetInt32("ClientID");
                        string clientName = reader.GetString("clientName");
                        string clientEmail = reader.GetString("clientEmail");
                        return (clientID, clientName, clientEmail);
                    }
                }
            }
            db.Close();
        }

        return null;
    }

}
