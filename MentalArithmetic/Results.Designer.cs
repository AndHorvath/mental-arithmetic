using MentalArithmetic.Helpers;

namespace MentalArithmetic
{
    partial class Results
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
            resultArea = new Panel();
            playerArea = new Panel();
            clearFilter = new Button();
            searchPlayer = new Button();
            playersName = new TextBox();
            name = new Label();
            playerArea.SuspendLayout();
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
            // resultArea
            // 
            resultArea.Location = new Point(12, 12);
            resultArea.Name = "resultArea";
            resultArea.Size = new Size(428, 499);
            resultArea.TabIndex = 1;
            // 
            // playerArea
            // 
            playerArea.Controls.Add(clearFilter);
            playerArea.Controls.Add(searchPlayer);
            playerArea.Controls.Add(playersName);
            playerArea.Controls.Add(name);
            playerArea.Location = new Point(484, 12);
            playerArea.Name = "playerArea";
            playerArea.Size = new Size(407, 106);
            playerArea.TabIndex = 19;
            // 
            // clearFilter
            // 
            clearFilter.Location = new Point(207, 56);
            clearFilter.Name = "clearFilter";
            clearFilter.Size = new Size(200, 50);
            clearFilter.TabIndex = 22;
            clearFilter.Text = "Clear filter";
            clearFilter.UseVisualStyleBackColor = true;
            clearFilter.Click += ClearFilter_Click;
            // 
            // searchPlayer
            // 
            searchPlayer.Location = new Point(207, 0);
            searchPlayer.Name = "searchPlayer";
            searchPlayer.Size = new Size(200, 50);
            searchPlayer.TabIndex = 21;
            searchPlayer.Text = "Search player";
            searchPlayer.UseVisualStyleBackColor = true;
            searchPlayer.Click += SearchPlayer_Click;
            // 
            // playersName
            // 
            playersName.Location = new Point(3, 24);
            playersName.Name = "playersName";
            playersName.Size = new Size(194, 23);
            playersName.TabIndex = 20;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(3, 6);
            name.Name = "name";
            name.Size = new Size(110, 15);
            name.TabIndex = 19;
            name.Text = "Name";
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 523);
            Controls.Add(playerArea);
            Controls.Add(resultArea);
            Controls.Add(back);
            Name = "Results";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental Arithmetic - Results";
            playerArea.ResumeLayout(false);
            playerArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button back;
        private Panel resultArea;
        private Panel playerArea;
        private Button searchPlayer;
        private TextBox playersName;
        private Label name;
        private Button clearFilter;
    }
}