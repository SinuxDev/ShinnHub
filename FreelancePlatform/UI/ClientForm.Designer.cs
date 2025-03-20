namespace FreelancePlatform.UI
{
    partial class ClientForm
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
            ClientCompanyNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ClientCompanyIndustryComboxBox = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ClientDataSaveButton = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // ClientCompanyNameTextBox
            // 
            ClientCompanyNameTextBox.CustomizableEdges = customizableEdges1;
            ClientCompanyNameTextBox.DefaultText = "";
            ClientCompanyNameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ClientCompanyNameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ClientCompanyNameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ClientCompanyNameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ClientCompanyNameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ClientCompanyNameTextBox.Font = new Font("Segoe UI", 9F);
            ClientCompanyNameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ClientCompanyNameTextBox.Location = new Point(245, 70);
            ClientCompanyNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ClientCompanyNameTextBox.Name = "ClientCompanyNameTextBox";
            ClientCompanyNameTextBox.PlaceholderText = "";
            ClientCompanyNameTextBox.SelectedText = "";
            ClientCompanyNameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClientCompanyNameTextBox.Size = new Size(158, 35);
            ClientCompanyNameTextBox.TabIndex = 1;
            // 
            // ClientCompanyIndustryComboxBox
            // 
            ClientCompanyIndustryComboxBox.BackColor = Color.Transparent;
            ClientCompanyIndustryComboxBox.CustomizableEdges = customizableEdges3;
            ClientCompanyIndustryComboxBox.DrawMode = DrawMode.OwnerDrawFixed;
            ClientCompanyIndustryComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientCompanyIndustryComboxBox.FocusedColor = Color.FromArgb(94, 148, 255);
            ClientCompanyIndustryComboxBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ClientCompanyIndustryComboxBox.Font = new Font("Segoe UI", 10F);
            ClientCompanyIndustryComboxBox.ForeColor = Color.FromArgb(68, 88, 112);
            ClientCompanyIndustryComboxBox.ItemHeight = 30;
            ClientCompanyIndustryComboxBox.Items.AddRange(new object[] { "IT & Networking", "Software Engineering", "Engineering & Architecture" });
            ClientCompanyIndustryComboxBox.Location = new Point(245, 176);
            ClientCompanyIndustryComboxBox.Name = "ClientCompanyIndustryComboxBox";
            ClientCompanyIndustryComboxBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClientCompanyIndustryComboxBox.Size = new Size(158, 36);
            ClientCompanyIndustryComboxBox.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(87, 83);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(110, 22);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Company Name";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(142, 176);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(55, 22);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Industry";
            // 
            // ClientDataSaveButton
            // 
            ClientDataSaveButton.DisabledState.BorderColor = Color.DarkGray;
            ClientDataSaveButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClientDataSaveButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClientDataSaveButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClientDataSaveButton.Font = new Font("Segoe UI", 9F);
            ClientDataSaveButton.ForeColor = Color.White;
            ClientDataSaveButton.Location = new Point(268, 267);
            ClientDataSaveButton.Name = "ClientDataSaveButton";
            ClientDataSaveButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            ClientDataSaveButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ClientDataSaveButton.Size = new Size(118, 90);
            ClientDataSaveButton.TabIndex = 5;
            ClientDataSaveButton.Text = "Save";
            ClientDataSaveButton.Click += ClientDataSaveButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 459);
            Controls.Add(ClientDataSaveButton);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(ClientCompanyIndustryComboxBox);
            Controls.Add(ClientCompanyNameTextBox);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox ClientCompanyNameTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox ClientCompanyIndustryComboxBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton ClientDataSaveButton;
    }
}