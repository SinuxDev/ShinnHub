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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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

                if (Application.OpenForms["FreelancerDashboard"] is FreelancerDashboard freelancerDashboard)
                {
                    freelancerDashboard.LoadFreelancerProjects();
                    freelancerDashboard.LoadCompletedProjects();
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update progress. Try again.");
            }
        }
    }
}
