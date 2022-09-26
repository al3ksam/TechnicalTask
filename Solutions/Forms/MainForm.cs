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

                table = new DataTable();

                sqlAdapter.Fill(table);


                sqlAdapter2 = new SqlDataAdapter(@"
                    SELECT [MudDBTest].[dbo].[Components].[Id], [MudDBTest].[dbo].[Components].[SolutionId], [MudDBTest].[dbo].[Components].[Name], [MudDBTest].[dbo].[Components].[Percent] 
                    FROM [MudDBTest].[dbo].[Components], [MudDBTest].[dbo].[Solutions]
                    WHERE [MudDBTest].[dbo].[Components].[SolutionId] = [MudDBTest].[dbo].[Solutions].[Id]"
                , Database.GetInstance()._sqlConnection);

                table2 = new DataTable();

                sqlAdapter2.Fill(table2);

                SolutionGridView.DataSource = table;
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик нажатия на кнопку "Сохранить"
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false) return;

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

        // Обработчик добавления записи в таблицу "Растворы"
        private void SolutionAddBtn_Click(object sender, EventArgs e)
        {
            // Проверяем соединение
            if (CheckDbConnection() == false || table == null) return;

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
                        int id = indexRow.Field<int>(0) + 1; // Новый индекс

                        // Создаем новую строку и заполняем значениями
                        DataRow row = table.NewRow();
                        row.SetField(0, id);
                        row.SetField(1, addSolutionForm.SolutionName);
                        row.SetField(2, addSolutionForm.SolutionVolume);
   
                        table.Rows.Add(row); // Добавляем строку
                    }
                }
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик удаления записи с таблицы "Растворы"
        private void DeleteSolutionBtn_Click(object sender, EventArgs e)
        {
            // Проверяем соединение
            if (CheckDbConnection() == false || table == null) return;

            try
            {
                if (SolutionGridView.Rows.Count > 0)
                {
                    // Ищем строки по инлексу и удаляем.
                    DataRow[] rows = table.Select($"{table.Columns[0].ColumnName} = {SolutionGridView.CurrentRow.Cells[0].Value}");

                    foreach (var row in rows)
                    {
                        row.Delete();
                    }
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

        // Обработчик отображения элемента управления для редактирования ячейки
        private void SolutionGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e != null)
            {
                // Когда редактируем значение ячейки, вешаем на ячейку обработчик нажатия кнопок клавиатуры
                e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
                if (SolutionGridView.CurrentCell.ColumnIndex == 2)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                    }
                }
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

        // Обработчик изменения текущего выбора в GridView
        private void SolutionGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (SolutionGridView.Rows.Count > 0 && table2 != null)
                {
                    int index = Convert.ToInt32(SolutionGridView.CurrentRow.Cells[0].Value);
                    table2.DefaultView.RowFilter = string.Format($"SolutionId = {index}");

                    ComponentsGridView.DataSource = table2;
                }
            }
            catch (Exception exception)
            {

                ShowErrorMsgDialog(exception);
            }
        }
    }
}
