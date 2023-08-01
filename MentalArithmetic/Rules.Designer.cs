using MentalArithmetic.Helpers;

namespace MentalArithmetic
{
    partial class Rules
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
            back = new Button();
            explication = new Label();
            explicationArea = new Panel();
            explicationArea.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(691, 461);
            back.Name = "back";
            back.Size = new Size(200, 50);
            back.TabIndex = 0;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += Back_Click;
            // 
            // explication
            // 
            explication.AutoSize = true;
            explication.Location = new Point(12, 12);
            explication.MaximumSize = new Size(650, 0);
            explication.Name = "explication";
            explication.Size = new Size(27, 15);
            explication.TabIndex = 1;
            explication.Text = "Test";
            // 
            // explicationArea
            // 
            explicationArea.Controls.Add(explication);
            explicationArea.Location = new Point(12, 12);
            explicationArea.Name = "explicationArea";
            explicationArea.Size = new Size(673, 499);
            explicationArea.TabIndex = 2;
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 523);
            Controls.Add(explicationArea);
            Controls.Add(back);
            Name = "Rules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental Arithmetic - Rules";
            explicationArea.ResumeLayout(false);
            explicationArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Label explication;
        private Panel explicationArea;
    }
}