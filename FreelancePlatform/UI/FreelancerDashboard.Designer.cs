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
            ProjectsFlowLayoutPanel = new FlowLayoutPanel();
            CompletedFlowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ProjectsFlowLayoutPanel
            // 
            ProjectsFlowLayoutPanel.Dock = DockStyle.Right;
            ProjectsFlowLayoutPanel.Location = new Point(607, 0);
            ProjectsFlowLayoutPanel.Name = "ProjectsFlowLayoutPanel";
            ProjectsFlowLayoutPanel.Size = new Size(464, 693);
            ProjectsFlowLayoutPanel.TabIndex = 0;
            // 
            // CompletedFlowLayoutPanel
            // 
            CompletedFlowLayoutPanel.Location = new Point(-3, 42);
            CompletedFlowLayoutPanel.Name = "CompletedFlowLayoutPanel";
            CompletedFlowLayoutPanel.Size = new Size(404, 639);
            CompletedFlowLayoutPanel.TabIndex = 1;
            // 
            // FreelancerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1071, 693);
            Controls.Add(CompletedFlowLayoutPanel);
            Controls.Add(ProjectsFlowLayoutPanel);
            Name = "FreelancerDashboard";
            Text = "FreelancerDashboard";
            Load += FreelancerDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectsFlowLayoutPanel;
        private FlowLayoutPanel CompletedFlowLayoutPanel;
    }
}