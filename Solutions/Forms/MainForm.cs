using System;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class MainForm : Form
    {
        // Инициализируем объект формы с настройками
        /// <summary>
        /// Форма с настройками соединения
        /// </summary>
        private SettingsForm _settingsForm = new SettingsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void _settingsBtn_Click(object sender, EventArgs e)
        {
            // Открываем форму с настройками соединения к БД
            _settingsForm.ShowDialog();
        }
    }
}
