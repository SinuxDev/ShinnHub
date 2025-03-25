namespace FreelancePlatform
{
    partial class FreelancerDashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ProjectsFlowLayoutPanel = new FlowLayoutPanel();
            CompletedFlowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            NewFeedsButton = new Guna.UI2.WinForms.Guna2Button();
            LogOutButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProjectsFlowLayoutPanel
            // 
            ProjectsFlowLayoutPanel.BackColor = Color.Thistle;
            ProjectsFlowLayoutPanel.Location = new Point(2, 185);
            ProjectsFlowLayoutPanel.Name = "ProjectsFlowLayoutPanel";
            ProjectsFlowLayoutPanel.Size = new Size(544, 490);
            ProjectsFlowLayoutPanel.TabIndex = 0;
            // 
            // CompletedFlowLayoutPanel
            // 
            CompletedFlowLayoutPanel.BackColor = Color.Thistle;
            CompletedFlowLayoutPanel.Dock = DockStyle.Right;
            CompletedFlowLayoutPanel.Location = new Point(546, 0);
            CompletedFlowLayoutPanel.Name = "CompletedFlowLayoutPanel";
            CompletedFlowLayoutPanel.Size = new Size(530, 679);
            CompletedFlowLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(NewFeedsButton);
            panel1.Location = new Point(-9, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 185);
            panel1.TabIndex = 2;
            // 
            // NewFeedsButton
            // 
            NewFeedsButton.CustomizableEdges = customizableEdges2;
            NewFeedsButton.DisabledState.BorderColor = Color.DarkGray;
            NewFeedsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            NewFeedsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            NewFeedsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            NewFeedsButton.Font = new Font("Segoe UI", 9F);
            NewFeedsButton.ForeColor = Color.White;
            NewFeedsButton.Location = new Point(398, 12);
            NewFeedsButton.Name = "NewFeedsButton";
            NewFeedsButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            NewFeedsButton.Size = new Size(107, 58);
            NewFeedsButton.TabIndex = 2;
            NewFeedsButton.Text = "New Feeds";
            NewFeedsButton.Click += NewFeedsButton_Click;
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
            LogOutButton.Location = new Point(21, 125);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            LogOutButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LogOutButton.Size = new Size(59, 54);
            LogOutButton.TabIndex = 16;
            LogOutButton.Text = "Logout";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // FreelancerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1071, 700);
            Controls.Add(ProjectsFlowLayoutPanel);
            Controls.Add(panel1);
            Controls.Add(CompletedFlowLayoutPanel);
            Name = "FreelancerDashboard";
            Text = "FreelancerDashboard";
            Load += FreelancerDashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectsFlowLayoutPanel;
        private FlowLayoutPanel CompletedFlowLayoutPanel;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button NewFeedsButton;
        private Guna.UI2.WinForms.Guna2GradientCircleButton LogOutButton;
    }
}