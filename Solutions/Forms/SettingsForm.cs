using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Solutions.Data;
using Solutions.Components;

namespace Solutions.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ConnectionStatusChange += new ConnectionStatusEventHandler(OnConnectionStatusChange);
        }

        private event ConnectionStatusEventHandler ConnectionStatusChange;

        private void OnConnectionStatusChange(object sender, ConnectionStatusEventArgs e)
        {
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

        // Обработчик нажатия кнопки проверки соединения
        private void _testConnectionBtn_Click(object sender, EventArgs e)
        {
        // _testConnectionBtn.Enabled = false;

            string serverName = _serverNameTextBox.Text.Trim();
            string userName = _usernameTextBox.Text.Trim();
            string password = _passwordTextBox.Text;
            int index = _authMethodComboBox.SelectedIndex;


            Task.Factory.StartNew(() => 
            {
                ConnectionStatusEventArgs connectionStatusEventArgs = new ConnectionStatusEventArgs();

                using (Database db = Database.GetInstance())
                {
                    db.ConnectionSettingsData = new Database.ConnectionSettings
                    {
                        ServerName = serverName,
                        UserId = userName,
                        UserPassword = password
                    };

                    try
                    {
                        CallOnConnectionStatusChange("connectingToServer");                        

                        if (index == 0)
                        {
                            
                        }
                        else
                        {
                            
                        }

                        db.Connect();


                        if (ConnectionStatusChange != null && db.IsConnected)
                        {
                            connectionStatusEventArgs.Text = "К БД подключились";
                            ConnectionStatusChange.Invoke(this, connectionStatusEventArgs);
                        }
                    }
                    catch (SqlException)
                    {
                        connectionStatusEventArgs.Text = "Ошибка подключения к БД";
                        ConnectionStatusChange?.Invoke(this, connectionStatusEventArgs);

                    }
                }

                void CallOnConnectionStatusChange(string keyRes)
                {
                    connectionStatusEventArgs.Text = Program.ResourceManager.GetString(keyRes);
                    ConnectionStatusChange?.Invoke(this, connectionStatusEventArgs);
                }
            });

            //Task.Factory.StartNew(() =>
            //{
            //    string serverName = "";
            //    string userName = "";
            //    string password = "";
            //    int index = 0;

            //    if (_serverNameTextBox.InvokeRequired)
            //    {
            //        serverName = (string)_serverNameTextBox.Invoke(new Func<string>( () => _serverNameTextBox.Text.Trim()));
            //    }
            //    else
            //    {
            //        serverName = _serverNameTextBox.Text.Trim();
            //    }

            //    if (_usernameTextBox.InvokeRequired)
            //    {
            //        userName = (string)_usernameTextBox.Invoke(new Func<string>(() => _usernameTextBox.Text.Trim()));
            //    }
            //    else
            //    {
            //        userName = _usernameTextBox.Text.Trim();
            //    }

            //    if (_passwordTextBox.InvokeRequired)
            //    {
            //        password = (string)_usernameTextBox.Invoke(new Func<string>(() => _passwordTextBox.Text));
            //    }
            //    else
            //    {
            //        password = _passwordTextBox.Text;
            //    }

            //    if (_authMethodComboBox.InvokeRequired)
            //    {
            //        index = (int)_authMethodComboBox.Invoke(new Func<int>(() => _authMethodComboBox.SelectedIndex));
            //    }
            //    else
            //    {
            //        index = _authMethodComboBox.SelectedIndex;
            //    }
            //});
        }

        // Обработчик нажатия кнопки "Отмена"
        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // закрываем форму
        }
    }
}
