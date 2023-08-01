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
    public partial class Results : Form
    {
        // --- fields ---------------------------------------------------------

        private readonly Register mRegister;

        // --- properties -----------------------------------------------------

        public Register Register => mRegister;

        // --- constructors ---------------------------------------------------

        public Results(Register pRegister)
        {
            mRegister = pRegister;

            InitializeComponent();
            CreateResultEntries();
        }

        // --- search, clear --------------------------------------------------

        private void SearchPlayer_Click(object pSender, EventArgs pEventArgs)
        {
            if (string.IsNullOrEmpty(playersName.Text))
            {
                MessageBox.Show(DisplayHelper.InvalidEntryMessageSearch);
                return;
            }
            ClearControls(pSender);
            DisplayHelper.CreateResultEntries(mRegister.CompleteResults, resultArea.Controls, playersName.Text);
        }

        private void ClearFilter_Click(object pSender, EventArgs pEventArgs)
        {
            ClearControls(pSender);
            DisplayHelper.CreateResultEntries(mRegister.CompleteResults, resultArea.Controls);
        }

        // --- back -----------------------------------------------------------

        private void Back_Click(object pSender, EventArgs pEventArgs)
        {
            DisplayHelper.Back(this);
        }

        // --- common private methods -----------------------------------------

        private void CreateResultEntries()
        {
            DisplayHelper.CreateResultEntries(mRegister.CompleteResults, resultArea.Controls);
        }

        private void ClearControls(object pSender)
        {
            if (pSender == clearFilter)
            {
                playersName.Clear();
            }
            resultArea.Controls.Clear();
        }
    }
}