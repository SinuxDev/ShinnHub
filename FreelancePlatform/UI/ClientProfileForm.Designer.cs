namespace FreelancePlatform.UI
{
    partial class ClientProfileForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ClientProfileCheckButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            CreatePostRedirectButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DynamicClientName = new Label();
            DynamicClientEmail = new Label();
            DynamicClientCompany = new Label();
            DynamicClientIndustry = new Label();
            panel1 = new Panel();
            ClientProjectDataGridViews = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientProjectDataGridViews).BeginInit();
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
            ClientProfileCheckButton.Location = new Point(51, 55);
            ClientProfileCheckButton.Name = "ClientProfileCheckButton";
            ClientProfileCheckButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClientProfileCheckButton.Size = new Size(115, 43);
            ClientProfileCheckButton.TabIndex = 2;
            ClientProfileCheckButton.Text = "Your Profile";
            // 
            // CreatePostRedirectButton
            // 
            CreatePostRedirectButton.CustomizableEdges = customizableEdges3;
            CreatePostRedirectButton.DisabledState.BorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CreatePostRedirectButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            CreatePostRedirectButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CreatePostRedirectButton.FillColor = Color.FromArgb(255, 192, 192);
            CreatePostRedirectButton.Font = new Font("Segoe UI", 9F);
            CreatePostRedirectButton.ForeColor = Color.Black;
            CreatePostRedirectButton.Location = new Point(269, 55);
            CreatePostRedirectButton.Name = "CreatePostRedirectButton";
            CreatePostRedirectButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CreatePostRedirectButton.Size = new Size(115, 43);
            CreatePostRedirectButton.TabIndex = 3;
            CreatePostRedirectButton.Text = "Create Post";
            CreatePostRedirectButton.Click += CreatePostRedirectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 161);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Your Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 233);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Client Industry";
            // 
            // DynamicClientName
            // 
            DynamicClientName.AutoSize = true;
            DynamicClientName.Location = new Point(279, 24);
            DynamicClientName.Name = "DynamicClientName";
            DynamicClientName.Size = new Size(107, 20);
            DynamicClientName.TabIndex = 8;
            DynamicClientName.Text = "DynamicName";
            // 
            // DynamicClientEmail
            // 
            DynamicClientEmail.AutoSize = true;
            DynamicClientEmail.Location = new Point(282, 76);
            DynamicClientEmail.Name = "DynamicClientEmail";
            DynamicClientEmail.Size = new Size(104, 20);
            DynamicClientEmail.TabIndex = 9;
            DynamicClientEmail.Text = "DynamicEmail";
            // 
            // DynamicClientCompany
            // 
            DynamicClientCompany.AutoSize = true;
            DynamicClientCompany.Location = new Point(271, 161);
            DynamicClientCompany.Name = "DynamicClientCompany";
            DynamicClientCompany.Size = new Size(130, 20);
            DynamicClientCompany.TabIndex = 10;
            DynamicClientCompany.Text = "DynamicCompany";
            // 
            // DynamicClientIndustry
            // 
            DynamicClientIndustry.AutoSize = true;
            DynamicClientIndustry.Location = new Point(279, 233);
            DynamicClientIndustry.Name = "DynamicClientIndustry";
            DynamicClientIndustry.Size = new Size(157, 20);
            DynamicClientIndustry.TabIndex = 11;
            DynamicClientIndustry.Text = "DynamicClientIndustry";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DynamicClientIndustry);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DynamicClientCompany);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DynamicClientEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DynamicClientName);
            panel1.Location = new Point(51, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 280);
            panel1.TabIndex = 12;
            // 
            // ClientProjectDataGridViews
            // 
            ClientProjectDataGridViews.AllowUserToOrderColumns = true;
            ClientProjectDataGridViews.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ClientProjectDataGridViews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ClientProjectDataGridViews.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ClientProjectDataGridViews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ClientProjectDataGridViews.ColumnHeadersHeight = 22;
            ClientProjectDataGridViews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ClientProjectDataGridViews.DefaultCellStyle = dataGridViewCellStyle3;
            ClientProjectDataGridViews.GridColor = Color.FromArgb(231, 229, 255);
            ClientProjectDataGridViews.Location = new Point(690, 87);
            ClientProjectDataGridViews.Name = "ClientProjectDataGridViews";
            ClientProjectDataGridViews.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ClientProjectDataGridViews.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ClientProjectDataGridViews.RowHeadersVisible = false;
            ClientProjectDataGridViews.RowHeadersWidth = 51;
            ClientProjectDataGridViews.Size = new Size(656, 389);
            ClientProjectDataGridViews.TabIndex = 13;
            ClientProjectDataGridViews.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(128, 255, 255);
            ClientProjectDataGridViews.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            ClientProjectDataGridViews.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            ClientProjectDataGridViews.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ClientProjectDataGridViews.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ClientProjectDataGridViews.ThemeStyle.BackColor = Color.White;
            ClientProjectDataGridViews.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ClientProjectDataGridViews.ThemeStyle.HeaderStyle.Height = 22;
            ClientProjectDataGridViews.ThemeStyle.ReadOnly = false;
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.BackColor = Color.White;
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.Height = 29;
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ClientProjectDataGridViews.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ClientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 660);
            Controls.Add(ClientProjectDataGridViews);
            Controls.Add(panel1);
            Controls.Add(CreatePostRedirectButton);
            Controls.Add(ClientProfileCheckButton);
            Name = "ClientProfileForm";
            Text = "ClientProfileForm";
            Load += ClientProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientProjectDataGridViews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton ClientProfileCheckButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton CreatePostRedirectButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label DynamicClientName;
        private Label DynamicClientEmail;
        private Label DynamicClientCompany;
        private Label DynamicClientIndustry;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ClientProjectDataGridViews;
    }
}