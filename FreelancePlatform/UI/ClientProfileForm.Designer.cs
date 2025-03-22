namespace FreelancePlatform.UI
{
    partial class ClientProfileForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ClientProfileCheckButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            CreatePostRedirectButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DynamicClientName = new Label();
            DynamicClientEmail = new Label();
            DynamicClientCompany = new Label();
            DynamicClientIndustry = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClientProfileCheckButton
            // 
            ClientProfileCheckButton.CustomizableEdges = customizableEdges9;
            ClientProfileCheckButton.DisabledState.BorderColor = Color.DarkGray;
            ClientProfileCheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClientProfileCheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClientProfileCheckButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ClientProfileCheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClientProfileCheckButton.FillColor = Color.FromArgb(255, 192, 192);
            ClientProfileCheckButton.Font = new Font("Segoe UI", 9F);
            ClientProfileCheckButton.ForeColor = Color.Black;
            ClientProfileCheckButton.Location = new Point(51, 55);
            ClientProfileCheckButton.Name = "ClientProfileCheckButton";
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 2;
            ClientProfileCheckButton.Text = "Your Profile";
            // 
            // CreatePostRedirectButton
            // 
            CreatePostRedirectButton.CustomizableEdges = customizableEdges11;
            CreatePostRedirectButton.DisabledState.BorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreatePostRedirectButton.FillColor = Color.FromArgb(255, 192, 192);
            CreatePostRedirectButton.Font = new Font("Segoe UI", 9F);
            CreatePostRedirectButton.ForeColor = Color.Black;
            CreatePostRedirectButton.Location = new Point(269, 55);
            CreatePostRedirectButton.Name = "CreatePostRedirectButton";
            CreatePostRedirectButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            CreatePostRedirectButton.Size = new Size(115, 43);
            CreatePostRedirectButton.TabIndex = 3;
            CreatePostRedirectButton.Text = "Create Post";
            CreatePostRedirectButton.Click += CreatePostRedirectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 161);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Your Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 233);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Client Industry";
            // 
            // DynamicClientName
            // 
            DynamicClientName.AutoSize = true;
            DynamicClientName.Location = new Point(279, 24);
            DynamicClientName.Name = "DynamicClientName";
            DynamicClientName.Size = new Size(107, 20);
            DynamicClientName.TabIndex = 8;
            DynamicClientName.Text = "DynamicName";
            // 
            // DynamicClientEmail
            // 
            DynamicClientEmail.AutoSize = true;
            DynamicClientEmail.Location = new Point(282, 76);
            DynamicClientEmail.Name = "DynamicClientEmail";
            DynamicClientEmail.Size = new Size(104, 20);
            DynamicClientEmail.TabIndex = 9;
            DynamicClientEmail.Text = "DynamicEmail";
            // 
            // DynamicClientCompany
            // 
            DynamicClientCompany.AutoSize = true;
            DynamicClientCompany.Location = new Point(271, 161);
            DynamicClientCompany.Name = "DynamicClientCompany";
            DynamicClientCompany.Size = new Size(130, 20);
            DynamicClientCompany.TabIndex = 10;
            DynamicClientCompany.Text = "DynamicCompany";
            // 
            // DynamicClientIndustry
            // 
            DynamicClientIndustry.AutoSize = true;
            DynamicClientIndustry.Location = new Point(279, 233);
            DynamicClientIndustry.Name = "DynamicClientIndustry";
            DynamicClientIndustry.Size = new Size(157, 20);
            DynamicClientIndustry.TabIndex = 11;
            DynamicClientIndustry.Text = "DynamicClientIndustry";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DynamicClientIndustry);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DynamicClientCompany);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DynamicClientEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DynamicClientName);
            panel1.Location = new Point(51, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 280);
            panel1.TabIndex = 12;
            // 
            // ClientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 660);
            Controls.Add(panel1);
            Controls.Add(CreatePostRedirectButton);
            Controls.Add(ClientProfileCheckButton);
            Name = "ClientProfileForm";
            Text = "ClientProfileForm";
            Load += ClientProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton ClientProfileCheckButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton CreatePostRedirectButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label DynamicClientName;
        private Label DynamicClientEmail;
        private Label DynamicClientCompany;
        private Label DynamicClientIndustry;
        private Panel panel1;
    }
}