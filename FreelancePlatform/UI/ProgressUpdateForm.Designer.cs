namespace FreelancePlatform.UI
{
    partial class ProgressUpdateForm
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
            chkMarkAsDone = new Guna.UI2.WinForms.Guna2CheckBox();
            SubmitProgressButton = new Button();
            SuspendLayout();
            // 
            // chkMarkAsDone
            // 
            chkMarkAsDone.AutoSize = true;
            chkMarkAsDone.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkMarkAsDone.CheckedState.BorderRadius = 0;
            chkMarkAsDone.CheckedState.BorderThickness = 0;
            chkMarkAsDone.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkMarkAsDone.Location = new Point(215, 98);
            chkMarkAsDone.Name = "chkMarkAsDone";
            chkMarkAsDone.Size = new Size(67, 24);
            chkMarkAsDone.TabIndex = 0;
            chkMarkAsDone.Text = "Done";
            chkMarkAsDone.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkMarkAsDone.UncheckedState.BorderRadius = 0;
            chkMarkAsDone.UncheckedState.BorderThickness = 0;
            chkMarkAsDone.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // SubmitProgressButton
            // 
            SubmitProgressButton.Location = new Point(236, 217);
            SubmitProgressButton.Name = "SubmitProgressButton";
            SubmitProgressButton.Size = new Size(102, 43);
            SubmitProgressButton.TabIndex = 1;
            SubmitProgressButton.Text = "Submit";
            SubmitProgressButton.UseVisualStyleBackColor = true;
            SubmitProgressButton.Click += SubmitProgressButton_Click;
            // 
            // ProgressUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitProgressButton);
            Controls.Add(chkMarkAsDone);
            Name = "ProgressUpdateForm";
            Text = "ProgressUpdateForm";
            Load += ProgressUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox chkMarkAsDone;
        private Button SubmitProgressButton;
    }
}