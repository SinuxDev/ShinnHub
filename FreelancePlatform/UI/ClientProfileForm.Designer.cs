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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ClientDashboard = new Guna.UI2.WinForms.Guna2GradientTileButton();
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
            label5 = new Label();
            ProjectFlowLayoutPanel = new FlowLayoutPanel();
            ProjectRequestListShowForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            panel2 = new Panel();
            LogOutButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ClientDashboard
            // 
            ClientDashboard.CustomizableEdges = customizableEdges1;
            ClientDashboard.DisabledState.BorderColor = Color.DarkGray;
            ClientDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            ClientDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClientDashboard.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ClientDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClientDashboard.FillColor = Color.FromArgb(255, 192, 192);
            ClientDashboard.Font = new Font("Segoe UI", 9F);
            ClientDashboard.ForeColor = Color.Black;
            ClientDashboard.Location = new Point(17, 34);
            ClientDashboard.Name = "ClientDashboard";
            ClientDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClientDashboard.Size = new Size(115, 60);
            ClientDashboard.TabIndex = 2;
            ClientDashboard.Text = "Client Dashboard";
            ClientDashboard.Click += ClientDashboard_Click;
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
            CreatePostRedirectButton.Location = new Point(17, 150);
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
            label1.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 127);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 222);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 310);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 6;
            label3.Text = "Your Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 429);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 7;
            label4.Text = "Client Industry";
            // 
            // DynamicClientName
            // 
            DynamicClientName.AutoSize = true;
            DynamicClientName.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DynamicClientName.Location = new Point(217, 127);
            DynamicClientName.Name = "DynamicClientName";
            DynamicClientName.Size = new Size(120, 22);
            DynamicClientName.TabIndex = 8;
            DynamicClientName.Text = "DynamicName";
            // 
            // DynamicClientEmail
            // 
            DynamicClientEmail.AutoSize = true;
            DynamicClientEmail.Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DynamicClientEmail.Location = new Point(217, 222);
            DynamicClientEmail.Name = "DynamicClientEmail";
            DynamicClientEmail.Size = new Size(117, 19);
            DynamicClientEmail.TabIndex = 9;
            DynamicClientEmail.Text = "DynamicEmail";
            // 
            // DynamicClientCompany
            // 
            DynamicClientCompany.AutoSize = true;
            DynamicClientCompany.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DynamicClientCompany.Location = new Point(217, 310);
            DynamicClientCompany.Name = "DynamicClientCompany";
            DynamicClientCompany.Size = new Size(150, 22);
            DynamicClientCompany.TabIndex = 10;
            DynamicClientCompany.Text = "DynamicCompany";
            // 
            // DynamicClientIndustry
            // 
            DynamicClientIndustry.AutoSize = true;
            DynamicClientIndustry.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DynamicClientIndustry.Location = new Point(217, 429);
            DynamicClientIndustry.Name = "DynamicClientIndustry";
            DynamicClientIndustry.Size = new Size(220, 22);
            DynamicClientIndustry.TabIndex = 11;
            DynamicClientIndustry.Text = "DynamicClientIndustry";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DynamicClientIndustry);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DynamicClientCompany);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DynamicClientEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DynamicClientName);
            panel1.Location = new Point(160, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 660);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 34);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 12;
            label5.Text = "Your Profile";
            // 
            // ProjectFlowLayoutPanel
            // 
            ProjectFlowLayoutPanel.AutoScroll = true;
            ProjectFlowLayoutPanel.BackColor = Color.Thistle;
            ProjectFlowLayoutPanel.Dock = DockStyle.Right;
            ProjectFlowLayoutPanel.Location = new Point(603, 0);
            ProjectFlowLayoutPanel.Name = "ProjectFlowLayoutPanel";
            ProjectFlowLayoutPanel.Size = new Size(881, 660);
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
            ProjectRequestListShowForm.Location = new Point(17, 256);
            ProjectRequestListShowForm.Name = "ProjectRequestListShowForm";
            ProjectRequestListShowForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ProjectRequestListShowForm.Size = new Size(115, 43);
            ProjectRequestListShowForm.TabIndex = 13;
            ProjectRequestListShowForm.Text = "Request Lists";
            ProjectRequestListShowForm.Click += ProjectRequestListShowForm_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(LogOutButton);
            panel2.Controls.Add(ClientDashboard);
            panel2.Controls.Add(ProjectRequestListShowForm);
            panel2.Controls.Add(CreatePostRedirectButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 666);
            panel2.TabIndex = 14;
            // 
            // LogOutButton
            // 
            LogOutButton.DisabledState.BorderColor = Color.DarkGray;
            LogOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogOutButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            LogOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogOutButton.Font = new Font("Segoe UI", 9F);
            LogOutButton.ForeColor = Color.White;
            LogOutButton.Location = new Point(37, 523);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            LogOutButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LogOutButton.Size = new Size(82, 80);
            LogOutButton.TabIndex = 14;
            LogOutButton.Text = "Logout";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // ClientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 660);
            Controls.Add(panel2);
            Controls.Add(ProjectFlowLayoutPanel);
            Controls.Add(panel1);
            Name = "ClientProfileForm";
            Text = "ClientProfileForm";
            Load += ClientProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton ClientDashboard;
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
        private Panel panel2;
        private Label label5;
        private Guna.UI2.WinForms.Guna2GradientCircleButton LogOutButton;
    }
}