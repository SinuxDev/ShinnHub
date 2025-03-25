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
            ShowPasswordCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            LoginFormLinkLabel = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.Location = new Point(384, 125);
            userNameText.Multiline = true;
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(235, 36);
            userNameText.TabIndex = 0;
            // 
            // userPasswordText
            // 
            userPasswordText.Location = new Point(384, 199);
            userPasswordText.Multiline = true;
            userPasswordText.Name = "userPasswordText";
            userPasswordText.Size = new Size(235, 36);
            userPasswordText.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(193, 125);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(127, 31);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPasswordLabel.Location = new Point(193, 199);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new Size(110, 31);
            userPasswordLabel.TabIndex = 3;
            userPasswordLabel.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButton.Location = new Point(333, 381);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(122, 55);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // userEmailText
            // 
            userEmailText.Location = new Point(384, 45);
            userEmailText.Multiline = true;
            userEmailText.Name = "userEmailText";
            userEmailText.Size = new Size(235, 33);
            userEmailText.TabIndex = 5;
            // 
            // UserEmailLabel
            // 
            UserEmailLabel.AutoSize = true;
            UserEmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserEmailLabel.Location = new Point(210, 47);
            UserEmailLabel.Name = "UserEmailLabel";
            UserEmailLabel.Size = new Size(70, 31);
            UserEmailLabel.TabIndex = 6;
            UserEmailLabel.Text = "Email";
            // 
            // freelancerRadioButton
            // 
            freelancerRadioButton.AutoSize = true;
            freelancerRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            freelancerRadioButton.Location = new Point(260, 315);
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
            radioButton2.Location = new Point(448, 315);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 32);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Client";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(LoginFormLinkLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(userNameText);
            panel1.Controls.Add(freelancerRadioButton);
            panel1.Controls.Add(userPasswordText);
            panel1.Controls.Add(UserEmailLabel);
            panel1.Controls.Add(userPasswordLabel);
            panel1.Controls.Add(userEmailText);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(-7, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 616);
            panel1.TabIndex = 9;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ShowPasswordCheckBox.CheckedState.BorderRadius = 0;
            ShowPasswordCheckBox.CheckedState.BorderThickness = 0;
            ShowPasswordCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ShowPasswordCheckBox.Location = new Point(502, 270);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(129, 21);
            ShowPasswordCheckBox.TabIndex = 11;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ShowPasswordCheckBox.UncheckedState.BorderRadius = 0;
            ShowPasswordCheckBox.UncheckedState.BorderThickness = 0;
            ShowPasswordCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginFormLinkLabel
            // 
            LoginFormLinkLabel.AutoSize = true;
            LoginFormLinkLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginFormLinkLabel.Location = new Point(421, 476);
            LoginFormLinkLabel.Name = "LoginFormLinkLabel";
            LoginFormLinkLabel.Size = new Size(198, 25);
            LoginFormLinkLabel.TabIndex = 10;
            LoginFormLinkLabel.TabStop = true;
            LoginFormLinkLabel.Text = "Login to your account";
            LoginFormLinkLabel.LinkClicked += LoginFormLinkLabel_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 476);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 9;
            label2.Text = "Already Have An Account ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono NL", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 24);
            label1.Name = "label1";
            label1.Size = new Size(462, 49);
            label1.TabIndex = 10;
            label1.Text = "Join ShinnHub Today!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-7, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 99);
            panel2.TabIndex = 11;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "Register Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Label label2;
        private LinkLabel LoginFormLinkLabel;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPasswordCheckBox;
    }
}
