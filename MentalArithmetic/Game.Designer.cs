using MentalArithmetic.Helpers;

namespace MentalArithmetic
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            start = new Button();
            stop = new Button();
            rules = new Button();
            loadResults = new Button();
            saveResults = new Button();
            showResults = new Button();
            ranking = new Button();
            problemsArea = new Panel();
            allProblemsArea = new Panel();
            actualArea = new Panel();
            skip = new Button();
            time = new Label();
            timeRemaining = new Label();
            attempt = new TextBox();
            actualProblem = new Label();
            playerArea = new Panel();
            submit = new Button();
            playersName = new TextBox();
            name = new Label();
            resultArea = new Panel();
            cancel = new Button();
            addToResults = new Button();
            timer = new System.Windows.Forms.Timer(components);
            saveRegisterFileDialog = new SaveFileDialog();
            openRegisterFileDialog = new OpenFileDialog();
            problemsArea.SuspendLayout();
            actualArea.SuspendLayout();
            playerArea.SuspendLayout();
            resultArea.SuspendLayout();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(12, 12);
            start.Name = "start";
            start.Size = new Size(200, 50);
            start.TabIndex = 0;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += Start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(12, 68);
            stop.Name = "stop";
            stop.Size = new Size(200, 50);
            stop.TabIndex = 1;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += Stop_Click;
            // 
            // rules
            // 
            rules.Location = new Point(12, 124);
            rules.Name = "rules";
            rules.Size = new Size(200, 50);
            rules.TabIndex = 2;
            rules.Text = "Rules";
            rules.UseVisualStyleBackColor = true;
            rules.Click += Rules_Click;
            // 
            // loadResults
            // 
            loadResults.Location = new Point(12, 236);
            loadResults.Name = "loadResults";
            loadResults.Size = new Size(200, 50);
            loadResults.TabIndex = 3;
            loadResults.Text = "Load results";
            loadResults.UseVisualStyleBackColor = true;
            loadResults.Click += LoadResults_Click;
            // 
            // saveResults
            // 
            saveResults.Location = new Point(12, 292);
            saveResults.Name = "saveResults";
            saveResults.Size = new Size(200, 50);
            saveResults.TabIndex = 4;
            saveResults.Text = "Save results";
            saveResults.UseVisualStyleBackColor = true;
            saveResults.Click += SaveResults_Click;
            // 
            // showResults
            // 
            showResults.Location = new Point(12, 348);
            showResults.Name = "showResults";
            showResults.Size = new Size(200, 50);
            showResults.TabIndex = 5;
            showResults.Text = "Show results";
            showResults.UseVisualStyleBackColor = true;
            showResults.Click += ShowResults_Click;
            // 
            // ranking
            // 
            ranking.Location = new Point(12, 460);
            ranking.Name = "ranking";
            ranking.Size = new Size(200, 50);
            ranking.TabIndex = 6;
            ranking.Text = "Ranking";
            ranking.UseVisualStyleBackColor = true;
            ranking.Click += Ranking_Click;
            // 
            // problemsArea
            // 
            problemsArea.Controls.Add(allProblemsArea);
            problemsArea.Controls.Add(actualArea);
            problemsArea.Controls.Add(playerArea);
            problemsArea.Location = new Point(274, 12);
            problemsArea.Name = "problemsArea";
            problemsArea.Size = new Size(613, 498);
            problemsArea.TabIndex = 7;
            // 
            // allProblemsArea
            // 
            allProblemsArea.Location = new Point(0, 112);
            allProblemsArea.Name = "allProblemsArea";
            allProblemsArea.Size = new Size(613, 274);
            allProblemsArea.TabIndex = 14;
            // 
            // actualArea
            // 
            actualArea.Controls.Add(skip);
            actualArea.Controls.Add(time);
            actualArea.Controls.Add(timeRemaining);
            actualArea.Controls.Add(attempt);
            actualArea.Controls.Add(actualProblem);
            actualArea.Enabled = false;
            actualArea.Location = new Point(0, 0);
            actualArea.Name = "actualArea";
            actualArea.Size = new Size(613, 50);
            actualArea.TabIndex = 8;
            // 
            // skip
            // 
            skip.Location = new Point(309, 14);
            skip.Name = "skip";
            skip.Size = new Size(97, 23);
            skip.TabIndex = 11;
            skip.Text = "Skip";
            skip.UseVisualStyleBackColor = true;
            skip.Click += Skip_Click;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(478, 18);
            time.Name = "time";
            time.Size = new Size(93, 15);
            time.TabIndex = 12;
            time.Text = "Time remaining:";
            // 
            // timeRemaining
            // 
            timeRemaining.AutoSize = true;
            timeRemaining.Location = new Point(577, 18);
            timeRemaining.Name = "timeRemaining";
            timeRemaining.Size = new Size(0, 15);
            timeRemaining.TabIndex = 13;
            timeRemaining.TextAlign = ContentAlignment.TopRight;
            // 
            // attempt
            // 
            attempt.Location = new Point(206, 14);
            attempt.Name = "attempt";
            attempt.Size = new Size(97, 23);
            attempt.TabIndex = 10;
            attempt.KeyPress += Attempt_KeyPress;
            // 
            // actualProblem
            // 
            actualProblem.AutoSize = true;
            actualProblem.Location = new Point(3, 18);
            actualProblem.Name = "actualProblem";
            actualProblem.Size = new Size(0, 15);
            actualProblem.TabIndex = 9;
            // 
            // playerArea
            // 
            playerArea.Controls.Add(submit);
            playerArea.Controls.Add(playersName);
            playerArea.Controls.Add(name);
            playerArea.Location = new Point(206, 448);
            playerArea.Name = "playerArea";
            playerArea.Size = new Size(407, 50);
            playerArea.TabIndex = 18;
            playerArea.Visible = false;
            // 
            // submit
            // 
            submit.Location = new Point(207, 0);
            submit.Name = "submit";
            submit.Size = new Size(200, 50);
            submit.TabIndex = 21;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += Submit_Click;
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
            name.Size = new Size(80, 15);
            name.TabIndex = 19;
            name.Text = "Player's name";
            // 
            // resultArea
            // 
            resultArea.Controls.Add(cancel);
            resultArea.Controls.Add(addToResults);
            resultArea.Enabled = false;
            resultArea.Location = new Point(274, 460);
            resultArea.Name = "resultArea";
            resultArea.Size = new Size(613, 50);
            resultArea.TabIndex = 15;
            // 
            // cancel
            // 
            cancel.Location = new Point(413, 0);
            cancel.Name = "cancel";
            cancel.Size = new Size(200, 50);
            cancel.TabIndex = 17;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += Cancel_Click;
            // 
            // addToResults
            // 
            addToResults.Location = new Point(0, 0);
            addToResults.Name = "addToResults";
            addToResults.Size = new Size(200, 50);
            addToResults.TabIndex = 16;
            addToResults.Text = "Add to results";
            addToResults.UseVisualStyleBackColor = true;
            addToResults.Click += AddToResults_Click;
            // 
            // timer
            // 
            timer.Tick += Timer_Tick;
            // 
            // saveRegisterFileDialog
            // 
            saveRegisterFileDialog.FileName = "mentalarithmetic";
            saveRegisterFileDialog.Filter = "XML files | *.xml";
            // 
            // openRegisterFileDialog
            // 
            openRegisterFileDialog.FileName = "mentalarithmetic";
            openRegisterFileDialog.Filter = "XML files | *.xml";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 523);
            Controls.Add(resultArea);
            Controls.Add(problemsArea);
            Controls.Add(ranking);
            Controls.Add(saveResults);
            Controls.Add(showResults);
            Controls.Add(loadResults);
            Controls.Add(rules);
            Controls.Add(stop);
            Controls.Add(start);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental Arithmetic - Game";
            problemsArea.ResumeLayout(false);
            actualArea.ResumeLayout(false);
            actualArea.PerformLayout();
            playerArea.ResumeLayout(false);
            playerArea.PerformLayout();
            resultArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private Button stop;
        private Button rules;
        private Button loadResults;
        private Button saveResults;
        private Button showResults;
        private Button ranking;
        private Panel problemsArea;
        private Button addToResults;
        private Button cancel;
        private Button submit;
        private Panel playerArea;
        private Label name;
        private TextBox playersName;
        private Panel actualArea;
        private Label actualProblem;
        private TextBox attempt;
        private Label time;
        private Label timeRemaining;
        private Panel allProblemsArea;
        private System.Windows.Forms.Timer timer;
        private Button skip;
        private Panel resultArea;
        private SaveFileDialog saveRegisterFileDialog;
        private OpenFileDialog openRegisterFileDialog;
    }
}