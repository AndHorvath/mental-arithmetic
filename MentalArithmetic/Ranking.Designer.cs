using MentalArithmetic.Helpers;

namespace MentalArithmetic
{
    partial class Ranking
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
            rankingArea = new Panel();
            selectionArea = new Panel();
            to = new Label();
            toPosition = new NumericUpDown();
            fromPosition = new NumericUpDown();
            select = new Button();
            from = new Label();
            selectionArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromPosition).BeginInit();
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
            // rankingArea
            // 
            rankingArea.Location = new Point(12, 12);
            rankingArea.Name = "rankingArea";
            rankingArea.Size = new Size(428, 499);
            rankingArea.TabIndex = 2;
            // 
            // selectionArea
            // 
            selectionArea.Controls.Add(to);
            selectionArea.Controls.Add(toPosition);
            selectionArea.Controls.Add(fromPosition);
            selectionArea.Controls.Add(select);
            selectionArea.Controls.Add(from);
            selectionArea.Location = new Point(484, 12);
            selectionArea.Name = "selectionArea";
            selectionArea.Size = new Size(407, 50);
            selectionArea.TabIndex = 20;
            // 
            // to
            // 
            to.AutoSize = true;
            to.Location = new Point(3, 27);
            to.Name = "to";
            to.Size = new Size(65, 15);
            to.TabIndex = 25;
            to.Text = "To position";
            // 
            // toPosition
            // 
            toPosition.Location = new Point(103, 25);
            toPosition.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            toPosition.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            toPosition.Name = "toPosition";
            toPosition.Size = new Size(98, 23);
            toPosition.TabIndex = 23;
            toPosition.ValueChanged += ToPosition_ValueChanged;
            // 
            // fromPosition
            // 
            fromPosition.Location = new Point(103, 2);
            fromPosition.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            fromPosition.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            fromPosition.Name = "fromPosition";
            fromPosition.Size = new Size(98, 23);
            fromPosition.TabIndex = 21;
            fromPosition.ValueChanged += FromPosition_ValueChanged;
            // 
            // select
            // 
            select.Location = new Point(207, 0);
            select.Name = "select";
            select.Size = new Size(200, 50);
            select.TabIndex = 24;
            select.Text = "Select rankings";
            select.UseVisualStyleBackColor = true;
            select.Click += Select_Click;
            // 
            // from
            // 
            from.AutoSize = true;
            from.Location = new Point(3, 4);
            from.Name = "from";
            from.Size = new Size(81, 15);
            from.TabIndex = 19;
            from.Text = "From position";
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 523);
            Controls.Add(selectionArea);
            Controls.Add(rankingArea);
            Controls.Add(back);
            Name = "Ranking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental Arithmetic - Ranking";
            selectionArea.ResumeLayout(false);
            selectionArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromPosition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel rankingArea;
        private Panel selectionArea;
        private Button select;
        private Label from;
        private NumericUpDown fromPosition;
        private NumericUpDown toPosition;
        private Label to;
    }
}