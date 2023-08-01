using MentalArithmetic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.ResultModel
{
    public class CompleteResult : PlayersResult, IComparable<CompleteResult>
    {
        // --- fields ---------------------------------------------------------

        private DateTime mDateTime;

        // --- properties -----------------------------------------------------

        public DateTime DateTime { get => mDateTime; set => mDateTime = value; }

        // --- constructors ---------------------------------------------------

        public CompleteResult() { }

        public CompleteResult(PlayersResult pPlayersResult, DateTime pDateTime) : base(pPlayersResult.Name, pPlayersResult)
        {
            mDateTime = pDateTime;
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            string separator = DisplayHelper.Separator;
            return base.ToString() + separator + mDateTime.ToShortDateString();
        }

        public int CompareTo(CompleteResult pOther)
        {
            if (mTotalScore < pOther.TotalScore ||
                mTotalScore == pOther.TotalScore && MathHelper.IsDoubleGreater(mTotalTime, pOther.TotalTime))
            {
                return 1;
            }
            else if (mTotalScore > pOther.TotalScore ||
                mTotalScore == pOther.TotalScore && MathHelper.IsDoubleLess(mTotalTime, pOther.TotalTime))
            {
                return -1;
            }
            return 0;
        }
    }
}