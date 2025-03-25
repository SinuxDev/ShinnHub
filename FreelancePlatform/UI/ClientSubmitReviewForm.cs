using FreelancePlatform.Repository;
using static FreelancePlatform.Repository.ProjectRepository;

namespace FreelancePlatform.UI
{
    public partial class ClientSubmitReviewForm : Form
    {
        private int userID;
        private ProjectServices projectService;

        public ClientSubmitReviewForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            projectService = new ProjectServices();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ClientSubmitReviewForm_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            projectsFlowLayoutPanel.Controls.Clear(); // Clear previous items
            List<Project> projects = projectService.GetAllProjectsToSubmit();

            foreach (var project in projects)
            {
                Panel projectPanel = new Panel
                {
                    Width = projectsFlowLayoutPanel.Width / 2 - 20, // Reduce width (half of FlowLayoutPanel width)
                    Height = 160, // Increase height to accommodate button on new line
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    BackColor = System.Drawing.Color.White // Add white background
                };

                Label titleLabel = new Label
                {
                    Text = $"📌 {project.ProjectTitle}",
                    Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 10),
                    ForeColor = System.Drawing.Color.Black
                };

                Label descLabel = new Label
                {
                    Text = $"📖 {project.ProjectDescription}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 35),
                    ForeColor = System.Drawing.Color.Black
                };

                Label budgetLabel = new Label
                {
                    Text = $"💰 Budget: ${project.ProjectBudget:N2}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 60),
                    ForeColor = System.Drawing.Color.Black
                };

                Label deadlineLabel = new Label
                {
                    Text = $"⏳ Deadline: {project.ProjectDeadline}",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 85),
                    ForeColor = System.Drawing.Color.Black
                };

                Button reviewButton = new Button
                {
                    Text = "Submit Review",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 115),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1 },
                    ForeColor = System.Drawing.Color.Black
                };

                reviewButton.Click += (s, e) => OpenReviewForm(project.ProjectID);

                projectPanel.Controls.Add(titleLabel);
                projectPanel.Controls.Add(descLabel);
                projectPanel.Controls.Add(budgetLabel);
                projectPanel.Controls.Add(deadlineLabel);
                projectPanel.Controls.Add(reviewButton);

                projectsFlowLayoutPanel.Controls.Add(projectPanel);
            }
        }

        private void OpenReviewForm(int projectID)
        {
            SubmitReviewForm submitReviewForm = new SubmitReviewForm(userID, projectID);
            submitReviewForm.Show();
        }

        private void ClientProfileCheckButton_Click(object sender, EventArgs e)
        {
            ClientProfileForm clientProfileForm = new ClientProfileForm(userID);
            clientProfileForm.Show();
            this.Close();
        }

        private void ClientCreatePostButtonClicked_Click(object sender, EventArgs e)
        {
            ProjectPostCreateForm projectPostCreateForm = new ProjectPostCreateForm(userID);
            projectPostCreateForm.Show();
            this.Close();
        }

        private void ProjectRequestListsButton_Click(object sender, EventArgs e)
        {
            ProjectRequestForm projectRequestForm = new ProjectRequestForm(userID);
            projectRequestForm.Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}