using FreelancePlatform.Services;

namespace FreelancePlatform.UI
{
    public partial class SkillsSetUpFormTwo : Form
    {
        private int userID;
        private string userName;

        private Dictionary<string, List<string>> industrySkills = new Dictionary<string, List<string>>
        {
            { "IT & Networking", new List<string> { "Network Security", "Cloud Computing", "Technical Support" } },
            { "Accounting & Consulting", new List<string> { "Bookkeeping", "Financial Analysis", "Tax Consulting" } },
            { "Admin Support", new List<string> { "Data Entry", "Virtual Assistance", "Project Management" } },
            { "Customer Service", new List<string> { "Help Desk", "Call Center", "Live Chat Support" } },
            { "Data Science & Analytics", new List<string> { "Machine Learning", "Data Visualization", "Big Data Analysis" } },
            { "Design & Creative", new List<string> { "Graphic Design", "Video Editing", "UI/UX Design" } },
            { "Engineering & Architecture", new List<string> { "CAD Design", "Structural Engineering", "Product Design" } },
            { "Share & Marketing", new List<string> { "SEO", "Content Marketing", "Social Media Advertising" } }
        };

        private bool isUpdating = false;

        public SkillsSetUpFormTwo(int userID, string userName)
        {
            InitializeComponent();
            industrySelectBox.SelectedIndexChanged += industrySelectBox_SelectedIndexChanged;
            skillsOneComboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged;
            skillsTwoComboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged;
            skillsThreeComboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged;
            this.userID = userID;
            this.userName = userName;
        }

        private void industrySelectBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (industrySelectBox.SelectedItem != null)
            {
                string selectedIndustry = industrySelectBox.SelectedItem?.ToString() ?? string.Empty;

                if (industrySkills.ContainsKey(selectedIndustry))
                {
                    List<string> skills = new List<string>(industrySkills[selectedIndustry]); // Clone the list

                    // Reset skill combo boxes
                    ResetSkillsComboBox(skillsOneComboBox, skills);
                    ResetSkillsComboBox(skillsTwoComboBox, skills);
                    ResetSkillsComboBox(skillsThreeComboBox, skills);
                }
            }
        }

        private void ResetSkillsComboBox(ComboBox comboBox, List<string> skills)
        {
            comboBox.SelectedIndexChanged -= SkillsComboBox_SelectedIndexChanged; // Disable event
            comboBox.Items.Clear();
            comboBox.Items.AddRange(skills.ToArray());
            comboBox.SelectedIndex = -1; // No selection
            comboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged; // Re-enable event
        }

        private void SkillsComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (isUpdating) return; // Prevent recursion

            isUpdating = true; // Set flag to avoid recursion
            EnsureUniqueSkillSelection();
            isUpdating = false; // Reset flag
        }

        private void EnsureUniqueSkillSelection()
        {
            // Get selected skills
            var selectedSkills = new HashSet<string>();

            string? skillOne = skillsOneComboBox.SelectedItem?.ToString();
            string? skillTwo = skillsTwoComboBox.SelectedItem?.ToString();
            string? skillThree = skillsThreeComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(skillOne)) selectedSkills.Add(skillOne!);
            if (!string.IsNullOrEmpty(skillTwo)) selectedSkills.Add(skillTwo!);
            if (!string.IsNullOrEmpty(skillThree)) selectedSkills.Add(skillThree!);



            selectedSkills.RemoveWhere(skill => skill == null);

            // Update each combo box with remaining available skills
            UpdateComboBox(skillsOneComboBox, selectedSkills);
            UpdateComboBox(skillsTwoComboBox, selectedSkills);
            UpdateComboBox(skillsThreeComboBox, selectedSkills);
        }

        private void UpdateComboBox(ComboBox comboBox, HashSet<string> selectedSkills)
        {
            if (industrySelectBox.SelectedItem == null) return;

            string selectedIndustry = industrySelectBox.SelectedItem?.ToString() ?? string.Empty;
            if (!industrySkills.ContainsKey(selectedIndustry)) return;

            string previousSelection = comboBox.SelectedItem?.ToString() ?? string.Empty;
            List<string> availableSkills = new List<string>(industrySkills[selectedIndustry]);

            // Remove already selected skills except the current selection
            availableSkills.RemoveAll(skill => selectedSkills.Contains(skill) && skill != previousSelection);

            comboBox.SelectedIndexChanged -= SkillsComboBox_SelectedIndexChanged; // Disable event
            comboBox.Items.Clear();
            comboBox.Items.AddRange(availableSkills.ToArray());

            // Restore previous selection if still available
            if (availableSkills.Contains(previousSelection))
            {
                comboBox.SelectedItem = previousSelection;
            }
            else
            {
                comboBox.SelectedIndex = -1; // No selection
            }
            comboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged; // Re-enable event
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            string userRole = UserRoleTextBox.Text.Trim();
            string userBio = UserBioTextBox.Text.Trim();
            string userCountry = UserCountryTextBox.Text.Trim();
            string userAddress = UserAddressTextBox.Text.Trim();
            string userPhone = UserPhoneTextBox.Text.Trim();
            string userRegion = UserRegionTextBox.Text.Trim();

            if (industrySelectBox.SelectedItem == null || skillsOneComboBox.SelectedItem == null || skillsTwoComboBox.SelectedItem == null || skillsThreeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select industry and skills.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userSkillsIndustry = industrySelectBox.SelectedItem?.ToString() ?? string.Empty;
            string userSkillsOne = skillsOneComboBox.SelectedItem?.ToString() ?? string.Empty;
            string userSkillsTwo = skillsTwoComboBox.SelectedItem?.ToString() ?? string.Empty;
            string userSkillsThree = skillsThreeComboBox.SelectedItem?.ToString() ?? string.Empty;

            FreelancerService freelancerService = new FreelancerService();

            bool isRegistered = freelancerService.RegisterFreelancer(
                userName, userID, userSkillsIndustry,
                userSkillsOne, userSkillsTwo, userSkillsThree,
                userRole, userBio, userCountry, userRegion, userAddress, userPhone
            );

            if (isRegistered)
            {
                MessageBox.Show("Freelancer profile created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create freelancer profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
