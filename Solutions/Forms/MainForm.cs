using System;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _settingsBtn_Click(object sender, EventArgs e)
        {
            // открываем форму с настройками соединения к БД
            using(SettingsForm settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog();
            }
        }
    }
}
