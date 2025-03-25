namespace FreelancePlatform.UI
{
    public partial class SkillsSetUpFormOne : Form
    {
        private int userID;
        private string userName;

        public SkillsSetUpFormOne(int userID, string userName)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
        }

        private void GetStartedButton2_Click(object sender, EventArgs e)
        {
            SkillsSetUpFormTwo skillsSetUpFormTwo = new SkillsSetUpFormTwo(userID, userName);
            skillsSetUpFormTwo.Show();
            this.Hide();
        }
    }
}
