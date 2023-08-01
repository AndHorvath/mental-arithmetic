using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.ProblemModel
{
    public interface ISolvable
    {
        // --- properties -----------------------------------------------------

        public double TimeUsed { get; }
        public int Score { get; set; }

        // --- abstract methods -----------------------------------------------

        public double CalculateSolution();
        public int CalculateScore();
    }
}