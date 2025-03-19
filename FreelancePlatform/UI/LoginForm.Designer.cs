namespace FreelancePlatform
{
    partial class LoginForm
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
            WelcomeLabel = new Label();
            UserEmailLogin = new Label();
            label2 = new Label();
            userLoginEmailTextBox = new TextBox();
            userLoginPasswordTextBox = new TextBox();
            userLoginButton = new Button();
            panel1 = new Panel();
            RegisterFormLinkLabel = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(84, 28);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(673, 46);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "ShinnHub: Where Talent Meets Opportunity";
            // 
            // UserEmailLogin
            // 
            UserEmailLogin.AutoSize = true;
            UserEmailLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEmailLogin.Location = new Point(61, 119);
            UserEmailLogin.Name = "UserEmailLogin";
            UserEmailLogin.Size = new Size(59, 28);
            UserEmailLogin.TabIndex = 1;
            UserEmailLogin.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 224);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // userLoginEmailTextBox
            // 
            userLoginEmailTextBox.Location = new Point(185, 119);
            userLoginEmailTextBox.Multiline = true;
            userLoginEmailTextBox.Name = "userLoginEmailTextBox";
            userLoginEmailTextBox.Size = new Size(198, 36);
            userLoginEmailTextBox.TabIndex = 3;
            // 
            // userLoginPasswordTextBox
            // 
            userLoginPasswordTextBox.Location = new Point(185, 224);
            userLoginPasswordTextBox.Multiline = true;
            userLoginPasswordTextBox.Name = "userLoginPasswordTextBox";
            userLoginPasswordTextBox.Size = new Size(198, 36);
            userLoginPasswordTextBox.TabIndex = 4;
            // 
            // userLoginButton
            // 
            userLoginButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLoginButton.Location = new Point(173, 330);
            userLoginButton.Name = "userLoginButton";
            userLoginButton.Size = new Size(129, 54);
            userLoginButton.TabIndex = 5;
            userLoginButton.Text = "Login";
            userLoginButton.UseVisualStyleBackColor = true;
            userLoginButton.Click += userLoginButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(RegisterFormLinkLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(userLoginPasswordTextBox);
            panel1.Controls.Add(userLoginButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userLoginEmailTextBox);
            panel1.Controls.Add(UserEmailLogin);
            panel1.Location = new Point(193, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 491);
            panel1.TabIndex = 6;
            // 
            // RegisterFormLinkLabel
            // 
            RegisterFormLinkLabel.AutoSize = true;
            RegisterFormLinkLabel.Location = new Point(267, 450);
            RegisterFormLinkLabel.Name = "RegisterFormLinkLabel";
            RegisterFormLinkLabel.Size = new Size(146, 20);
            RegisterFormLinkLabel.TabIndex = 9;
            RegisterFormLinkLabel.TabStop = true;
            RegisterFormLinkLabel.Text = "SignUp your account";
            RegisterFormLinkLabel.LinkClicked += RegisterFormLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 443);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 7;
            label1.Text = "Don't Have An Account ? ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 18);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 709);
            Controls.Add(panel1);
            Controls.Add(WelcomeLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label UserEmailLogin;
        private Label label2;
        private TextBox userLoginEmailTextBox;
        private TextBox userLoginPasswordTextBox;
        private Button userLoginButton;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private LinkLabel RegisterFormLinkLabel;
    }
}