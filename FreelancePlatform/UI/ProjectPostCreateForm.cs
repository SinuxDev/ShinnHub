using FreelancePlatform.Repository;
using MySql.Data.MySqlClient;

namespace FreelancePlatform.UI
{
    public partial class ProjectPostCreateForm : Form
    {
        private readonly ProjectServices projectServices;

        private int userID;

        public ProjectPostCreateForm(int userID)
        {
            InitializeComponent();
            projectServices = new ProjectServices();
            this.userID = userID;
        }

        private void ClientCreateProjectButton_Click(object sender, EventArgs e)
        {
            ProjectPostCreateForm projectPostCreateForm = new ProjectPostCreateForm(userID);
            projectPostCreateForm.Show();
            this.Close();
        }

        private void PostProjectButton_Click(object sender, EventArgs e)
        {
            string projectTitle = ProjectTitleTextBox.Text.Trim();
            string projectDescription = ProjectDescriptionTextBox.Text.Trim();
            string projectBudgetText = ProjectBudgetTextBox.Text.Trim();
            string projectSkills = ProjectSkillsComboBox.SelectedItem?.ToString() ?? string.Empty;
            string projectDeadline = ProjectDeadlineTextBox.Text.Trim();

            // Validation for empty fields
            if (string.IsNullOrWhiteSpace(projectTitle) || string.IsNullOrWhiteSpace(projectDescription) ||
                string.IsNullOrWhiteSpace(projectBudgetText) || string.IsNullOrWhiteSpace(projectSkills) ||
                string.IsNullOrWhiteSpace(projectDeadline))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that projectBudget is a valid decimal
            if (!decimal.TryParse(projectBudgetText, out decimal projectBudget) || projectBudget <= 0)
            {
                MessageBox.Show("Budget must be a positive number greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // If validation passes, continue processing
            try
            {
                bool isAdded = projectServices.AddProject(projectTitle, projectDescription, projectSkills, projectBudget, projectDeadline, userID);

                if (isAdded)
                {
                    MessageBox.Show("Project posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to post project. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClientProfileCheckButton_Click(object sender, EventArgs e)
        {
            ClientProfileForm clientProfileForm = new ClientProfileForm(userID);
            clientProfileForm.Show();
            this.Hide();
        }

        private void ProjectRequestListShowForm_Click(object sender, EventArgs e)
        {
            ProjectRequestForm projectRequestForm = new ProjectRequestForm(userID);
            projectRequestForm.Show();
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
