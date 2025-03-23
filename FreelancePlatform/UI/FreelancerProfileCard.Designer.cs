namespace FreelancePlatform.UI
{
    partial class FreelancerProfileCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            lblSkills = new Label();
            lblRole = new Label();
            lblCountry = new Label();
            lblBio = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(80, 43);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "label1";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(80, 102);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(50, 20);
            lblSkills.TabIndex = 1;
            lblSkills.Text = "label1";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(80, 158);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 20);
            lblRole.TabIndex = 2;
            lblRole.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(80, 192);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 20);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "label1";
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Location = new Point(80, 234);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(50, 20);
            lblBio.TabIndex = 4;
            lblBio.Text = "label1";
            // 
            // FreelancerProfileCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBio);
            Controls.Add(lblCountry);
            Controls.Add(lblRole);
            Controls.Add(lblSkills);
            Controls.Add(lblUserName);
            Name = "FreelancerProfileCard";
            Size = new Size(266, 353);
            Load += FreelancerProfileCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblSkills;
        private Label lblRole;
        private Label lblCountry;
        private Label lblBio;
    }
}
