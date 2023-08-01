using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalArithmetic.Helpers;

namespace MentalArithmetic.ProblemModel
{
    public class IgnoredProblem : Problem, ISolvable
    {
        // --- fields ---------------------------------------------------------

        private readonly int mId;
        private readonly double mTimeUsed;

        private int mScore;

        // --- properties -----------------------------------------------------

        public int Id => mId;
        public double TimeUsed => mTimeUsed;

        public int Score { get => mScore; set => mScore = value; }

        // --- constructors ---------------------------------------------------

        public IgnoredProblem(int pId, Problem pProblem, double pTimeUsed) :
            base(pProblem.FirstValue, pProblem.SecondValue, pProblem.Operation)
        {
            mId = pId;
            mTimeUsed = pTimeUsed;

            Initialize();
        }

        // --- public methods -------------------------------------------------

        public double CalculateSolution()
        {
            return double.NaN;
        }

        public int CalculateScore()
        {
            return 0;
        }

        public override string ToString()
        {
            string id = $"{mId})";
            string problem = base.ToString();
            string time = $"{GetDisplayedTime(mTimeUsed)} sec.";

            string space = " ";
            string separator = DisplayHelper.Separator;

            return
                id + separator +
                problem + space + "-" + separator +
                "skipped" + separator + "0 points" + separator + time;
        }

        // --- private methods ------------------------------------------------

        public void Initialize()
        {
            mScore = CalculateScore();
        }
    }
}