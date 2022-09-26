using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Solutions.Data;

namespace Solutions.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Форма с настройками соединения
        /// </summary>
        private readonly SettingsForm _settingsForm;

        // --------------------------------------------
        // Временно (в последствии будет перенесено в Database)
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlAdapter = null;
        private DataTable table = null;

        private SqlCommandBuilder sqlBuilder2 = null;
        private SqlDataAdapter sqlAdapter2 = null;
        private DataTable table2 = null;

        // --------------------------------------------

        public MainForm()
        {
            InitializeComponent();

            _settingsForm = new SettingsForm();
        }

        private static void ShowErrorMsgDialog(Exception exception)
        {
            MessageBox.Show(
                exception.Message,
                Program.ResManager.GetString("MsgDlgErrorCaption"),
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
        }

        // Проверка соединения с БД
        private static bool CheckDbConnection()
        {
            if (Database.GetInstance().IsConnected == false)
            {
                MessageBox.Show(
                    Program.ResManager.GetString("DbConnectionNotMsg"),
                    Program.ResManager.GetString("DbConnectionNotMsgCaption"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
            else
            {
                return true;
            }
        }
        // Обработчик закгрузки формы
        private void MainForm_Load(object sender, EventArgs e)
        { 
            table = new DataTable();
            SolutionGridView.DataSource = table;

            table2 = new DataTable();
            ComponentsGridView.DataSource = table2;
        }

        // Обработчик отображения формы
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Если нет соединения с БД
            if (Database.GetInstance().IsConnected == false)
            {
                // Открываем форму с настройками соединения к БД
                if (_settingsForm != null)
                {
                    _settingsForm.ShowDialog();
                }
            }
        }

        // Обработчик нажатия на кнопку "Обновить"
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false) return;

            try
            {
                sqlAdapter = new SqlDataAdapter("SELECT * FROM [MudDBTest].[dbo].[Solutions]", Database.GetInstance()._sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlAdapter);

                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetDeleteCommand();

                table.Rows.Clear();
                sqlAdapter.Fill(table);

                // Ищем максимальное значение индекса
                string indexColName = table.Columns[0].ColumnName;
                DataRow indexRow = table.Select($"{indexColName}=MAX({indexColName})")[0];
                _maxSolutionId = indexRow.Field<int>(0); // Сохраняем

                

                sqlAdapter2 = new SqlDataAdapter("SELECT *  FROM [MudDBTest].[dbo].[Components]", Database.GetInstance()._sqlConnection);

                sqlBuilder2 = new SqlCommandBuilder(sqlAdapter2);

                sqlBuilder2.GetUpdateCommand();
                sqlBuilder2.GetInsertCommand();
                sqlBuilder2.GetDeleteCommand();

                table2.Rows.Clear();
                sqlAdapter2.Fill(table2);

                SaveBtn.Enabled = true;
                SolutionAddBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик нажатия на кнопку "Сохранить"
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false || sqlAdapter == null) return;

            try
            {
                if (table != null)
                {
                    sqlAdapter.Update(table); // Сохраняем изменения в БД.
                }
                else
                {
                    MessageBox.Show(
                        Program.ResManager.GetString("MsgDlgDataNotLoaded"),
                        Program.ResManager.GetString("MsgDlgInfoCaption"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик нажатия на кнопку "Настройки соединения"
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            // Открываем форму с настройками соединения к БД
            if (_settingsForm != null)
            {
                _settingsForm.ShowDialog();
            }
        }

        // Обработчик нажатия кнопок в колонке
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
