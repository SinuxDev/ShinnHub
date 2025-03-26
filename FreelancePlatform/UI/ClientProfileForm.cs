using FreelancePlatform.Models;
using FreelancePlatform.Repository;
using FreelancePlatform.Services;

namespace FreelancePlatform.UI
{
    public partial class ClientProfileForm : Form
    {
        private int clientID;
        private readonly ClientServices clientServices;
        private readonly ProjectServices projectService;

        public ClientProfileForm(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            projectService = new ProjectServices();
            clientServices = new ClientServices();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ClientProfileForm_Load(object sender, EventArgs e)
        {
            LoadClientProfile();
            LoadProjects();
        }

        private void LoadClientProfile()
        {
            var clientData = clientServices.SelectClientProfile(clientID);

            if (clientData.HasValue)
            {
                DynamicClientName.Text = clientData.Value.clientName;
                DynamicClientEmail.Text = clientData.Value.clientEmail;
                DynamicClientCompany.Text = clientData.Value.clientCompany;
                DynamicClientIndustry.Text = clientData.Value.clientIndustry;
            }
            else
            {
                MessageBox.Show("Client data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreatePostRedirectButton_Click(object sender, EventArgs e)
        {
            ProjectPostCreateForm projectPostCreateForm = new ProjectPostCreateForm(clientID);
            projectPostCreateForm.Show();
            this.Hide();
        }

        private void LoadProjects()
        {
            List<Project> projects = projectService.GetProjectsByClientID(clientID);

            ProjectFlowLayoutPanel.Controls.Clear();

            if (projects.Count > 0)
            {
                foreach (var project in projects)
                {
                    Panel projectPanel = CreateProjectPanel(project);
                    ProjectFlowLayoutPanel.Controls.Add(projectPanel);
                }
            }
            else
            {
                Label noProjectsLabel = new Label
                {
                    Text = "No projects found.",
                    AutoSize = true,
                    ForeColor = Color.Gray
                };

                ProjectFlowLayoutPanel.Controls.Add(noProjectsLabel);
            }
        }

        private Panel CreateProjectPanel(Project project)
        {
            Panel panel = new Panel
            {
                Size = new Size(400, 180),  // Adjust size as needed
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(5),
                BackColor = Color.White // Set background color for better visibility
            };

            Label titleLabel = new Label
            {
                Text = project.ProjectTitle,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = Color.Black // Ensure text is visible
            };

            Label descriptionLabel = new Label
            {
                Text = project.ProjectDescription,
                AutoSize = true,
                Location = new Point(10, 40),
                MaximumSize = new Size(380, 40),  // Wrap text if too long
                ForeColor = Color.Black // Ensure text is visible
            };

            Label budgetLabel = new Label
            {
                Text = $"Budget: ${project.ProjectBudget:N2}", // Format budget as currency
                Font = new Font("Arial", 10, FontStyle.Italic),
                AutoSize = true,
                Location = new Point(10, 90),
                ForeColor = Color.Black // Ensure text is visible
            };

            Button viewButton = new Button
            {
                Text = "View Details",
                Size = new Size(100, 30),
                Location = new Point(10, 120),
                FlatStyle = FlatStyle.Flat, // Use flat style for a cleaner look
                FlatAppearance = { BorderSize = 1 }, // Set border size
                ForeColor = Color.Black // Ensure text is visible
            };

            // Add event for View Button (if needed)
            viewButton.Click += (sender, e) => MessageBox.Show($"Project: {project.ProjectTitle}");

            // Add controls to panel
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(budgetLabel);
            panel.Controls.Add(viewButton);

            return panel;
        }

        private void ProjectRequestListShowForm_Click(object sender, EventArgs e)
        {
            ProjectRequestForm projectRequestForm = new ProjectRequestForm(clientID);
            projectRequestForm.Show();
            this.Hide();
        }

        private void ClientDashboard_Click(object sender, EventArgs e)
        {
            ClientDashboard clientDashboard = new ClientDashboard(clientID);
            clientDashboard.Show();
            this.Close();
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
