namespace FreelancePlatform
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameText = new TextBox();
            userPasswordText = new TextBox();
            userNameLabel = new Label();
            userPasswordLabel = new Label();
            RegisterButton = new Button();
            userEmailText = new TextBox();
            UserEmailLabel = new Label();
            freelancerRadioButton = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.Location = new Point(222, 120);
            userNameText.Multiline = true;
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(235, 36);
            userNameText.TabIndex = 0;
            // 
            // userPasswordText
            // 
            userPasswordText.Location = new Point(222, 194);
            userPasswordText.Multiline = true;
            userPasswordText.Name = "userPasswordText";
            userPasswordText.Size = new Size(235, 36);
            userPasswordText.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(59, 120);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(127, 31);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPasswordLabel.Location = new Point(76, 194);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new Size(110, 31);
            userPasswordLabel.TabIndex = 3;
            userPasswordLabel.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(199, 348);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(115, 49);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // userEmailText
            // 
            userEmailText.Location = new Point(222, 40);
            userEmailText.Multiline = true;
            userEmailText.Name = "userEmailText";
            userEmailText.Size = new Size(235, 33);
            userEmailText.TabIndex = 5;
            // 
            // UserEmailLabel
            // 
            UserEmailLabel.AutoSize = true;
            UserEmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEmailLabel.Location = new Point(76, 42);
            UserEmailLabel.Name = "UserEmailLabel";
            UserEmailLabel.Size = new Size(70, 31);
            UserEmailLabel.TabIndex = 6;
            UserEmailLabel.Text = "Email";
            // 
            // freelancerRadioButton
            // 
            freelancerRadioButton.AutoSize = true;
            freelancerRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freelancerRadioButton.Location = new Point(126, 275);
            freelancerRadioButton.Name = "freelancerRadioButton";
            freelancerRadioButton.Size = new Size(122, 32);
            freelancerRadioButton.TabIndex = 7;
            freelancerRadioButton.TabStop = true;
            freelancerRadioButton.Text = "Freelancer";
            freelancerRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(314, 275);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 32);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Client";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(userNameText);
            panel1.Controls.Add(freelancerRadioButton);
            panel1.Controls.Add(userPasswordText);
            panel1.Controls.Add(UserEmailLabel);
            panel1.Controls.Add(userPasswordLabel);
            panel1.Controls.Add(userEmailText);
            panel1.Location = new Point(147, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 446);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 34);
            label1.Name = "label1";
            label1.Size = new Size(375, 50);
            label1.TabIndex = 10;
            label1.Text = "Join ShinnHub Today!";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 646);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "Register Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameText;
        private TextBox userPasswordText;
        private Label userNameLabel;
        private Label userPasswordLabel;
        private Button RegisterButton;
        private TextBox userEmailText;
        private Label UserEmailLabel;
        private RadioButton freelancerRadioButton;
        private RadioButton radioButton2;
        private Panel panel1;
        private Label label1;
    }
}
