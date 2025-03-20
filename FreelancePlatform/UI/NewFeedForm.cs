namespace FreelancePlatform.UI
{
    public partial class NewFeedForm : Form
    {
        private int userID;
        private string userName;

        public NewFeedForm(int userID, string userName)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
        }

        private void NewFeedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
