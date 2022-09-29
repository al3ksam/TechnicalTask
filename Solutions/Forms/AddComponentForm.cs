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
        public string ComponentName => nameTextBox.Text.Trim();
        /// <summary>
        /// Количество компонента
        /// </summary>
        public decimal ComponentAmount => amountNumeric.Value;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string componentName = nameTextBox.Text.Trim();

            if (componentName == string.Empty)
            {
                nameTextBox.Focus();
                return;
            }
            else if (componentName.ToLower() == "Вода".ToLower())
            {
                MessageBox.Show(
                    Program.ResManager.GetString("MsgDlgComponentName"), 
                    Program.ResManager.GetString("MsgDlgInfoCaption"), 
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                nameTextBox.SelectAll();
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
