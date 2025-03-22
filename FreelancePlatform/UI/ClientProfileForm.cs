using FreelancePlatform.Repository;
using FreelancePlatform.Services;
using static FreelancePlatform.Repository.ProjectRepository;

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

            if (projects.Count > 0)
            {
                ClientProjectDataGridViews.DataSource = projects;
            }
            else
            {
                MessageBox.Show("No projects found for this client.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
