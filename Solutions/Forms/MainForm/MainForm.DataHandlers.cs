using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Solutions.Data;

namespace Solutions.Forms
{
    partial class MainForm
    {
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
    }
}
