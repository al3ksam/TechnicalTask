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

        private event DbConnectionStateChangedEventHandler DbConnectionStateChanged;

        private void OnDbConnectionStateChanged(object sender, DbConnectionStateChangedEventArgs e)
        {
            if (e == null) return;

            _toolStripStatusLabel.Text = e.Text;
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

        // Обработчик нажатия кнопки соединения с БД
        private void _connectionBtn_Click(object sender, EventArgs e)
        {
            // _testConnectionBtn.Enabled = false;

            //Task.Factory.StartNew(() =>
            //{
            //    Task
            //});

            Database db = Database.GetInstance();

            

            db.Settings = _authMethodComboBox.SelectedIndex == 0 ?
                new Database.ConnectionSettings(
                    servername: _serverNameTextBox.Text.Trim()
                )
                :
                new Database.ConnectionSettings
                (
                    servername: _serverNameTextBox.Text.Trim()
                ,   userId: _usernameTextBox.Text.Trim()
                ,   password: _passwordTextBox.Text
                );
            ;

            try
            {
                InvokeOnDbConnectionStateChanged(Program.ResManager.GetString("ConnectingToServer"));

                db.Connect();

                if (db.IsConnected)
                {
                    InvokeOnDbConnectionStateChanged("Подключились к БД :)");
                }
                else
                {
                    InvokeOnDbConnectionStateChanged("Что-то пошло не так :\\");
                }
            }
            catch (SqlException)
            {
                InvokeOnDbConnectionStateChanged("Ошибка подключения к БД");
            }

            void InvokeOnDbConnectionStateChanged(in string text)
            {
                DbConnectionStateChanged?.Invoke(sender, new DbConnectionStateChangedEventArgs(text));
            }
        }

        // Обработчик нажатия кнопки "Отмена"
        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Закрываем форму
        }
    }
}
