using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentalArithmetic.ResultModel;
using MentalArithmetic.ProblemModel;
using static System.Windows.Forms.Control;

namespace MentalArithmetic.Helpers
{
    public static class GameHelper
    {
        // --- constants ------------------------------------------------------

        public const int ValueLimit = 100;
        public const int ValueLimitFactor = 10;

        public const int TimeAvailablePerDigit = 5;
        public const int PointsAwardedPerDigit = 1;

        public const int EvaluationFactorMultiplication = 2;
        public const int EvaluationFactorDivision = 3;

        public const int NumberOfProblems = 10;

        public const int TimerIntervalUnitsPerSecond = 1000;

        public static readonly Random Random = new();

        // --- public methods -------------------------------------------------

        public static Problem CreateRandomProblem()
        {
            int firstValue;
            int secondValue;
            Operation operation;

            do
            {
                bool isFirstLimitToRaise = Random.Next(2) == 0;
                firstValue = Random.Next(ValueLimit * (isFirstLimitToRaise ? ValueLimitFactor : 1));
                secondValue = Random.Next(ValueLimit * (isFirstLimitToRaise ? 1 : ValueLimitFactor));

                Array operations = Enum.GetValues(typeof(Operation));
                int operationIndex = Random.Next(operations.Length);
                operation = (Operation)operations.GetValue(operationIndex);
            } while (operation == Operation.Division && secondValue == 0);

            return new Problem(firstValue, secondValue, operation);
        }

        public static int CalculateTimeAvailable(Problem pProblem)
        {
            int numberOfDigitsTotal = pProblem.FirstValue.ToString().Length + pProblem.SecondValue.ToString().Length;
            int baseTimeAvailable = numberOfDigitsTotal * TimeAvailablePerDigit;

            return pProblem.Operation switch
            {
                Operation.Addition or Operation.Subtraction => baseTimeAvailable,
                Operation.Multiplication => baseTimeAvailable * EvaluationFactorMultiplication,
                Operation.Division => baseTimeAvailable * EvaluationFactorDivision,
                _ => 0
            };
        }

        public static string GetRemainingTimeText(Problem pProblem, int pTimerTicksPerSecond, int pActualTimerTick)
        {
            int remainingTicks = pProblem.TimeAvailable * pTimerTicksPerSecond - pActualTimerTick;
            return (remainingTicks / (double)pTimerTicksPerSecond).ToString();
        }
    }
}