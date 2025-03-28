﻿namespace FreelancePlatform.UI
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ProjectsFlowLayoutPanel = new FlowLayoutPanel();
            OwnProjectCheckButton = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            LogOutButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProjectsFlowLayoutPanel
            // 
            ProjectsFlowLayoutPanel.BackColor = Color.Thistle;
            ProjectsFlowLayoutPanel.Dock = DockStyle.Right;
            ProjectsFlowLayoutPanel.Location = new Point(254, 0);
            ProjectsFlowLayoutPanel.Name = "ProjectsFlowLayoutPanel";
            ProjectsFlowLayoutPanel.Size = new Size(759, 541);
            ProjectsFlowLayoutPanel.TabIndex = 0;
            // 
            // OwnProjectCheckButton
            // 
            OwnProjectCheckButton.CustomizableEdges = customizableEdges4;
            OwnProjectCheckButton.DisabledState.BorderColor = Color.DarkGray;
            OwnProjectCheckButton.DisabledState.CustomBorderColor = Color.DarkGray;
            OwnProjectCheckButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OwnProjectCheckButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OwnProjectCheckButton.Font = new Font("Segoe UI", 9F);
            OwnProjectCheckButton.ForeColor = Color.White;
            OwnProjectCheckButton.Location = new Point(23, 92);
            OwnProjectCheckButton.Name = "OwnProjectCheckButton";
            OwnProjectCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            OwnProjectCheckButton.Size = new Size(139, 56);
            OwnProjectCheckButton.TabIndex = 1;
            OwnProjectCheckButton.Text = "Your Projects";
            OwnProjectCheckButton.Click += OwnProjectCheckButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(OwnProjectCheckButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 547);
            panel1.TabIndex = 2;
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
            LogOutButton.Location = new Point(43, 401);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LogOutButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            LogOutButton.Size = new Size(82, 80);
            LogOutButton.TabIndex = 15;
            LogOutButton.Text = "Logout";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 230);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 16;
            label1.Text = "Browse And Bid Here =>";
            // 
            // NewFeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 541);
            Controls.Add(panel1);
            Controls.Add(ProjectsFlowLayoutPanel);
            Name = "NewFeedForm";
            Text = "NewFeedForm";
            Load += NewFeedForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProjectsFlowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button OwnProjectCheckButton;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton LogOutButton;
        private Label label1;
    }
}