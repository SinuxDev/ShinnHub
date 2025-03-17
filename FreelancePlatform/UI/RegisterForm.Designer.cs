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
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.Location = new Point(441, 83);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(125, 27);
            userNameText.TabIndex = 0;
            // 
            // userPasswordText
            // 
            userPasswordText.Location = new Point(441, 153);
            userPasswordText.Name = "userPasswordText";
            userPasswordText.Size = new Size(125, 27);
            userPasswordText.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(323, 86);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(82, 20);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new Point(335, 160);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new Size(70, 20);
            userPasswordLabel.TabIndex = 3;
            userPasswordLabel.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(441, 414);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(100, 35);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // userEmailText
            // 
            userEmailText.Location = new Point(441, 218);
            userEmailText.Name = "userEmailText";
            userEmailText.Size = new Size(125, 27);
            userEmailText.TabIndex = 5;
            // 
            // UserEmailLabel
            // 
            UserEmailLabel.AutoSize = true;
            UserEmailLabel.Location = new Point(359, 225);
            UserEmailLabel.Name = "UserEmailLabel";
            UserEmailLabel.Size = new Size(46, 20);
            UserEmailLabel.TabIndex = 6;
            UserEmailLabel.Text = "Email";
            // 
            // freelancerRadioButton
            // 
            freelancerRadioButton.AutoSize = true;
            freelancerRadioButton.Location = new Point(441, 307);
            freelancerRadioButton.Name = "freelancerRadioButton";
            freelancerRadioButton.Size = new Size(98, 24);
            freelancerRadioButton.TabIndex = 7;
            freelancerRadioButton.TabStop = true;
            freelancerRadioButton.Text = "Freelancer";
            freelancerRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(584, 307);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Client";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 586);
            Controls.Add(radioButton2);
            Controls.Add(freelancerRadioButton);
            Controls.Add(UserEmailLabel);
            Controls.Add(userEmailText);
            Controls.Add(RegisterButton);
            Controls.Add(userPasswordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(userPasswordText);
            Controls.Add(userNameText);
            Name = "RegisterForm";
            Text = "Register Form";
            Load += Form1_Load;
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
    }
}
