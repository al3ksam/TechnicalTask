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

        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlAdapter = null;
        private DataTable table = null;

        public MainForm()
        {
            InitializeComponent();

            _settingsForm = new SettingsForm();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Database.GetInstance().IsConnected == false)
            {
                // Открываем форму с настройками соединения к БД
                if (_settingsForm != null)
                {
                    _settingsForm.ShowDialog();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false) return;

            try
            {
                sqlAdapter = new SqlDataAdapter("SELECT * FROM[MudDBTest].[dbo].[Solutions]", Database.GetInstance()._sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlAdapter);

                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetDeleteCommand();


                table = new DataTable();


                sqlAdapter.Fill(table);

                SolutionGridView.DataSource = table;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false) return;

            try
            {
                sqlAdapter.Update(table); // Сохраняем изменения в БД.
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик добавления записи в таблицу "Растворы"
        private void SolutionAddBtn_Click(object sender, EventArgs e)
        {
            // Проверяем соединение
            if (CheckDbConnection() == false) return;

            try
            {
                using (AddSolutionForm addSolutionForm = new AddSolutionForm())
                {
                    DialogResult dialogResult = addSolutionForm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        // Ищем максимальное значение индекса
                        string indexColName = table.Columns[0].ColumnName;
                        DataRow indexRow = table.Select($"{indexColName}=MAX({indexColName})")[0];
                        int id = Convert.ToInt32(indexRow[0]) + 1; // Новый индекс

                        DataRow row = table.NewRow();
                        row[0] = id;
                        row[1] = addSolutionForm.SolutionName;
                        row[2] = addSolutionForm.SolutionVolume;
   
                        table.Rows.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик удаления записи с таблицы "Растворы"
        private void DeleteSolutionBtn_Click(object sender, EventArgs e)
        {
            // Проверяем соединение
            if (CheckDbConnection() == false) return;

            try
            {
                if (SolutionGridView.Rows.Count > 0)
                {
                    // Ищем строку по инлексу и удаляем.
                    DataRow[] rows = table.Select($"{table.Columns[0].ColumnName} = {SolutionGridView.CurrentRow.Cells[0].Value}");

                    foreach (var row in rows)
                    {
                        row.Delete();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool CheckDbConnection()
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
    }
}
