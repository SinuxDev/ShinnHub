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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            ApplyFlowLayoutStyle();
        }

        private void ApplyFlowLayoutStyle()
        {
            FreelancerProfileFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            FreelancerProfileFlowLayoutPanel.WrapContents = true;
            FreelancerProfileFlowLayoutPanel.AutoScroll = true;
            FreelancerProfileFlowLayoutPanel.Padding = new Padding(10);
        }

        private void LoadFreelancerProfiles()
        {
            // Clear previous items before adding new ones
            FreelancerProfileFlowLayoutPanel.Controls.Clear();

            // Fetch freelancer profiles
            List<Freelancer> freelancers = freelancerService.GetAllFreelancers();

            foreach (var freelancer in freelancers)
            {
                // Create a FreelancerProfileCard for each freelancer
                FreelancerProfileCard profileCard = new FreelancerProfileCard(freelancer);
                profileCard.Margin = new Padding(10); // Add spacing between cards
                FreelancerProfileFlowLayoutPanel.Controls.Add(profileCard);
            }
        }

        private void RedirectToProjectsToSubmit_Click(object sender, EventArgs e)
        {
            ClientSubmitReviewForm clientSubmitReviewForm = new ClientSubmitReviewForm(userID);
            clientSubmitReviewForm.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
