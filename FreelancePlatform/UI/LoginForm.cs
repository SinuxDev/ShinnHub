using FreelancePlatform.Services;
using FreelancePlatform.UI;
using System.Text.RegularExpressions;
namespace FreelancePlatform
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
            userLoginPasswordTextBox.PasswordChar = '\u25cF';
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            string userEmail = userLoginEmailTextBox.Text.Trim();
            string userPassword = userLoginPasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(userEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isAuthenticated = userService.AuthenticateUser(userEmail, userPassword);

                if (isAuthenticated)
                {
                    HandleUserRedirection(userEmail);
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new();
            registerForm.Show();
            this.Hide();
        }

        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userLoginPasswordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '\u25cF';
        }

        private void HandleUserRedirection(string email)
        {
            string? userType = userService.GetUserTypeByEmail(email);
            var userDetails = userService.GetUserDetailsByEmail(email);

            if (string.IsNullOrEmpty(userType) || !userDetails.HasValue)
            {
                MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userID = userDetails.Value.UserID;
            string userName = userDetails.Value.UserName;
            Form nextForm;

            if (userType.Equals("Freelancer", StringComparison.OrdinalIgnoreCase))
            {
                FreelancerService freelancerService = new();
                bool hasFreelancerProfile = freelancerService.CheckFreelancerProfile(userID);

                nextForm = hasFreelancerProfile
                    ? new NewFeedForm(userID, userName)
                    : new SkillsSetUpFormOne(userID, userName);
            }
            else if (userType.Equals("Client", StringComparison.OrdinalIgnoreCase))
            {
                var clientDetails = userService.GetClientDetailsByEmail(email);

                if (!clientDetails.HasValue)
                {
                    // If client details are not found, still allow them to create a profile
                    nextForm = new ClientForm(userID, userName, email);
                }
                else
                {
                    ClientServices clientServices = new();
                    bool hasClientProfile = clientServices.ClientProfileExists(userID);

                    nextForm = hasClientProfile
                        ? new ClientDashboard(clientDetails.Value.UserID)
                        : new ClientForm(clientDetails.Value.UserID, clientDetails.Value.UserName, clientDetails.Value.UserEmail);
                }
            }
            else
            {
                MessageBox.Show("User type is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            nextForm.Show();
        }

    }
}
