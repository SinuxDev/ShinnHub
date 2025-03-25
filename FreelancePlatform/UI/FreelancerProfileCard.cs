using FreelancePlatform.Models;

namespace FreelancePlatform.UI
{
    public partial class FreelancerProfileCard : UserControl
    {
        private Freelancer freelancer;

        public FreelancerProfileCard(Freelancer freelancer)
        {
            InitializeComponent();
            this.freelancer = freelancer;
            LoadFreelancerData();
            ApplyStyling();
        }

        private void FreelancerProfileCard_Load(object sender, EventArgs e)
        {

        }

        private void LoadFreelancerData()
        {
            lblUserName.Text = $"Username: {freelancer.UserName}";
            lblSkills.Text = $"Skills:\n{freelancer.UserSkillsIndustry}\n" +
                     $"{freelancer.UserSkillsOne}\n" +
                     $"{freelancer.UserSkillsTwo}";

            lblRole.Text = $"Role: {freelancer.UserRole}";
            lblCountry.Text = $"Country: {freelancer.UserCountry}";
            lblBio.Text = $"Bio: {freelancer.UserBio}";
        }

        private void ApplyStyling()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Size = new Size(420, 320); // Increased size

            // Create a layout panel
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(10),
                AutoSize = true
            };

            // Adjust row styles
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            // Username
            lblUserName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblUserName.ForeColor = Color.DarkBlue;
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            lblUserName.Dock = DockStyle.Fill;

            // Skills
            lblSkills.Font = new Font("Arial", 10, FontStyle.Italic);
            lblSkills.ForeColor = Color.Gray;
            lblSkills.TextAlign = ContentAlignment.MiddleLeft;
            lblSkills.Dock = DockStyle.Fill;

            // Role
            lblRole.Font = new Font("Arial", 10, FontStyle.Bold);
            lblRole.ForeColor = Color.Black;
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            lblRole.Dock = DockStyle.Fill;

            // Country
            lblCountry.Font = new Font("Arial", 10, FontStyle.Bold);
            lblCountry.ForeColor = Color.Black;
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            lblCountry.Dock = DockStyle.Fill;

            // Bio
            lblBio.Font = new Font("Arial", 10);
            lblBio.ForeColor = Color.Black;
            lblBio.TextAlign = ContentAlignment.MiddleLeft;
            lblBio.Dock = DockStyle.Fill;
            lblBio.AutoSize = false;
            lblBio.MaximumSize = new Size(this.Width - 40, 80);

            // Add controls to the layout
            layout.Controls.Add(lblUserName, 0, 0);
            layout.Controls.Add(lblSkills, 0, 1);
            layout.Controls.Add(lblRole, 0, 2);
            layout.Controls.Add(lblCountry, 0, 3);
            layout.Controls.Add(lblBio, 0, 4);

            // Add layout to the UserControl
            this.Controls.Add(layout);
        }
    }
}
