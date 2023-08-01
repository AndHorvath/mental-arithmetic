using MentalArithmetic.Helpers;
using MentalArithmetic.ResultModel;
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
    public partial class Ranking : Form
    {
        // --- fields ---------------------------------------------------------

        private Register mOrderedRegister;
        private List<RankedResult> mRankedResults;

        // --- properties -----------------------------------------------------

        public Register OrderedRegister { get => mOrderedRegister; set => mOrderedRegister = value; }
        public List<RankedResult> RankedResults { get => mRankedResults; set => mRankedResults = value; }

        // --- constructors ---------------------------------------------------

        public Ranking(Register pRegister)
        {
            InitializeComponent();
            Initialize(pRegister);

            GetRankedResultsSelection();
            CreateRankingEntries();
        }

        // --- select, from, to -----------------------------------------------

        private void Select_Click(object pSender, EventArgs pEventsArgs)
        {
            ClearControls();

            GetRankedResultsSelection();
            CreateRankingEntries();
        }

        private void FromPosition_ValueChanged(object pSender, EventArgs pEventArgs)
        {
            toPosition.Value = Math.Max(toPosition.Value, fromPosition.Value);
        }

        private void ToPosition_ValueChanged(object pSender, EventArgs pEventArgs)
        {
            fromPosition.Value = Math.Min(fromPosition.Value, toPosition.Value);
        }


        // --- back -----------------------------------------------------------

        private void Back_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Back(this);
        }

        // --- common private methods -----------------------------------------

        private void Initialize(Register pRegister)
        {
            mOrderedRegister = new(pRegister);
            mOrderedRegister.Order();

            fromPosition.Minimum = Math.Min(1, mOrderedRegister.CompleteResults.Count);
            fromPosition.Maximum = mOrderedRegister.CompleteResults.Count;
            fromPosition.Value = fromPosition.Minimum;

            toPosition.Minimum = fromPosition.Minimum;
            toPosition.Maximum = fromPosition.Maximum;
            toPosition.Value = Math.Min(toPosition.Maximum, DisplayHelper.DefaultRankingLimit);

            mRankedResults = new List<RankedResult>();
        }

        private void GetRankedResultsSelection()
        {
            int fromIndex = (int)fromPosition.Value - 1;
            int toIndex = (int)toPosition.Value - 1;

            mRankedResults.Clear();
            mOrderedRegister.CompleteResults
                .Where(completeResult => mOrderedRegister.CompleteResults.IndexOf(completeResult) >= fromIndex).ToList()
                .Where(completeResult => mOrderedRegister.CompleteResults.IndexOf(completeResult) <= toIndex).ToList()
                .ForEach(completeResult => mRankedResults.Add(CreateRankedResult(completeResult)));
        }

        private RankedResult CreateRankedResult(CompleteResult pCompleteResult)
        {
            return new RankedResult(pCompleteResult, GetRanking(pCompleteResult));
        }

        private int GetRanking(CompleteResult pCompleteResult)
        {
            return mOrderedRegister.CompleteResults.IndexOf(pCompleteResult) + 1;
        }

        private void CreateRankingEntries()
        {
            DisplayHelper.CreateResultEntries(mRankedResults, rankingArea.Controls);
        }

        private void ClearControls()
        {
            rankingArea.Controls.Clear();
        }
    }
}