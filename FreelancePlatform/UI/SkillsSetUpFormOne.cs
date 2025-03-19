namespace FreelancePlatform.UI
{
    public partial class SkillsSetUpFormOne : Form
    {
        public SkillsSetUpFormOne()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            SkillsSetUpFormTwo skillsSetUpFormTwo = new SkillsSetUpFormTwo();
            skillsSetUpFormTwo.Show();
            this.Hide();
        }
    }
}
