using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalArithmetic.Base;
using MentalArithmetic.Helpers;

namespace MentalArithmetic.ProblemModel
{
    public class Problem : TimeDisplayer
    {
        // --- fields ---------------------------------------------------------

        protected readonly int mFirstValue;
        protected readonly int mSecondValue;
        protected readonly Operation mOperation;

        protected int mTimeAvailable;

        // --- properties -----------------------------------------------------

        public int FirstValue => mFirstValue;
        public int SecondValue => mSecondValue;
        public Operation Operation => mOperation;

        public int TimeAvailable { get => mTimeAvailable; set => mTimeAvailable = value; }

        // --- constructors ---------------------------------------------------

        public Problem() { }

        public Problem(int pFirstValue, int pSecondValue, Operation pOperation)
        {
            mFirstValue = pFirstValue;
            mSecondValue = pSecondValue;
            mOperation = pOperation;

            Initialize();
        }

        // --- public methods -------------------------------------------------

        public override string ToString()
        {
            string firstValue = mFirstValue.ToString();
            string secondValue = mSecondValue.ToString();
            string operation = GetOperationSign();
            string space = " ";

            return firstValue + space + operation + space + secondValue + space + "=";
        }

        public string ToStringExtended()
        {
            string roundingExtension = GetRoundingExtension();
            return ToString() + " ?" + roundingExtension;
        }

        // --- private methods ------------------------------------------------

        private void Initialize()
        {
            mTimeAvailable = GameHelper.CalculateTimeAvailable(this);
        }

        private string GetOperationSign()
        {
            return mOperation switch
            {
                Operation.Addition => "+",
                Operation.Subtraction => "-",
                Operation.Multiplication => "*",
                Operation.Division => "/",
                _ => string.Empty
            };
        }

        private string GetRoundingExtension()
        {
            string space = " ";
            return mOperation == Operation.Division ? space + "(two decimals precision)" : string.Empty;
        }
    }
}