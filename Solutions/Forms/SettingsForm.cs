using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Solutions.Data;
using Solutions.Forms.Components;

namespace Solutions.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            DbConnectionStateChanged += new DbConnectionStateChangedEventHandler(OnDbConnectionStateChanged);
        }

        // Событие изменения состояния подключения к БД
        private event DbConnectionStateChangedEventHandler DbConnectionStateChanged;

        // Обработчик события изменения состояния подключения к БД
        private void OnDbConnectionStateChanged(object sender, DbConnectionStateChangedEventArgs e)
        {
            if (e == null) return;

            ToolStripStatusLabel.Text = e.Text;
        }

        // Обработчик загрузки формы
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Проверяем наличие элементов. 
            // Устанавливаем метод аутентификации Windows по умолчанию,
            // если метод аутентификации не выбран
            if (AuthMethodComboBox.Items.Count == 2 && AuthMethodComboBox.SelectedIndex == -1)
            {
                AuthMethodComboBox.SelectedIndex = 0;
            }
        }

        // Обработчик изменения значения свойства Text компонентов TextBox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // На всякий случай :)
            if (sender == null) return;

            // Обработчик вызвал компонент TextBox
            if (sender is TextBox textBox)
            {
                // Если имя сервера или пользователя пустое, отключаем кнопку "Соединить"
                if 
                (
                    (textBox.Equals(ServerNameTextBox) || textBox.Equals(UsernameTextBox)) 
                    && 
                    textBox.Text.Trim() == string.Empty
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

        // Обработчик изменения значения индекса в ComboBox-е
        private void AuthMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Активируем панель пользователя (возможность вводить логин и пароль),
            // если выбран метод аутентификации пользователя SQL Server
            if (AuthMethodComboBox.SelectedIndex == 0)
            {
                UserPanel.Enabled = false;

                if (ServerNameTextBox.Text.Trim() == string.Empty)
                {
                    ConnectionBtn.Enabled = false;
                }
                else
                {
                    ConnectionBtn.Enabled = true;
                }
            }
            else
            {
                UserPanel.Enabled = true;

                if (UsernameTextBox.Text.Trim() == string.Empty)
                {
                    ConnectionBtn.Enabled = false;
                }
                else
                {
                    ConnectionBtn.Enabled = true;
                }
            }
        }

        // Обработчик нажатия кнопки соединения с БД
        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            // _testConnectionBtn.Enabled = false;

            Database db = Database.GetInstance();

            db.Settings = AuthMethodComboBox.SelectedIndex == 0 ?
                new Database.ConnectionSettings(
                    servername: ServerNameTextBox.Text.Trim()
                )
                :
                new Database.ConnectionSettings
                (
                    servername: ServerNameTextBox.Text.Trim()
                , userId: UsernameTextBox.Text.Trim()
                , password: PasswordTextBox.Text
                );
            ;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    InvokeOnDbConnectionStateChanged(Program.ResManager.GetString("DbConnecting"));

                    db.Connect();

                    if (db.IsConnected)
                    {
                        InvokeOnDbConnectionStateChanged(Program.ResManager.GetString("DbConnected"));
                    }
                    else
                    {
                        InvokeOnDbConnectionStateChanged(Program.ResManager.GetString("DbConnectFailed"));
                    }
                }
                catch (SqlException)
                {
                    InvokeOnDbConnectionStateChanged(Program.ResManager.GetString("DbConnectFailed"));
                }

                void InvokeOnDbConnectionStateChanged(in string text)
                {
                    DbConnectionStateChanged?.Invoke(this, new DbConnectionStateChangedEventArgs(text));
                }
            });
        }

        // Обработчик нажатия кнопки "Отмена"
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Закрываем форму
        }
    }
}
