using FreelancePlatform.Services;
using System.Text.RegularExpressions;

namespace FreelancePlatform
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            userPasswordText.PasswordChar = '\u25cF';
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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (password.Length < 6)
            {
                MessageBox.Show("Password must be 8 to 12 characters long and contain at least one lowercase and one uppercase letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Use the service layer to register the user.
                var userService = new UserService();
                bool success = userService.RegisterUser(username, password, email, userType);

                if (success)
                {
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    RedirectToLogin();
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
            RedirectToLogin();
        }

        private static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userPasswordText.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '\u25cF';
        }

        private void ClearFormFields()
        {
            userNameText.Text = string.Empty;
            userPasswordText.Text = string.Empty;
            userEmailText.Text = string.Empty;
            freelancerRadioButton.Checked = false;
            freelancerRadioButton.Checked = false;
            ShowPasswordCheckBox.Checked = false;
        }

        private void RedirectToLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
