namespace FreelancePlatform.UI
{
    partial class SkillsSetUpFormTwo
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
            industrySelectBox = new ComboBox();
            skillsOneComboBox = new ComboBox();
            skillsTwoComboBox = new ComboBox();
            skillsThreeComboBox = new ComboBox();
            SelectFieldComboBox = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // industrySelectBox
            // 
            industrySelectBox.FormattingEnabled = true;
            industrySelectBox.Items.AddRange(new object[] { "Accounting & Consulting", "Admin Support", "Customer Service", "Data Science & Analytics", "Design & Creative ", "Engineering & Architecture", "IT & Networking", "Share & Marketing" });
            industrySelectBox.Location = new Point(214, 61);
            industrySelectBox.Name = "industrySelectBox";
            industrySelectBox.Size = new Size(151, 28);
            industrySelectBox.TabIndex = 0;
            industrySelectBox.SelectedIndexChanged += industrySelectBox_SelectedIndexChanged;
            // 
            // skillsOneComboBox
            // 
            skillsOneComboBox.FormattingEnabled = true;
            skillsOneComboBox.Location = new Point(214, 139);
            skillsOneComboBox.Name = "skillsOneComboBox";
            skillsOneComboBox.Size = new Size(151, 28);
            skillsOneComboBox.TabIndex = 1;
            // 
            // skillsTwoComboBox
            // 
            skillsTwoComboBox.FormattingEnabled = true;
            skillsTwoComboBox.Location = new Point(214, 216);
            skillsTwoComboBox.Name = "skillsTwoComboBox";
            skillsTwoComboBox.Size = new Size(151, 28);
            skillsTwoComboBox.TabIndex = 2;
            // 
            // skillsThreeComboBox
            // 
            skillsThreeComboBox.FormattingEnabled = true;
            skillsThreeComboBox.Location = new Point(214, 291);
            skillsThreeComboBox.Name = "skillsThreeComboBox";
            skillsThreeComboBox.Size = new Size(151, 28);
            skillsThreeComboBox.TabIndex = 3;
            // 
            // SelectFieldComboBox
            // 
            SelectFieldComboBox.AutoSize = true;
            SelectFieldComboBox.Location = new Point(17, 61);
            SelectFieldComboBox.Name = "SelectFieldComboBox";
            SelectFieldComboBox.Size = new Size(138, 20);
            SelectFieldComboBox.TabIndex = 4;
            SelectFieldComboBox.Text = "Select your industry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 147);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "SkillsOne";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 224);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "SkillsTwo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 294);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "SkillsThree";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectFieldComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(industrySelectBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(skillsOneComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(skillsTwoComboBox);
            panel1.Controls.Add(skillsThreeComboBox);
            panel1.Location = new Point(30, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 623);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 64);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 8;
            label1.Text = "Your Role";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(615, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 31);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(615, 136);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 31);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 142);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Your Role";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(615, 224);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 31);
            textBox3.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 230);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 12;
            label6.Text = "Your Role";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(615, 308);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 31);
            textBox4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 314);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 14;
            label7.Text = "Your Role";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 388);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(174, 31);
            textBox5.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 394);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 16;
            label8.Text = "Your Role";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(615, 388);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(174, 31);
            textBox6.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 394);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 18;
            label9.Text = "Your Role";
            // 
            // SkillsSetUpFormTwo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 695);
            Controls.Add(panel1);
            Name = "SkillsSetUpFormTwo";
            Text = "SkillsSetUpFormTwo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox industrySelectBox;
        private ComboBox skillsOneComboBox;
        private ComboBox skillsTwoComboBox;
        private ComboBox skillsThreeComboBox;
        private Label SelectFieldComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
    }
}