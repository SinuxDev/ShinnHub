﻿using FreelancePlatform.Repository;
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


    public bool RegisterUser(string username, string password, string email, string userType)
    {

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Username, password, and email must be provided.");
        }


        if (!IsValidEmail(email))
        {
            throw new ArgumentException("Invalid email format.");
        }


        if (repository.UserExists(username, email))
        {
            throw new ArgumentException("Username or email already exists.");
        }


        if (!IsValidPassword(password))
        {
            throw new ArgumentException("Password must be 8 to 12 characters long and contain at least one lowercase and one uppercase letter.");
        }

        // Hash the password using BCrypt
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        // Pass the hashed password to the repository for storage
        int result = repository.AddUser(username, hashedPassword, email, userType);
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

}
