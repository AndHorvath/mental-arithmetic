using MentalArithmetic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.ResultModel
{
    public class RankedResult : CompleteResult
    {
        // --- fields ---------------------------------------------------------

        private int mRank;

        // --- properties -----------------------------------------------------

        public int Rank { get => mRank; set => mRank = value; }

        // --- constructors ---------------------------------------------------

        public RankedResult(CompleteResult pCompleteResult, int pRank) : base(pCompleteResult, pCompleteResult.DateTime)
        {
            mRank = pRank;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            string separator = DisplayHelper.Separator;
            return $"{mRank}." + separator + base.ToString();
        }
    }
}