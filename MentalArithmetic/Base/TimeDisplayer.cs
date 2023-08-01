using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.Base
{
    public abstract class TimeDisplayer
    {
        public virtual double GetDisplayedTime(double pTime)
        {
            return Math.Round(pTime, 1);
        }
    }
}