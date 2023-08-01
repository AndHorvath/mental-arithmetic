using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalArithmetic.Base;
using MentalArithmetic.Helpers;

namespace MentalArithmetic.ResultModel
{
    public class PlayersResult : Result
    {
        // --- fields ---------------------------------------------------------

        protected string mName;

        // --- properties -----------------------------------------------------

        public string Name { get => mName; set => mName = value; }

        // --- constructors ---------------------------------------------------

        public PlayersResult() { }

        public PlayersResult(string pName, Result pResult) : base(pResult.TotalScore, pResult.TotalTime)
        {
            mName = pName;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            string separator = DisplayHelper.Separator;
            return $"{mName}" + separator + $"{mTotalScore} points" + separator + $"{GetDisplayedTime(mTotalTime)} sec.";
        }
    }
}