using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class AddSolutionForm : Form
    {
        public AddSolutionForm()
        {
            InitializeComponent();
        }

        public string SolutionName => NameTextBox.Text.Trim();
        public decimal SolutionVolume => VolumeNumeric.Value;


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim() == string.Empty)
            {
                NameTextBox.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
