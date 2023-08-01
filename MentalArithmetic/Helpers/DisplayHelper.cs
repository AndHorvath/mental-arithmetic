using MentalArithmetic.ResultModel;
using MentalArithmetic.ProblemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace MentalArithmetic.Helpers
{
    public static class DisplayHelper
    {
        // --- constants ------------------------------------------------------

        public const int ProblemEntryLeft = 206;
        public const int ProblemEntryTop = 18;

        public const int ProblemsTotalEntryLeft = ProblemEntryLeft;
        public const int ProblemsTotalEntryTop = 242;

        public const int ResultEntryLeft = 12;
        public const int ResultEntryTop = 12;

        public const int EntryTopStep = 20;

        public const int DefaultRankingLimit = 10;

        public const string Separator = "          ";
        public const string InvalidEntryMessageSubmit = "Enter player's name";
        public const string InvalidEntryMessageSearch = "Enter a name please or a part of a name";

        // --- public methods -------------------------------------------------

        public static void Show(Form pForm)
        {
            pForm.ShowDialog();
        }

        public static void Show(Panel pPanel)
        {
            pPanel.Show();
        }

        public static void Show(Panel pPanel, Control pControlToFocus)
        {
            Show(pPanel);
            pControlToFocus.Focus();
        }

        public static void Back(Form pForm)
        {
            pForm.Close();
        }

        public static void Hide(Panel pPanel)
        {
            pPanel.Hide();
        }

        public static void SetEnabled(Control[] pControls, bool[] pIsEnabledValues)
        {
            for (int i = 0; i < pControls.Length; i++)
            {
                pControls[i].Enabled = pIsEnabledValues[i];
            }
        }

        public static void CreateProblemEntry(ISolvable pProblemConsidered, ref int pProblemEntryTop, ControlCollection pControls)
        {
            Label problemEntry = new()
            {
                Left = ProblemEntryLeft,
                Top = pProblemEntryTop,
                AutoSize = true,
                Text = pProblemConsidered.ToString()
            };
            pControls.Add(problemEntry);
            pProblemEntryTop += EntryTopStep;
        }

        public static void CreateProblemsTotalEntry(Result pResult, ControlCollection pControls)
        {
            Label problemsTotalEntry = new()
            {
                Left = ProblemsTotalEntryLeft,
                Top = ProblemsTotalEntryTop,
                AutoSize = true,
                Text = pResult.ToString()
            };
            pControls.Add(problemsTotalEntry);
        }

        public static void CreateResultEntries<T>(List<T> pResults, ControlCollection pControls) where T : CompleteResult
        {
            CreateResultEntries(pResults, pControls, string.Empty);
        }

        public static void CreateResultEntries<T>(List<T> pResults, ControlCollection pControls, string pNameFilter) where T : CompleteResult
        {
            int resultEntryTop = ResultEntryTop;

            foreach (T completeResult in pResults)
            {
                if (completeResult.Name.ToLower().Contains(pNameFilter.ToLower()))
                {
                    Label resultEntry = new()
                    {
                        Left = ResultEntryLeft,
                        Top = resultEntryTop,
                        AutoSize = true,
                        Text = completeResult.ToString()
                    };
                    pControls.Add(resultEntry);
                    resultEntryTop += EntryTopStep;
                }
            }
        }
    }
}   