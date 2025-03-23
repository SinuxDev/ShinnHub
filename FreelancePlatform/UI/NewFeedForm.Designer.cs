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
            ProjectsFlowLayoutPanel = new FlowLayoutPanel();
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
            // NewFeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 541);
            Controls.Add(ProjectsFlowLayoutPanel);
            Name = "NewFeedForm";
            Text = "NewFeedForm";
            Load += NewFeedForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectsFlowLayoutPanel;
    }
}