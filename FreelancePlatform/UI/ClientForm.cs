using FreelancePlatform.Models;
using FreelancePlatform.Services;

namespace FreelancePlatform.UI
{
    public partial class ClientForm : Form
    {
        private int userID;
        private string userName;
        private string email;
        private ClientServices clientServices;

        public ClientForm(int userID, string userName, string email)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            clientServices = new ClientServices();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ClientDataSaveButton_Click(object sender, EventArgs e)
        {
            string clientCompanyName = ClientCompanyNameTextBox.Text.Trim();
            string clientIndustry = ClientCompanyIndustryComboxBox.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(clientCompanyName) || string.IsNullOrEmpty(clientIndustry))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client newClient = new Client
            {
                ClientName = userName,
                ClientEmail = email,
                ClientCompany = clientCompanyName,
                ClientIndustry = clientIndustry,
                RelatedUser = userID
            };

            try
            {
                bool isRegistered = clientServices.RegisterClient(newClient);

                if (isRegistered)
                {
                    MessageBox.Show("Client registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
