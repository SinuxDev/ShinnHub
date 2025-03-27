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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            WelcomeLabel = new Label();
            UserEmailLogin = new Label();
            label2 = new Label();
            userLoginEmailTextBox = new TextBox();
            userLoginPasswordTextBox = new TextBox();
            userLoginButton = new Button();
            panel1 = new Panel();
            showPasswordCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            RegisterFormLinkLabel = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("JetBrains Mono NL", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(80, 29);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(819, 44);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "ShinnHub: Where Talent Meets Opportunity";
            // 
            // UserEmailLogin
            // 
            UserEmailLogin.AutoSize = true;
            UserEmailLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEmailLogin.Location = new Point(293, 154);
            UserEmailLogin.Name = "UserEmailLogin";
            UserEmailLogin.Size = new Size(59, 28);
            UserEmailLogin.TabIndex = 1;
            UserEmailLogin.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(293, 250);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // userLoginEmailTextBox
            // 
            userLoginEmailTextBox.Location = new Point(417, 154);
            userLoginEmailTextBox.Multiline = true;
            userLoginEmailTextBox.Name = "userLoginEmailTextBox";
            userLoginEmailTextBox.Size = new Size(266, 31);
            userLoginEmailTextBox.TabIndex = 3;
            // 
            // userLoginPasswordTextBox
            // 
            userLoginPasswordTextBox.Location = new Point(417, 247);
            userLoginPasswordTextBox.Multiline = true;
            userLoginPasswordTextBox.Name = "userLoginPasswordTextBox";
            userLoginPasswordTextBox.Size = new Size(266, 31);
            userLoginPasswordTextBox.TabIndex = 4;
            // 
            // userLoginButton
            // 
            userLoginButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLoginButton.Location = new Point(395, 352);
            userLoginButton.Name = "userLoginButton";
            userLoginButton.Size = new Size(129, 46);
            userLoginButton.TabIndex = 5;
            userLoginButton.Text = "Login";
            userLoginButton.UseVisualStyleBackColor = true;
            userLoginButton.Click += userLoginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(showPasswordCheckBox);
            panel1.Controls.Add(RegisterFormLinkLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(userLoginPasswordTextBox);
            panel1.Controls.Add(userLoginButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userLoginEmailTextBox);
            panel1.Controls.Add(UserEmailLogin);
            panel1.Location = new Point(-5, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 582);
            panel1.TabIndex = 6;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showPasswordCheckBox.CheckedState.BorderRadius = 0;
            showPasswordCheckBox.CheckedState.BorderThickness = 0;
            showPasswordCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showPasswordCheckBox.Location = new Point(486, 293);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(129, 21);
            showPasswordCheckBox.TabIndex = 10;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showPasswordCheckBox.UncheckedState.BorderRadius = 0;
            showPasswordCheckBox.UncheckedState.BorderThickness = 0;
            showPasswordCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // RegisterFormLinkLabel
            // 
            RegisterFormLinkLabel.AutoSize = true;
            RegisterFormLinkLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterFormLinkLabel.Location = new Point(502, 444);
            RegisterFormLinkLabel.Name = "RegisterFormLinkLabel";
            RegisterFormLinkLabel.Size = new Size(164, 20);
            RegisterFormLinkLabel.TabIndex = 9;
            RegisterFormLinkLabel.TabStop = true;
            RegisterFormLinkLabel.Text = "SignUp your account";
            RegisterFormLinkLabel.LinkClicked += RegisterFormLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 438);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 7;
            label1.Text = "Don't Have An Account ? ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 57);
            label3.Name = "label3";
            label3.Size = new Size(463, 50);
            label3.TabIndex = 6;
            label3.Text = "Login To Start Your Journey";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(128, 128, 255);
            guna2Panel1.Controls.Add(WelcomeLabel);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(-5, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(962, 106);
            guna2Panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(955, 684);
            Controls.Add(guna2Panel1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox showPasswordCheckBox;
    }
}