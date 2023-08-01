using MentalArithmetic.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalArithmetic
{
    public partial class Rules : Form
    {
        // --- constructors ---------------------------------------------------

        public Rules()
        {
            InitializeComponent();
            Initialize();
        }

        // --- back -----------------------------------------------------------

        private void Back_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Back(this);
        }

        // --- common private methods -----------------------------------------

        private void Initialize()
        {
            int numberOfProblemsToSolve = GameHelper.NumberOfProblems;

            int timeAvailablePerDigit = GameHelper.TimeAvailablePerDigit;
            int pointsAwardedPerDigit = GameHelper.PointsAwardedPerDigit;
            int evaluationFactorMultiplication = GameHelper.EvaluationFactorMultiplication;
            int evaluationFactorDivision = GameHelper.EvaluationFactorDivision;

            int timeAvailablePerDigitBase = timeAvailablePerDigit;
            int timeAvailablePerDigitMultiplication = timeAvailablePerDigit * evaluationFactorMultiplication;
            int timeAvailablePerDigitDivision = timeAvailablePerDigit * evaluationFactorDivision;

            int pointsAwardedPerDigitBase = pointsAwardedPerDigit;
            int pointsAwardedPerDigitMultiplication = pointsAwardedPerDigit * evaluationFactorMultiplication;
            int pointsAwardedPerDigitDivision = pointsAwardedPerDigit * evaluationFactorDivision;

            bool isPoints = pointsAwardedPerDigit > 1;
            string points = isPoints ? "points" : "point";
            string are = isPoints ? "are" : "is";

            string newParagraph = "\n\n";

            explication.Text =
                $"There are {numberOfProblemsToSolve} mental arithmetic problems to solve. " +
                $"Operands as well as operations vary randomly. " +
                $"The tasks contain maximum three digit numbers and maximum one three digit number." +
                newParagraph +
                $"In principle, {timeAvailablePerDigitBase} seconds per digit per number are available for the calculation per task, " +
                $"but for multiplications that are {timeAvailablePerDigitMultiplication} seconds " +
                $"and {timeAvailablePerDigitDivision} seconds for divisions." +
                newParagraph +
                $"For a correct solution, {pointsAwardedPerDigitBase} {points} per digit per number {are} awarded per task, in principle, " +
                $"but that are {pointsAwardedPerDigitMultiplication} points for multiplications " +
                $"and {pointsAwardedPerDigitDivision} points for divisions.";
        }
    }
}