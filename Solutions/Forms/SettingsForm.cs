using System;
using System.Windows.Forms;
using Solutions.Data;

namespace Solutions.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        // Вызывается при отображении формы.
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            // Если есть подключение, запрещаем редактирование и выводим сообщение на строку состояния.
            if (Database.GetInstance().IsConnected)
            {
                UserEditingEnable(false);
                UpdateStatusStrip("DbConnection");
            }
            // Если нет подключения, запрещаем редактирование.
            else
            {
                UserEditingEnable(true);
                UpdateStatusStrip("DbConnectionNot");
            }
            
            // Проверяем наличие элементов. 
            // Устанавливаем метод аутентификации Windows по умолчанию,
            // если метод аутентификации не выбран.
            if (AuthMethodComboBox.Items.Count > 0 && AuthMethodComboBox.SelectedIndex == -1)
            {
                AuthMethodComboBox.SelectedIndex = 0;
            }
        }

        // Обработчик закрытия формы.
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Скрываем форму, если нажимаем на "крестик"
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                Hide();
            }
        }

        // Обработчик изменения значения свойства Text компонентов TextBox.
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Обработчик вызвал компонент Обработчик событий для ServerNameTextBox и UsernameTextBox.
            if
            (
                (sender != null) && 
                (sender is TextBox textBox) &&
                (textBox.Equals(ServerNameTextBox) || textBox.Equals(UsernameTextBox))
            )
            {
                CheckEmptyServernameAndUsername();
            }
        }

        // Обработчик изменения значения индекса в ComboBox-е.
        private void AuthMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Активируем панель пользователя (возможность вводить логин и пароль),
            // если выбран метод аутентификации пользователя SQL Server
            if (AuthMethodComboBox.SelectedIndex == 0)
            {
                UserPanel.Enabled = false;
            }
            else
            {
                UserPanel.Enabled = true;
            }

            CheckEmptyServernameAndUsername();
        }

        // Обработчик нажатия кнопки соединения с БД.
        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            // Блокируем редактирование
            UserEditingEnable(false);

            Database db = Database.GetInstance();

            // Задаем настройки подключения к БД
            db.Settings = AuthMethodComboBox.SelectedIndex == 0 ?
                new Database.ConnectionSettings(
                    servername: ServerNameTextBox.Text.Trim()
                )
                :
                new Database.ConnectionSettings
                (
                    servername: ServerNameTextBox.Text.Trim(),
                    userId: UsernameTextBox.Text.Trim(),
                    password: PasswordTextBox.Text
                );
            ;

            UpdateStatusStrip("DbConnecting");

            try
            {
                db.Connect();
            }
            catch (Exception)
            {
                // Error Handlers...
            }
            finally
            {
                if (db.IsConnected) // Если подключились
                {
                    UpdateStatusStrip("DbConnected");
                }
                else // // Если подключиться не удалось
                {
                    UpdateStatusStrip("DbConnectFailed");
                    UserEditingEnable(true);
                }
            }
        }

        // Обработчик нажатия кнопки "Отмена".
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Database db = Database.GetInstance();

            // Отключаем от БД, если подключены ...
            if (db.IsConnected)
            {
                db.Disconnect();

                if (db.IsConnected == false)
                {
                    UserEditingEnable(true);
                    UpdateStatusStrip("DbConnectionNot");
                }
            }
            else // ... Или скрываем форму, если отключены
            {
                Hide();
            }
        }

        // Обновление полосы состояния, параметр strResKey - имя строкового ресурса.
        private void UpdateStatusStrip(in string strResKey)
        {
            // Получаем значение ресурса
            string text = Program.ResManager.GetString(strResKey);
            if (text == null) { text = string.Empty; }
            ToolStripStatusLabel.Text = text;
        }

        // Отключение/включение элементов для редактирования пользователем.
        private void UserEditingEnable(bool value)
        {
            ConnectionPanel.Enabled = value; 
            ConnectionBtn.Enabled = value;
        }

        // Проверка имя сервера и имя пользователя на пустое значение: отключаем кнопку "Соединить".
        private void CheckEmptyServernameAndUsername()
        {
            // Если имя сервера или пользователя пустое, отключаем кнопку "Соединить".
            if 
            (
                (ServerNameTextBox.Text.Trim() == string.Empty) ||
                (UsernameTextBox.Text.Trim() == string.Empty && AuthMethodComboBox.SelectedIndex == 1)
            )
            {
                ConnectionBtn.Enabled = false;
            }
            else
            {
                ConnectionBtn.Enabled = true;
            }
        }
    }
}
