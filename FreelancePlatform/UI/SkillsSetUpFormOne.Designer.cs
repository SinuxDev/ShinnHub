namespace FreelancePlatform.UI
{
    partial class SkillsSetUpFormOne
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GetStartedButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 37);
            label2.Name = "label2";
            label2.Size = new Size(494, 41);
            label2.TabIndex = 1;
            label2.Text = "Ready for your next big opportunity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 194);
            label1.Name = "label1";
            label1.Size = new Size(366, 20);
            label1.TabIndex = 2;
            label1.Text = "Answer a few questions and start building your profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 269);
            label3.Name = "label3";
            label3.Size = new Size(356, 20);
            label3.TabIndex = 3;
            label3.Text = "Apply for open roles or list services for clients to buy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 338);
            label4.Name = "label4";
            label4.Size = new Size(304, 20);
            label4.TabIndex = 4;
            label4.Text = "Get paid safely and know we're there to help";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 390);
            label5.Name = "label5";
            label5.Size = new Size(326, 40);
            label5.TabIndex = 5;
            label5.Text = "It only taks 3-5 minutes and you can edit it later.\r\nWe'll save as you go.";
            // 
            // GetStartedButton
            // 
            GetStartedButton.Location = new Point(213, 486);
            GetStartedButton.Name = "GetStartedButton";
            GetStartedButton.Size = new Size(158, 63);
            GetStartedButton.TabIndex = 6;
            GetStartedButton.Text = "Get Started";
            GetStartedButton.UseVisualStyleBackColor = true;
            GetStartedButton.Click += GetStartedButton_Click;
            // 
            // SkillsSetUpFormOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 639);
            Controls.Add(GetStartedButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "SkillsSetUpFormOne";
            Text = "SkillsSetUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button GetStartedButton;
    }
}