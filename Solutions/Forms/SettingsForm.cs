using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solutions.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Обработчик загрузки формы
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // устанавливаем метод аутентификации Windows по умолчанию
            if (_authMethodComboBox.Items.Count > 0)
            {
                _authMethodComboBox.SelectedIndex = 0;
            }
        }

        // Обработчик изменения значения индекса в ComboBox-е
        private void _authMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Активируем панель пользователя (возможность вводить логин и пароль),
            // если выбран метод аутентификации пользователя SQL Server
            if (_authMethodComboBox.SelectedIndex == 1)
            {
                _userPanel.Enabled = true;
            }
            else
            {
                _userPanel.Enabled = false;
            }
        }

        // Обработчик нажатия кнопки проверки соединения
        private void _testConnectionBtn_Click(object sender, EventArgs e)
        {
            _testConnectionBtn.Enabled = false;

            MessageBox.Show(Program.ResourceManager.GetString("connectingToServer"));

            using (Database db = Database.GetInstance())
            {
                try
                {
                    if (_authMethodComboBox.SelectedIndex == 0)
                    {
                        db.Connect(_serverNameTextBox.Text.Trim());
                    }
                    else
                    {
                        db.Connect(_serverNameTextBox.Text.Trim(), _usernameTextBox.Text.Trim(), _passwordTextBox.Text);
                    }

                }
                catch (SqlException sqlException)
                {

                    Console.WriteLine(sqlException.Message);
                }

            }

            _testConnectionBtn.Enabled = true;
        }

        // Обработчик нажатия кнопки "Отмена"
        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // закрываем форму
        }
    }
}
