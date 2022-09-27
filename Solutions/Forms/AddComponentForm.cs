using System;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class AddComponentForm : Form
    {
        public AddComponentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Имя компонента
        /// </summary>
        public string ComponentName => NameTextBox.Text.Trim();
        /// <summary>
        /// Количество компонента
        /// </summary>
        public decimal ComponentAmount => AmountNumeric.Value;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
