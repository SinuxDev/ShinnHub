using FreelancePlatform.Repository;

namespace FreelancePlatform.UI
{
    public partial class ProgressUpdateForm : Form
    {
        private readonly int projectID;
        private readonly ProjectServices projectServices;

        public ProgressUpdateForm(int projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
            projectServices = new ProjectServices();
        }

        private void ProgressUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitProgressButton_Click(object sender, EventArgs e)
        {
            bool isCompleted = chkMarkAsDone.Checked;

            bool success = projectServices.UpdateProjectProgress(projectID, isCompleted);

            if (success)
            {
                MessageBox.Show("Project progress updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update progress. Try again.");
            }
        }
    }
}
