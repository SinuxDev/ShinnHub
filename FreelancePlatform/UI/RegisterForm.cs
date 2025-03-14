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

            // Validate inputs.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use the service layer to register the user.
            var userService = new UserService();
            bool success = userService.RegisterUser(username, password);

            if (success)
            {
                MessageBox.Show("User registered successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration failed.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
