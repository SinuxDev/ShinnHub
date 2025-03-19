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

                    if (string.IsNullOrEmpty(userType)) // Check for null before using it
                    {
                        MessageBox.Show("User type is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form nextForm;

                    if (userType.Equals("Freelancer", StringComparison.OrdinalIgnoreCase))
                    {
                        nextForm = new SkillsSetUpFormOne();
                    }
                    else if (userType.Equals("Client", StringComparison.OrdinalIgnoreCase))
                    {
                        nextForm = new ClientForm();
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
