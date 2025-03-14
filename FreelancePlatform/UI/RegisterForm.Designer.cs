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
            label1 = new Label();
            label2 = new Label();
            RegisterButton = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 86);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(441, 277);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(100, 35);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 502);
            Controls.Add(RegisterButton);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button RegisterButton;
    }
}
