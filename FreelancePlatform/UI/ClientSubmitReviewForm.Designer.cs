namespace FreelancePlatform.UI
{
    partial class ClientSubmitReviewForm
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
            projectsFlowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectsFlowLayoutPanel
            // 
            projectsFlowLayoutPanel.AutoScroll = true;
            projectsFlowLayoutPanel.Dock = DockStyle.Right;
            projectsFlowLayoutPanel.Location = new Point(453, 0);
            projectsFlowLayoutPanel.Name = "projectsFlowLayoutPanel";
            projectsFlowLayoutPanel.Size = new Size(552, 604);
            projectsFlowLayoutPanel.TabIndex = 0;
            // 
            // ClientSubmitReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 604);
            Controls.Add(projectsFlowLayoutPanel);
            Name = "ClientSubmitReviewForm";
            Text = "ClientSubmitReviewForm";
            Load += ClientSubmitReviewForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel projectsFlowLayoutPanel;
    }
}