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
        }

        private void FreelancerProfileCard_Load(object sender, EventArgs e)
        {

        }

        private void LoadFreelancerData()
        {
            lblUserName.Text = freelancer.UserName;
            lblSkills.Text = $"{freelancer.UserSkillsIndustry}, {freelancer.UserSkillsOne}, {freelancer.UserSkillsTwo}";
            lblRole.Text = freelancer.UserRole;
            lblCountry.Text = freelancer.UserCountry;
            lblBio.Text = freelancer.UserBio;
        }
    }
}
