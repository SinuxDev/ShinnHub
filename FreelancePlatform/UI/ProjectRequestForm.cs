using FreelancePlatform.Models;
using FreelancePlatform.Services;

namespace FreelancePlatform.UI
{
    public partial class ProjectRequestForm : Form
    {
        private int clientID;
        private readonly ProjectRequestServices projectRequestService;

        public ProjectRequestForm(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            projectRequestService = new ProjectRequestServices();
        }

        private void ProjectRequestForm_Load(object sender, EventArgs e)
        {
            LoadPendingRequests();
        }


        private void LoadPendingRequests()
        {
            List<ProjectRequest> requests = projectRequestService.GetRequestsForClient(clientID);

            RequestsFlowLayoutPanel.Controls.Clear();

            if (requests.Count > 0)
            {
                foreach (var request in requests)
                {
                    Panel requestPanel = CreateRequestPanel(request);
                    RequestsFlowLayoutPanel.Controls.Add(requestPanel);
                }
            }
            else
            {
                Label noRequestsLabel = new Label
                {
                    Text = "No pending project requests.",
                    AutoSize = true,
                    ForeColor = Color.Gray
                };
                RequestsFlowLayoutPanel.Controls.Add(noRequestsLabel);
            }
        }

        private Panel CreateRequestPanel(ProjectRequest request)
        {
            Panel panel = new Panel
            {
                Width = RequestsFlowLayoutPanel.Width - 20,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                BackColor = Color.LightGray
            };

            Label freelancerLabel = new Label
            {
                Text = $"Freelancer ID: {request.RelatedFreelancer}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            Label projectTitleLabel = new Label
            {
                Text = $"Project Title: {request.RelatedProjectTitle}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            Button acceptButton = new Button
            {
                Text = "Accept",
                AutoSize = true,
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            acceptButton.Click += (s, e) => AcceptRequest(request.ID, request.RelatedProject);

            panel.Controls.Add(freelancerLabel);
            panel.Controls.Add(projectTitleLabel);
            panel.Controls.Add(acceptButton);

            freelancerLabel.Location = new Point(10, 10);
            projectTitleLabel.Location = new Point(10, 40);
            acceptButton.Location = new Point(panel.Width - 80, 50);

            return panel;
        }

        private void AcceptRequest(int requestID, int projectID)
        {
            bool success = projectRequestService.AcceptProjectRequest(requestID, projectID);

            if (success)
            {
                MessageBox.Show("Project request accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingRequests(); // Refresh requests
            }
            else
            {
                MessageBox.Show("Failed to accept request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
