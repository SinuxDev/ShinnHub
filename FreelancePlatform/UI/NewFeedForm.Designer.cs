namespace FreelancePlatform.UI
{
    partial class NewFeedForm
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
            ProjectsFlowLayoutPanel = new FlowLayoutPanel();
            OwnProjectCheckButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // ProjectsFlowLayoutPanel
            // 
            ProjectsFlowLayoutPanel.Dock = DockStyle.Right;
            ProjectsFlowLayoutPanel.Location = new Point(415, 0);
            ProjectsFlowLayoutPanel.Name = "ProjectsFlowLayoutPanel";
            ProjectsFlowLayoutPanel.Size = new Size(598, 541);
            ProjectsFlowLayoutPanel.TabIndex = 0;
            // 
            // OwnProjectCheckButton
            // 
            OwnProjectCheckButton.CustomizableEdges = customizableEdges1;
            OwnProjectCheckButton.DisabledState.BorderColor = Color.DarkGray;
            OwnProjectCheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            OwnProjectCheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OwnProjectCheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OwnProjectCheckButton.Font = new Font("Segoe UI", 9F);
            OwnProjectCheckButton.ForeColor = Color.White;
            OwnProjectCheckButton.Location = new Point(73, 50);
            OwnProjectCheckButton.Name = "OwnProjectCheckButton";
            OwnProjectCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            OwnProjectCheckButton.Size = new Size(225, 56);
            OwnProjectCheckButton.TabIndex = 1;
            OwnProjectCheckButton.Text = "Your Projects";
            OwnProjectCheckButton.Click += OwnProjectCheckButton_Click;
            // 
            // NewFeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 541);
            Controls.Add(OwnProjectCheckButton);
            Controls.Add(ProjectsFlowLayoutPanel);
            Name = "NewFeedForm";
            Text = "NewFeedForm";
            Load += NewFeedForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectsFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button OwnProjectCheckButton;
    }
}