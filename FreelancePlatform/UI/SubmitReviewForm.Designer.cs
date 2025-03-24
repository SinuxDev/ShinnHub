namespace FreelancePlatform.UI
{
    partial class SubmitReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reviewTextBox = new TextBox();
            ratingNumericUpDown = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SubmitReviewButtonForProject = new Button();
            SuspendLayout();
            // 
            // reviewTextBox
            // 
            reviewTextBox.Location = new Point(257, 77);
            reviewTextBox.Name = "reviewTextBox";
            reviewTextBox.Size = new Size(125, 27);
            reviewTextBox.TabIndex = 0;
            // 
            // ratingNumericUpDown
            // 
            ratingNumericUpDown.Location = new Point(257, 151);
            ratingNumericUpDown.Name = "ratingNumericUpDown";
            ratingNumericUpDown.Size = new Size(125, 27);
            ratingNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 84);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Review Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 158);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Rating";
            // 
            // SubmitReviewButtonForProject
            // 
            SubmitReviewButtonForProject.Location = new Point(262, 248);
            SubmitReviewButtonForProject.Name = "SubmitReviewButtonForProject";
            SubmitReviewButtonForProject.Size = new Size(122, 48);
            SubmitReviewButtonForProject.TabIndex = 4;
            SubmitReviewButtonForProject.Text = "Submit";
            SubmitReviewButtonForProject.UseVisualStyleBackColor = true;
            SubmitReviewButtonForProject.Click += SubmitReviewButtonForProject_Click;
            // 
            // SubmitReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitReviewButtonForProject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ratingNumericUpDown);
            Controls.Add(reviewTextBox);
            Name = "SubmitReviewForm";
            Text = "SubmitReviewForm";
            Load += SubmitReviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reviewTextBox;
        private TextBox ratingNumericUpDown;
        private Label label1;
        private Label label2;
        private Button SubmitReviewButtonForProject;
    }
}