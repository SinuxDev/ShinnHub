using FreelancePlatform.Models;
using FreelancePlatform.Repository;
using FreelancePlatform.Services;

namespace FreelancePlatform.UI
{
    public partial class NewFeedForm : Form
    {
        private int userID;
        private string userName;
        private readonly ProjectServices projectService;
        private readonly ProjectRequestServices projectRequestServices = new ProjectRequestServices();

        public NewFeedForm(int userID, string userName)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
            projectService = new ProjectServices();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void NewFeedForm_Load(object sender, EventArgs e)
        {
            LoadAllProjects();
        }

        private void LoadAllProjects()
        {
            List<Project> projects = projectService.GetAllProjects();

            // Clear previous projects
            ProjectsFlowLayoutPanel.Controls.Clear();

            if (projects.Count > 0)
            {
                foreach (var project in projects)
                {
                    Panel projectPanel = CreateProjectPanel(project);
                    ProjectsFlowLayoutPanel.Controls.Add(projectPanel);
                }
            }
            else
            {
                Label noProjectsLabel = new Label
                {
                    Text = "No projects available.",
                    AutoSize = true,
                    ForeColor = Color.Gray
                };
                ProjectsFlowLayoutPanel.Controls.Add(noProjectsLabel);
            }
        }

        private Panel CreateProjectPanel(Project project)
        {
            // Panel
            Panel panel = new Panel
            {
                Width = ProjectsFlowLayoutPanel.Width - 20,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                BackColor = Color.LightGray
            };

            // Title Label
            Label titleLabel = new Label
            {
                Text = project.ProjectTitle,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true
            };

            // Description Label
            Label descriptionLabel = new Label
            {
                Text = project.ProjectDescription,
                AutoSize = true,
                MaximumSize = new Size(panel.Width - 20, 60)
            };

            // Budget Label
            Label budgetLabel = new Label
            {
                Text = $"Budget: {project.ProjectBudget:C}",
                Font = new Font("Arial", 10, FontStyle.Italic),
                AutoSize = true
            };

            // Apply Button
            Button applyButton = new Button
            {
                AutoSize = true
            };

            if (project.isDone == 1)
            {
                applyButton.Text = "Completed";   // Change text
                applyButton.BackColor = Color.Gray; // Change color
                applyButton.Enabled = false; // Disable button
            }
            else
            {
                applyButton.Text = "Apply";
                applyButton.BackColor = Color.Green;
                applyButton.ForeColor = Color.White;
                applyButton.Click += (s, e) => ApplyToProject(project.ProjectID);
            }

            // Add controls to panel
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(budgetLabel);
            panel.Controls.Add(applyButton);

            // Arrange controls
            titleLabel.Location = new Point(10, 10);
            descriptionLabel.Location = new Point(10, 35);
            budgetLabel.Location = new Point(10, 100);
            applyButton.Location = new Point(panel.Width - 100, 100); // Adjusted placement

            return panel;
        }


        private void ApplyToProject(int projectID)
        {
            Project? project = projectService.GetProjectDetails(projectID);

            if (project == null)
            {
                MessageBox.Show("Project not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (project.isApply == 1)
            {
                MessageBox.Show("This project is already applied by others. You cannot apply.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int freelancerID = userID;  // This must exist in users table
            int clientID = project.RelatedClientID;
            string projectTitle = project.ProjectTitle ?? "Untitled Project";

            // Debugging
            MessageBox.Show($"Project is Bid Freelancer ID: {freelancerID}, for Client ID: {clientID}");

            ProjectRequest projectRequest = new ProjectRequest
            {
                RelatedProject = projectID,
                RelatedProjectTitle = projectTitle,
                RelatedFreelancer = freelancerID,
                RelatedClientID = clientID
            };

            bool success = projectRequestServices.AddProjectRequest(projectRequest);

            if (success)
            {
                MessageBox.Show($"Successfully applied to {projectTitle}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllProjects();
            }
            else
            {
                MessageBox.Show("Failed to apply. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OwnProjectCheckButton_Click(object sender, EventArgs e)
        {
            FreelancerDashboard freelancerDashboard = new FreelancerDashboard(userID, userName);
            freelancerDashboard.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
