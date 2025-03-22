namespace FreelancePlatform
{
    partial class ClientDashboard
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
            ClientProfileCheckButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ClientCreatePostButtonClicked = new Guna.UI2.WinForms.Guna2GradientTileButton();
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
            ClientProfileCheckButton.Location = new Point(26, 27);
            ClientProfileCheckButton.Name = "ClientProfileCheckButton";
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 0;
            ClientProfileCheckButton.Text = "Your Profile";
            ClientProfileCheckButton.Click += ClientProfileCheckButton_Click;
            // 
            // ClientCreatePostButtonClicked
            // 
            ClientCreatePostButtonClicked.CustomizableEdges = customizableEdges3;
            ClientCreatePostButtonClicked.DisabledState.BorderColor = Color.DarkGray;
            ClientCreatePostButtonClicked.DisabledState.CustomBorderColor = Color.DarkGray;
            ClientCreatePostButtonClicked.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClientCreatePostButtonClicked.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ClientCreatePostButtonClicked.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClientCreatePostButtonClicked.Font = new Font("Segoe UI", 9F);
            ClientCreatePostButtonClicked.ForeColor = Color.White;
            ClientCreatePostButtonClicked.Location = new Point(210, 27);
            ClientCreatePostButtonClicked.Name = "ClientCreatePostButtonClicked";
            ClientCreatePostButtonClicked.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClientCreatePostButtonClicked.Size = new Size(115, 43);
            ClientCreatePostButtonClicked.TabIndex = 1;
            ClientCreatePostButtonClicked.Text = "Create Post";
            ClientCreatePostButtonClicked.Click += ClientCreatePostButtonClicked_Click;
            // 
            // ClientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 622);
            Controls.Add(ClientCreatePostButtonClicked);
            Controls.Add(ClientProfileCheckButton);
            Name = "ClientDashboard";
            Text = "Client Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton ClientProfileCheckButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton ClientCreatePostButtonClicked;
    }
}