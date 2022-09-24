﻿using System;
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

        // Обработчик нажатия кнопки проверки соединения
        private void _testConnectionBtn_Click(object sender, EventArgs e)
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
                ConnectionStatusChange?.Invoke(this, new ConnectionStatusEventArgs(Program.ResManager.GetString("ConnectingToServer")));

                db.Connect();

                if (db.IsConnected)
                {
                    ConnectionStatusChange?.Invoke(this, new ConnectionStatusEventArgs("К БД подключились"));
                }
                else
                {
                    ConnectionStatusChange?.Invoke(this, new ConnectionStatusEventArgs("Что-то пошло не так :\\"));
                }
            }
            catch (SqlException)
            {
                ConnectionStatusChange?.Invoke(this, new ConnectionStatusEventArgs("Ошибка подключения к БД"));
            }
        }

        // Обработчик нажатия кнопки "Отмена"
        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); // Закрываем форму
        }
    }
}
