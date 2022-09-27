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
            string componentName = NameTextBox.Text.Trim();

            if (componentName == string.Empty)
            {
                NameTextBox.Focus();
                return;
            }
            else
            {
                if (componentName.ToLower() == "Вода".ToLower())
                {
                    MessageBox.Show(
                        Program.ResManager.GetString("MsgDlgComponentName"), 
                        Program.ResManager.GetString("MsgDlgInfoCaption"), 
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    NameTextBox.SelectAll();
                    NameTextBox.Focus();
                    return;
                }                                
            }

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
