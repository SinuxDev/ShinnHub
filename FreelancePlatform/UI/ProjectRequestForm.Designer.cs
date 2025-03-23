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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            CreatePostRedirectButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ClientProfileCheckButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ProjectRequestShowForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            RequestsFlowLayoutPanel = new FlowLayoutPanel();
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
            CreatePostRedirectButton.Location = new Point(177, 31);
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
            ClientProfileCheckButton.Location = new Point(12, 31);
            ClientProfileCheckButton.Name = "ClientProfileCheckButton";
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 4;
            ClientProfileCheckButton.Text = "Your Profile";
            // 
            // ProjectRequestShowForm
            // 
            ProjectRequestShowForm.CustomizableEdges = customizableEdges5;
            ProjectRequestShowForm.DisabledState.BorderColor = Color.DarkGray;
            ProjectRequestShowForm.DisabledState.CustomBorderColor = Color.DarkGray;
            ProjectRequestShowForm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ProjectRequestShowForm.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ProjectRequestShowForm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ProjectRequestShowForm.FillColor = Color.FromArgb(255, 192, 192);
            ProjectRequestShowForm.Font = new Font("Segoe UI", 9F);
            ProjectRequestShowForm.ForeColor = Color.Black;
            ProjectRequestShowForm.Location = new Point(353, 31);
            ProjectRequestShowForm.Name = "ProjectRequestShowForm";
            ProjectRequestShowForm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ProjectRequestShowForm.Size = new Size(129, 65);
            ProjectRequestShowForm.TabIndex = 6;
            ProjectRequestShowForm.Text = "Project Request";
            // 
            // RequestsFlowLayoutPanel
            // 
            RequestsFlowLayoutPanel.Dock = DockStyle.Right;
            RequestsFlowLayoutPanel.Location = new Point(521, 0);
            RequestsFlowLayoutPanel.Name = "RequestsFlowLayoutPanel";
            RequestsFlowLayoutPanel.Size = new Size(614, 631);
            RequestsFlowLayoutPanel.TabIndex = 7;
            // 
            // ProjectRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 631);
            Controls.Add(RequestsFlowLayoutPanel);
            Controls.Add(ProjectRequestShowForm);
            Controls.Add(CreatePostRedirectButton);
            Controls.Add(ClientProfileCheckButton);
            Name = "ProjectRequestForm";
            Text = "ProjectRequestForm";
            Load += ProjectRequestForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton CreatePostRedirectButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton ClientProfileCheckButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton ProjectRequestShowForm;
        private FlowLayoutPanel RequestsFlowLayoutPanel;
    }
}