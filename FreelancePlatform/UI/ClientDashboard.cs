using FreelancePlatform.Models;
using FreelancePlatform.Services;
using FreelancePlatform.UI;

namespace FreelancePlatform
{
    public partial class ClientDashboard : Form
    {
        private int userID;
        private FreelancerService freelancerService;

        public ClientDashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            freelancerService = new FreelancerService();
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

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            LoadFreelancerProfiles();
        }

        private void LoadFreelancerProfiles()
        {
            // Clear previous items before adding new ones
            FreelancerProfileFlowLayoutPanel.Controls.Clear();

            // Fetch freelancer profiles (assuming you have a method to fetch all freelancers)
            List<Freelancer> freelancers = freelancerService.GetAllFreelancers();

            foreach (var freelancer in freelancers)
            {
                // Create a UserControl for each freelancer profile
                FreelancerProfileCard profileCard = new FreelancerProfileCard(freelancer);
                FreelancerProfileFlowLayoutPanel.Controls.Add(profileCard);
            }
        }
    }
}
