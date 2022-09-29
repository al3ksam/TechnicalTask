using System;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class AddSolutionForm : Form
    {
        public AddSolutionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Имя раствора
        /// </summary>
        public string SolutionName => nameTextBox.Text.Trim();
        /// <summary>
        /// Объем раствора
        /// </summary>
        public decimal SolutionVolume => volumeNumeric.Value;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() == string.Empty)
            {
                nameTextBox.Focus();
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
