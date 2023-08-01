using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalArithmetic.Helpers;

namespace MentalArithmetic.ProblemModel
{
    public class SolvedProblem : Problem, ISolvable
    {
        // --- fields ---------------------------------------------------------

        private readonly int mId;
        private readonly double mAttempt;
        private readonly double mTimeUsed;

        private double mSolution;
        private bool mIsSuccess;
        private int mScore;

        // --- properties -----------------------------------------------------

        public int Id => mId;
        public double Attempt => mAttempt;
        public double TimeUsed => mTimeUsed;

        public double Solution { get => mSolution; set => mSolution = value; }
        public bool IsSuccess { get => mIsSuccess; set => mIsSuccess = value; }
        public int Score { get => mScore; set => mScore = value; }

        // --- constructors ---------------------------------------------------

        public SolvedProblem(int pId, Problem pProblem, double pAttempt, double pTimeUsed) :
            base(pProblem.FirstValue, pProblem.SecondValue, pProblem.Operation)
        {
            mId = pId;
            mAttempt = pAttempt;
            mTimeUsed = pTimeUsed;

            Initialize();
        }

        // --- public methods -------------------------------------------------

        public double CalculateSolution()
        {
            switch (mOperation)
            {
                case Operation.Addition:
                    return mFirstValue + mSecondValue;
                case Operation.Subtraction:
                    return mFirstValue - mSecondValue;
                case Operation.Multiplication:
                    return mFirstValue * mSecondValue;
                case Operation.Division:
                    double quotient = mFirstValue / (double)mSecondValue;
                    return Math.Round(quotient, 2);
            }
            return double.NaN;
        }

        public int CalculateScore()
        {
            if (mIsSuccess)
            {
                int scoreBase = mFirstValue.ToString().Length + mSecondValue.ToString().Length;

                switch (mOperation)
                {
                    case Operation.Addition:
                    case Operation.Subtraction:
                        return scoreBase;
                    case Operation.Multiplication:
                        return scoreBase * GameHelper.EvaluationFactorMultiplication;
                    case Operation.Division:
                        return scoreBase * GameHelper.EvaluationFactorDivision;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            string id = $"{mId})";
            string problem = base.ToString();
            string attempt = mAttempt.ToString();
            string isCorrect = mIsSuccess ? "correct" : $"not correct ({mSolution})";
            string score = $"{mScore} points";
            string time = $"{GetDisplayedTime(mTimeUsed)} sec.";

            string space = " ";
            string separator = DisplayHelper.Separator;

            return
                id + separator +
                problem + space + attempt + separator +
                isCorrect + separator + score + separator + time;
        }

        // --- private methods ------------------------------------------------

        private void Initialize()
        {
            mSolution = CalculateSolution();
            mIsSuccess = MathHelper.IsDoubleEqual(mAttempt, mSolution);
            mScore = CalculateScore();
        }
    }
}