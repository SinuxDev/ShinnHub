using FreelancePlatform.UI;

namespace FreelancePlatform
{
    public partial class ClientDashboard : Form
    {
        private int userID;


        public ClientDashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void ClientCreatePostButtonClicked_Click(object sender, EventArgs e)
        {
            ProjectPostCreateForm projectPostCreateForm = new ProjectPostCreateForm(userID);
            projectPostCreateForm.Show();
            this.Hide();
        }

        private void ClientProfileCheckButton_Click(object sender, EventArgs e)
        {
            ClientProfileForm clientProfileForm = new ClientProfileForm(userID);
            clientProfileForm.Show();
            this.Hide();
        }
    }
}
