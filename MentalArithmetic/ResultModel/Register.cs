using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.ResultModel
{
    public class Register
    {
        // --- fields ---------------------------------------------------------

        private List<CompleteResult> mCompleteResults;

        // --- properties -----------------------------------------------------

        public List<CompleteResult> CompleteResults { get => mCompleteResults; set => mCompleteResults = value; }

        // --- constructors ---------------------------------------------------

        public Register()
        {
            mCompleteResults = new List<CompleteResult>();
        }

        public Register(Register pRegister)
        {
            mCompleteResults = new List<CompleteResult>(pRegister.CompleteResults);
        }

        // --- public methods -------------------------------------------------

        public void AddCompleteResult(CompleteResult pCompleteResult)
        {
            mCompleteResults.Add(pCompleteResult);
        }

        public void Order()
        {
            mCompleteResults.Sort((completeResult, other) => completeResult.CompareTo(other));
        }
    }
}