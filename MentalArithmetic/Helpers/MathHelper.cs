using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.Helpers
{
    public static class MathHelper
    {
        // --- constants ------------------------------------------------------

        public static readonly double EpsilonError = Math.Pow(10d, -5d);

        // --- public methods -------------------------------------------------

        public static bool IsDoubleEqual(double pFirstValue, double pSecondValue)
        {
            return Math.Abs(pFirstValue - pSecondValue) < EpsilonError;
        }

        public static bool IsDoubleGreater(double pFirstValue, double pSecondValue)
        {
            return pFirstValue - pSecondValue > EpsilonError;
        }

        public static bool IsDoubleLess(double pFirstValue, double pSecondValue)
        {
            return pSecondValue - pFirstValue > EpsilonError;
        }
    }
}