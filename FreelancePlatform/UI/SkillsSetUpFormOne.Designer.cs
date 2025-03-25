namespace FreelancePlatform.UI
{
    partial class SkillsSetUpFormOne
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            GetStartedButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(946, 60);
            label2.TabIndex = 1;
            label2.Text = "Ready for your next big opportunity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 180);
            label1.Name = "label1";
            label1.Size = new Size(769, 30);
            label1.TabIndex = 2;
            label1.Text = "Answer a few questions and start building your profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(255, 273);
            label3.Name = "label3";
            label3.Size = new Size(797, 30);
            label3.TabIndex = 3;
            label3.Text = "Apply for open roles or list services for clients to buy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(255, 369);
            label4.Name = "label4";
            label4.Size = new Size(629, 30);
            label4.TabIndex = 4;
            label4.Text = "Get paid safely and know we're there to help";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(GetStartedButton2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 642);
            panel1.TabIndex = 7;
            // 
            // GetStartedButton2
            // 
            GetStartedButton2.DisabledState.BorderColor = Color.DarkGray;
            GetStartedButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            GetStartedButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GetStartedButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GetStartedButton2.FillColor = Color.FromArgb(128, 128, 255);
            GetStartedButton2.Font = new Font("Segoe UI", 9F);
            GetStartedButton2.ForeColor = Color.White;
            GetStartedButton2.Location = new Point(118, 485);
            GetStartedButton2.Name = "GetStartedButton2";
            GetStartedButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GetStartedButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            GetStartedButton2.Size = new Size(124, 102);
            GetStartedButton2.TabIndex = 10;
            GetStartedButton2.Text = "Get Started";
            GetStartedButton2.Click += GetStartedButton2_Click;
            // 
            // SkillsSetUpFormOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 639);
            Controls.Add(panel1);
            Name = "SkillsSetUpFormOne";
            Text = "SkillsSetUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton GetStartedButton2;
    }
}