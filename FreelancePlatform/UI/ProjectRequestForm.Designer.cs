namespace FreelancePlatform.UI
{
    partial class ProjectRequestForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CreatePostRedirectButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ClientProfileCheckButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            RequestsFlowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            LogOutButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            RedirectToProjectsToSubmit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CreatePostRedirectButton
            // 
            CreatePostRedirectButton.CustomizableEdges = customizableEdges1;
            CreatePostRedirectButton.DisabledState.BorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreatePostRedirectButton.FillColor = Color.FromArgb(255, 192, 192);
            CreatePostRedirectButton.Font = new Font("Segoe UI", 9F);
            CreatePostRedirectButton.ForeColor = Color.Black;
            CreatePostRedirectButton.Location = new Point(26, 318);
            CreatePostRedirectButton.Name = "CreatePostRedirectButton";
            CreatePostRedirectButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CreatePostRedirectButton.Size = new Size(115, 43);
            CreatePostRedirectButton.TabIndex = 5;
            CreatePostRedirectButton.Text = "Create Post";
            // 
            // ClientProfileCheckButton
            // 
            ClientProfileCheckButton.CustomizableEdges = customizableEdges3;
            ClientProfileCheckButton.DisabledState.BorderColor = Color.DarkGray;
            ClientProfileCheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClientProfileCheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClientProfileCheckButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ClientProfileCheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClientProfileCheckButton.FillColor = Color.FromArgb(255, 192, 192);
            ClientProfileCheckButton.Font = new Font("Segoe UI", 9F);
            ClientProfileCheckButton.ForeColor = Color.Black;
            ClientProfileCheckButton.Location = new Point(26, 47);
            ClientProfileCheckButton.Name = "ClientProfileCheckButton";
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 4;
            ClientProfileCheckButton.Text = "Your Profile";
            ClientProfileCheckButton.Click += ClientProfileCheckButton_Click;
            // 
            // RequestsFlowLayoutPanel
            // 
            RequestsFlowLayoutPanel.BackColor = Color.Thistle;
            RequestsFlowLayoutPanel.Dock = DockStyle.Right;
            RequestsFlowLayoutPanel.Location = new Point(219, 0);
            RequestsFlowLayoutPanel.Name = "RequestsFlowLayoutPanel";
            RequestsFlowLayoutPanel.Size = new Size(916, 631);
            RequestsFlowLayoutPanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(RedirectToProjectsToSubmit);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(CreatePostRedirectButton);
            panel1.Controls.Add(ClientProfileCheckButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 636);
            panel1.TabIndex = 8;
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
            LogOutButton.Location = new Point(47, 476);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            LogOutButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LogOutButton.Size = new Size(82, 80);
            LogOutButton.TabIndex = 17;
            LogOutButton.Text = "Logout";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // RedirectToProjectsToSubmit
            // 
            RedirectToProjectsToSubmit.CustomizableEdges = customizableEdges5;
            RedirectToProjectsToSubmit.DisabledState.BorderColor = Color.DarkGray;
            RedirectToProjectsToSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            RedirectToProjectsToSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RedirectToProjectsToSubmit.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            RedirectToProjectsToSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RedirectToProjectsToSubmit.FillColor = Color.FromArgb(255, 192, 192);
            RedirectToProjectsToSubmit.Font = new Font("Segoe UI", 9F);
            RedirectToProjectsToSubmit.ForeColor = Color.White;
            RedirectToProjectsToSubmit.Location = new Point(26, 191);
            RedirectToProjectsToSubmit.Name = "RedirectToProjectsToSubmit";
            RedirectToProjectsToSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            RedirectToProjectsToSubmit.Size = new Size(115, 43);
            RedirectToProjectsToSubmit.TabIndex = 18;
            RedirectToProjectsToSubmit.Text = "Projects";
            RedirectToProjectsToSubmit.Click += RedirectToProjectsToSubmit_Click;
            // 
            // ProjectRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 631);
            Controls.Add(panel1);
            Controls.Add(RequestsFlowLayoutPanel);
            Name = "ProjectRequestForm";
            Text = "ProjectRequestForm";
            Load += ProjectRequestForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton CreatePostRedirectButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton ClientProfileCheckButton;
        private FlowLayoutPanel RequestsFlowLayoutPanel;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton LogOutButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton RedirectToProjectsToSubmit;
    }
}