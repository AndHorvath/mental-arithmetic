using Accessibility;
using MentalArithmetic.Helpers;
using MentalArithmetic.ResultModel;
using MentalArithmetic.ProblemModel;
using System;
using System.CodeDom;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MentalArithmetic
{
    public partial class Game : Form
    {
        // --- fields ---------------------------------------------------------

        private readonly XmlSerializer mSerializer;
        private readonly int mTimerTicksPerSecond;
        private readonly List<ISolvable> mProblemsConsidered;

        private int mProblemEntryTop;
        private int mProblemId;
        private int mTimerTick;
        private bool mIsNewProblem;

        private Problem mProblem;
        private Result mResult;
        private Register mRegister;

        // --- properties -----------------------------------------------------

        public XmlSerializer Serializer => mSerializer;
        public int TimerTicksPerSecond => mTimerTicksPerSecond;
        public List<ISolvable> ProblemsConsidered => mProblemsConsidered;

        public int ProblemEntryTop { get => mProblemEntryTop; set => mProblemEntryTop = value; }
        public int ProblemId { get => mProblemId; set => mProblemId = value; }
        public int TimerTick { get => mTimerTick; set => mTimerTick = value; }
        public bool IsNewProblem { get => mIsNewProblem; set => mIsNewProblem = value; }

        public Problem Problem { get => mProblem; set => mProblem = value; }
        public Result Result { get => mResult; set => mResult = value; }
        public Register Register { get => mRegister; set => mRegister = value; }

        // --- constructors ---------------------------------------------------

        public Game()
        {
            InitializeComponent();

            mSerializer = new XmlSerializer(typeof(Register));
            mProblemsConsidered = new List<ISolvable>();
            mRegister = new Register();

            mTimerTicksPerSecond = GameHelper.TimerIntervalUnitsPerSecond / timer.Interval;
        }

        // --- start, stop, tick, attempt, skip -------------------------------

        private void Start_Click(object pSender, EventArgs pEventArgs)
        {
            SetControlsForStart(pSender);
            SetFieldsForStart(pSender);

            SetUpNewProblem();
        }

        private void Stop_Click(object pSender, EventArgs pEventArgs)
        {
            RegisterSolution();
            ClearActualProblemControls(pEventArgs);

            SetControlsForResult();
            CreateTotalResult();
        }

        private void Timer_Tick(object pSender, EventArgs pEventArgs)
        {
            if (IsNewProblemToSet())
            {
                SetUpNewProblem();
            }
            else if (IsTimeout())
            {
                RegisterSolution();
                ClearActualProblemControls(pEventArgs);
            }
            else if (IsGameOver())
            {
                SetControlsForResult();
                CreateTotalResult();
            }
            UpdateRemainingTime();
        }

        private void Attempt_KeyPress(object pSender, KeyPressEventArgs pEventArgs)
        {
            if (!IsValidAttempt(pEventArgs, out double attemptValue))
            {
                return;
            }
            RegisterSolution(attemptValue);
            ClearActualProblemControls(pEventArgs);
        }

        private void Skip_Click(object pSender, EventArgs pEventArgs)
        {
            RegisterSolution();
            ClearActualProblemControls(pEventArgs);
        }

        // --- load, save -----------------------------------------------------

        private void LoadResults_Click(object pSender, EventArgs pEventArgs)
        {
            if (openRegisterFileDialog.ShowDialog() == DialogResult.OK)
            {
                using StreamReader streamReader = new(openRegisterFileDialog.FileName);
                mRegister = (Register)mSerializer.Deserialize(streamReader);
            }
        }

        private void SaveResults_Click(object pSender, EventArgs pEventArgs)
        {
            if (saveRegisterFileDialog.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter streamWriter = new(saveRegisterFileDialog.FileName);
                mSerializer.Serialize(streamWriter, mRegister);
            }
        }

        // --- results, ranking, rules ----------------------------------------

        private void ShowResults_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Show(new Results(mRegister));
        }

        private void Ranking_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Show(new Ranking(mRegister));
        }

        private void Rules_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Show(new Rules());
        }

        // --- add, cancel, submit --------------------------------------------

        private void AddToResults_Click(object pSender, EventArgs pEventArgs)
        {
            if (IsResult())
            {
                DisplayHelper.Hide(resultArea);
                DisplayHelper.Show(playerArea, playersName);
            }
        }

        private void Cancel_Click(object pSender, EventArgs pEventArgs)
        {
            SetControlsForStart(pSender);
            SetFieldsForStart(pSender);
        }

        private void Submit_Click(object pSender, EventArgs pEventArgs)
        {
            if (string.IsNullOrEmpty(playersName.Text))
            {
                MessageBox.Show(DisplayHelper.InvalidEntryMessageSubmit);
                return;
            }
            RegisterCompleteResult();

            SetControlsForStart(pSender);
            SetFieldsForStart(pSender);
        }

        // --- common private methods -----------------------------------------

        private void SetUpNewProblem()
        {
            mIsNewProblem = false;

            mProblem = GameHelper.CreateRandomProblem();
            actualProblem.Text = mProblem.ToStringExtended();
            attempt.Focus();
        }

        private void RegisterSolution(double pAttemptValue)
        {
            double timeUsed = mTimerTick / (double)mTimerTicksPerSecond;
            ISolvable solution = Double.IsNaN(pAttemptValue) ?
                new IgnoredProblem(mProblemId, mProblem, timeUsed) :
                new SolvedProblem(mProblemId, mProblem, pAttemptValue, timeUsed);

            DisplayHelper.CreateProblemEntry(solution, ref mProblemEntryTop, allProblemsArea.Controls);
            mProblemsConsidered.Add(solution);

            mProblemId++;
            mIsNewProblem = true;
            mTimerTick = 0;
        }

        private void RegisterSolution()
        {
            if (IsGameOver() || mProblem == null)
            {
                return;
            }
            RegisterSolution(double.NaN);
        }

        private void RegisterCompleteResult()
        {
            string name = playersName.Text;
            DateTime dateTime = DateTime.Now;
            PlayersResult playersResult = new(name, mResult);

            CompleteResult completeResult = new(playersResult, dateTime);
            mRegister.AddCompleteResult(completeResult);
        }

        private void CreateTotalResult()
        {
            timer.Stop();
            int totalScore = 0;
            double totalTime = 0d;

            if (mProblemsConsidered.Count == 0)
            {
                return;
            }
            foreach (ISolvable problem in mProblemsConsidered)
            {
                totalScore += problem.Score;
                totalTime += problem.TimeUsed;
            }
            mProblemsConsidered.Clear();
            mResult = new Result(totalScore, totalTime);
            DisplayHelper.CreateProblemsTotalEntry(mResult, allProblemsArea.Controls);
        }

        private void UpdateRemainingTime()
        {
            mTimerTick++;
            timeRemaining.Text = timer.Enabled ?
                GameHelper.GetRemainingTimeText(mProblem, mTimerTicksPerSecond, mTimerTick) :
                string.Empty;
        }

        private void ClearActualProblemControls(EventArgs pEventArgs)
        {
            if (pEventArgs.GetType() == typeof(KeyPressEventArgs))
            {
                ((KeyPressEventArgs)pEventArgs).Handled = true;
            }
            attempt.Clear();
            actualProblem.Text = string.Empty;
            timeRemaining.Text = string.Empty;
        }

        private void SetControlsForStart(object pSender)
        {
            actualProblem.Text = string.Empty;
            timeRemaining.Text = string.Empty;
            attempt.Clear();
            allProblemsArea.Controls.Clear();

            DisplayHelper.Hide(playerArea);
            DisplayHelper.Show(resultArea);

            if (pSender == start)
            {
                DisplayHelper.SetEnabled(
                    new Control[] { actualArea, loadResults, saveResults },
                    new bool[] { true, false, false });
            }
            DisplayHelper.SetEnabled(new Control[] { resultArea }, new bool[] { false });
        }

        private void SetFieldsForStart(object pSender)
        {
            if (pSender == start)
            {
                mResult = null;
                mProblemEntryTop = DisplayHelper.ProblemEntryTop;
                mProblemId = 1;

                mTimerTick = 0;
                timer.Start();
            }
            mProblemsConsidered.Clear();
            playersName.Clear();
        }

        private void SetControlsForResult()
        {
            if (mProblemsConsidered.Count == 0)
            {
                return;
            }
            DisplayHelper.SetEnabled(
                new Control[] { actualArea, resultArea, loadResults, saveResults },
                new bool[] { false, true, true, true });
        }

        private bool IsValidAttempt(KeyPressEventArgs pEventArgs, out double pAttemptValue)
        {
            pAttemptValue = double.NaN;
            return
                pEventArgs.KeyChar == (char)Keys.Enter &&
                double.TryParse(attempt.Text, out pAttemptValue) &&
                mProblemId <= GameHelper.NumberOfProblems;
        }

        private bool IsNewProblemToSet()
        {
            return mProblemId <= GameHelper.NumberOfProblems && mIsNewProblem;
        }

        private bool IsTimeout()
        {
            return
                mProblemId <= GameHelper.NumberOfProblems &&
                mTimerTick == mProblem.TimeAvailable * mTimerTicksPerSecond;
        }

        private bool IsGameOver()
        {
            return
                mProblemId > GameHelper.NumberOfProblems ||
                mResult != null;
        }

        private bool IsResult()
        {
            return mResult != null;
        }
    }
}