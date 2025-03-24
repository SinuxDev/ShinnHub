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
                    Width = projectsFlowLayoutPanel.Width - 20,
                    Height = 120,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                Label titleLabel = new Label
                {
                    Text = $"📌 {project.ProjectTitle}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true
                };

                Label descLabel = new Label
                {
                    Text = $"📖 {project.ProjectDescription}",
                    AutoSize = true
                };

                Label budgetLabel = new Label
                {
                    Text = $"💰 Budget: ${project.ProjectBudget}",
                    AutoSize = true
                };

                Label deadlineLabel = new Label
                {
                    Text = $"⏳ Deadline: {project.ProjectDeadline}",
                    AutoSize = true
                };

                Button reviewButton = new Button
                {
                    Text = "Submit Review",
                    AutoSize = true
                };

                reviewButton.Click += (s, e) => OpenReviewForm(project.ProjectID);

                projectPanel.Controls.Add(titleLabel);
                projectPanel.Controls.Add(descLabel);
                projectPanel.Controls.Add(budgetLabel);
                projectPanel.Controls.Add(deadlineLabel);
                projectPanel.Controls.Add(reviewButton);

                // Adjust layout
                titleLabel.Location = new Point(5, 5);
                descLabel.Location = new Point(5, 30);
                budgetLabel.Location = new Point(5, 55);
                deadlineLabel.Location = new Point(5, 80);
                reviewButton.Location = new Point(5, 100);

                projectsFlowLayoutPanel.Controls.Add(projectPanel);
            }
        }

        private void OpenReviewForm(int projectID)
        {
            SubmitReviewForm submitReviewForm = new SubmitReviewForm(userID, projectID);
            submitReviewForm.Show();
        }
    }
}
