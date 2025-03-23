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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            ProjectFlowLayoutPanel = new FlowLayoutPanel();
            ProjectRequestListShowForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClientProfileCheckButton
            // 
            ClientProfileCheckButton.CustomizableEdges = customizableEdges1;
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
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 2;
            ClientProfileCheckButton.Text = "Your Profile";
            // 
            // CreatePostRedirectButton
            // 
            CreatePostRedirectButton.CustomizableEdges = customizableEdges3;
            CreatePostRedirectButton.DisabledState.BorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreatePostRedirectButton.FillColor = Color.FromArgb(255, 192, 192);
            CreatePostRedirectButton.Font = new Font("Segoe UI", 9F);
            CreatePostRedirectButton.ForeColor = Color.Black;
            CreatePostRedirectButton.Location = new Point(230, 55);
            CreatePostRedirectButton.Name = "CreatePostRedirectButton";
            CreatePostRedirectButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            // ProjectFlowLayoutPanel
            // 
            ProjectFlowLayoutPanel.AutoScroll = true;
            ProjectFlowLayoutPanel.Dock = DockStyle.Right;
            ProjectFlowLayoutPanel.Location = new Point(552, 0);
            ProjectFlowLayoutPanel.Name = "ProjectFlowLayoutPanel";
            ProjectFlowLayoutPanel.Size = new Size(932, 660);
            ProjectFlowLayoutPanel.TabIndex = 12;
            // 
            // ProjectRequestListShowForm
            // 
            ProjectRequestListShowForm.CustomizableEdges = customizableEdges5;
            ProjectRequestListShowForm.DisabledState.BorderColor = Color.DarkGray;
            ProjectRequestListShowForm.DisabledState.CustomBorderColor = Color.DarkGray;
            ProjectRequestListShowForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ProjectRequestListShowForm.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ProjectRequestListShowForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ProjectRequestListShowForm.FillColor = Color.FromArgb(255, 192, 192);
            ProjectRequestListShowForm.Font = new Font("Segoe UI", 9F);
            ProjectRequestListShowForm.ForeColor = Color.Black;
            ProjectRequestListShowForm.Location = new Point(410, 55);
            ProjectRequestListShowForm.Name = "ProjectRequestListShowForm";
            ProjectRequestListShowForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ProjectRequestListShowForm.Size = new Size(115, 43);
            ProjectRequestListShowForm.TabIndex = 13;
            ProjectRequestListShowForm.Text = "Request Lists";
            ProjectRequestListShowForm.Click += ProjectRequestListShowForm_Click;
            // 
            // ClientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 660);
            Controls.Add(ProjectRequestListShowForm);
            Controls.Add(ProjectFlowLayoutPanel);
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
        private FlowLayoutPanel ProjectFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2GradientTileButton ProjectRequestListShowForm;
    }
}