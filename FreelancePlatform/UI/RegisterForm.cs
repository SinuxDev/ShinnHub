using FreelancePlatform.Services;

namespace FreelancePlatform
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text.Trim();
            string password = userPasswordText.Text.Trim();
            string email = userEmailText.Text.Trim();
            string userType = freelancerRadioButton.Checked ? "Freelancer" : "Client";

            try
            {
                // Use the service layer to register the user.
                var userService = new UserService();
                bool success = userService.RegisterUser(username, password, email, userType);

                if (success)
                {
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                // Display validation error messages
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Display any other unexpected errors
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
