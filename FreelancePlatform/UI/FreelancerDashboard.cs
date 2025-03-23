using FreelancePlatform.Services;
using static FreelancePlatform.Repository.ProjectRepository;

namespace FreelancePlatform
{
    public partial class FreelancerDashboard : Form
    {
        private int FreelancerID;
        private readonly FreelancerService freelancerService = new FreelancerService();

        public FreelancerDashboard(int FreelancerID)
        {
            InitializeComponent();
            this.FreelancerID = FreelancerID;
            freelancerService = new FreelancerService();
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            LoadFreelancerProjects();
        }

        private void LoadFreelancerProjects()
        {
            List<Project> projects = freelancerService.GetFreelancerOngoingProjects(FreelancerID);

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
                    Text = "No ongoing projects.",
                    AutoSize = true,
                    ForeColor = Color.Gray
                };
                ProjectsFlowLayoutPanel.Controls.Add(noProjectsLabel);
            }
        }


        private Panel CreateProjectPanel(Project project)
        {
            Panel panel = new Panel
            {
                Width = ProjectsFlowLayoutPanel.Width - 20,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                BackColor = Color.LightBlue
            };

            // Project Title
            Label titleLabel = new Label
            {
                Text = project.ProjectTitle,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true
            };

            // Deadline Label
            Label deadlineLabel = new Label
            {
                Text = $"Deadline: {project.ProjectDeadline}",
                ForeColor = Color.Red,
                Font = new Font("Arial", 10, FontStyle.Italic),
                AutoSize = true
            };

            // Progress Button
            Button updateProgressButton = new Button
            {
                Text = "Update Progress",
                AutoSize = true,
                BackColor = Color.Green,
                ForeColor = Color.White
            };
            //updateProgressButton.Click += (s, e) => UpdateProjectProgress(project.ProjectID);

            // Add controls to panel
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(deadlineLabel);
            panel.Controls.Add(updateProgressButton);

            // Arrange controls
            titleLabel.Location = new Point(10, 10);
            deadlineLabel.Location = new Point(10, 40);
            updateProgressButton.Location = new Point(panel.Width - 150, 100);

            return panel;
        }


        //private void UpdateProjectProgress(int projectID)
        //{
        //    // Open a new form where freelancer can update progress
        //    ProgressUpdateForm progressForm = new ProgressUpdateForm(projectID);
        //    progressForm.ShowDialog();
        //}

    }
}
