using FreelancePlatform.Services;
using FreelancePlatform.UI;
namespace FreelancePlatform
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
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

            try
            {
                bool isAuthenticated = userService.AuthenticateUser(userEmail, userPassword);

                if (isAuthenticated)
                {
                    string? userType = userService.GetUserTypeByEmail(userEmail);
                    var userDetails = userService.GetUserDetailsByEmail(userEmail);

                    if (string.IsNullOrEmpty(userType))
                    {
                        MessageBox.Show("User type is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!userDetails.HasValue)
                    {
                        MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int userID = userDetails.Value.UserID;
                    string userName = userDetails.Value.UserName;

                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form nextForm;

                    if (userType.Equals("Freelancer", StringComparison.OrdinalIgnoreCase))
                    {
                        FreelancerService freelancerService = new FreelancerService();
                        bool hasProfile = freelancerService.CheckFreelancerProfile(userID);

                        if (hasProfile)
                        {
                            nextForm = new NewFeedForm(userID, userName); // Redirect to NewFeedForm
                        }
                        else
                        {
                            nextForm = new SkillsSetUpFormOne(userID, userName); // Redirect to SkillsSetUpFormOne
                        }
                    }
                    else if (userType.Equals("Client", StringComparison.OrdinalIgnoreCase))
                    {
                        var clientDetails = userService.GetClientDetailsByEmail(userEmail);

                        if (clientDetails.HasValue)
                        {
                            int clientID = clientDetails.Value.UserID;
                            string clientName = clientDetails.Value.UserName;
                            string clientEmail = clientDetails.Value.UserEmail;

                            ClientServices clientServices = new ClientServices();
                            bool hasClientProfile = clientServices.ClientProfileExists(clientID);

                            if (hasClientProfile)
                            {
                                nextForm = new NewFeedForm(clientID, clientName); // Redirect to NewFeedForm
                            }
                            else
                            {
                                nextForm = new ClientForm(clientID, clientName, clientEmail); // Redirect to ClientForm
                            }
                        }
                        else
                        {
                            MessageBox.Show("Client details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
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
                else
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new();
            registerForm.Show();
            this.Hide();
        }
    }
}
