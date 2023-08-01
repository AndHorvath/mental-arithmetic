using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MentalArithmetic.Base;
using MentalArithmetic.Helpers;

namespace MentalArithmetic.ResultModel
{
    public class Result : TimeDisplayer
    {
        // --- fields ---------------------------------------------------------

        protected int mTotalScore;
        protected double mTotalTime;

        // --- properties -----------------------------------------------------

        public int TotalScore { get => mTotalScore; set => mTotalScore = value; }
        public double TotalTime { get => mTotalTime; set => mTotalTime = value; }

        // --- constructors ---------------------------------------------------

        public Result() { }

        public Result(int pTotalScore, double pTotalTime)
        {
            mTotalScore = pTotalScore;
            mTotalTime = pTotalTime;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            string separator = DisplayHelper.Separator;
            return $"Total score: {mTotalScore} points" + separator + $"Total time: {GetDisplayedTime(mTotalTime)} sec.";
        }
    }
}