using FreelancePlatform.Repository;

namespace FreelancePlatform.UI
{
    public partial class SubmitReviewForm : Form
    {
        private int userID;
        private int projectID;
        private ProjectServices projectServices;

        public SubmitReviewForm(int userID, int projectID)
        {
            InitializeComponent();
            this.userID = userID;
            this.projectID = projectID;
            projectServices = new ProjectServices();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void SubmitReviewForm_Load(object sender, EventArgs e)
        {

        }


        private void SubmitReviewButtonForProject_Click(object sender, EventArgs e)
        {
            string reviewText = reviewTextBox.Text;
            decimal rating;

            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show("Please enter a review.");
                return;
            }

            if (!decimal.TryParse(ratingNumericUpDown.Text, out rating))
            {
                MessageBox.Show("Invalid rating. Please enter a valid number.");
                return;
            }

            bool success = projectServices.SubmitReview(projectID, userID, reviewText, rating);

            if (success)
            {
                MessageBox.Show("Review submitted successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to submit review. Try again.");
            }
        }
    }
}
