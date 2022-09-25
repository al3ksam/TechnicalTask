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
                ConnectionPanel.Enabled = false;
                ConnectionBtn.Enabled = false;
                UpdateStatusStrip("DbConnection");
            }
            // Если нет подключения, разрешаем редактирование.
            else
            {
                ConnectionPanel.Enabled = true;
                ConnectionBtn.Enabled = true;
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

            ControlsValueChanged(sender, e); // Делегируем событие
        }

        // Обработчик нажатия кнопки соединения с БД.
        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            // Блокируем редактирование
            ConnectionPanel.Enabled = false; 
            ConnectionBtn.Enabled = false;

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
                    ConnectionPanel.Enabled = true;
                    ConnectionBtn.Enabled = true;
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
                    ConnectionPanel.Enabled = true;
                    ConnectionBtn.Enabled = true;
                    UpdateStatusStrip("DbConnectionNot");
                }
            }
            else // ... Или скрываем форму, если отключены
            {
                Hide();
            }
        }

        // Обработчик изменения значения компонентов формы.
        private void ControlsValueChanged(object sender, EventArgs e)
        {
            // Для TextBox-ов и ComboBox-ов
            if (sender is TextBox || sender is ComboBox)
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

        // Обновление полосы состояния, параметр strResKey - имя строкового ресурса.
        private void UpdateStatusStrip(in string strResKey)
        {
            // Получаем значение ресурса
            ToolStripStatusLabel.Text = Program.ResManager.GetString(strResKey);
        }
    }
}
