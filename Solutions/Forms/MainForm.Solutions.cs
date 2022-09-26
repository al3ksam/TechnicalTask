using System;
using System.Data;
using System.Windows.Forms;

namespace Solutions.Forms
{
    partial class MainForm
    {
        private int _maxSolutionId = 0; // Максимальный Id таблицы "Растворы"
        private bool _isSolutionRowAdded = false; // Флаг добавления записи в таблицу "Растворы"

        // Обработчик добавления записи в таблицу "Растворы"
        private void SolutionAddBtn_Click(object sender, EventArgs e)
        {
            if (table == null) return;

            try
            {
                using (AddSolutionForm addSolutionForm = new AddSolutionForm())
                {
                    DialogResult dialogResult = addSolutionForm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        // Создаем новую строку и заполняем значениями
                        DataRow row = table.NewRow();
                        row.SetField(0, ++_maxSolutionId);
                        row.SetField(1, addSolutionForm.SolutionName);
                        row.SetField(2, addSolutionForm.SolutionVolume);

                        // Устанавливаем флаг добавления строки
                        _isSolutionRowAdded = true;

                        table.Rows.Add(row); // Добавляем строку
                    }
                }
            }
            catch (Exception exception)
            {
                // Снимаем флаг, если была ошибка
                if (_isSolutionRowAdded == true)
                {
                    _isSolutionRowAdded = false;
                }

                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик удаления записи с таблицы "Растворы"
        private void SolutionDelBtn_Click(object sender, EventArgs e)
        {
            if (table == null) return;

            try
            {
                if (SolutionGridView.Rows.Count > 0)
                {
                    int index = Convert.ToInt32(SolutionGridView.CurrentRow.Cells[0].Value);

                    // Ищем строки по индексу и удаляем.
                    DataRow[] solutionRows = table.Select($"{table.Columns[0].ColumnName} = {index}");


                    foreach (var solutionRow in solutionRows)
                    {
                        if (table2 != null)
                        {
                            // Ищем компоненты раствора
                            DataRow[] componentRows = table2.Select($"{table2.Columns[1].ColumnName} = {index}");

                            // Удаляем записи компонентов
                            foreach (var componentRow in componentRows)
                            {
                                componentRow.Delete();
                            }
                        }

                        solutionRow.Delete(); // Удаляем запись раствора
                    }
                }
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
            finally
            {
                // Отключаем кнопку удаления раствора, если не осталось записей
                if (SolutionGridView.Rows.Count == 0)
                {
                    SolutionDelBtn.Enabled = false;
                }
            }
        }

        // Обработчик изменения текущего выбора в GridView растворов
        private void SolutionGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (SolutionGridView.Rows.Count > 0 && table2 != null && table2.Rows.Count > 0)
                {
                    //int index = Convert.ToInt32(SolutionGridView.CurrentRow.Cells[0].Value);
                    //table2.DefaultView.RowFilter = string.Format($"{table2.Columns[1].ColumnName} = {index}");
                }
            }
            catch (Exception exception)
            {

                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик изменения источника данных
        private void SolutionGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Если есть записи в таблице "Растворы", включаем кнопку удаления записи
            if (SolutionGridView.Rows.Count > 0 && SolutionDelBtn.Enabled == false)
            {
                SolutionDelBtn.Enabled = true;
            }
        }

        // Обработчик добавления строк в GridView растворов
        private void SolutionGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Если добавили строку
            if (_isSolutionRowAdded == true)
            {
                // Выделяем строку и "скроллимся" на неё
                DataGridViewRow row = SolutionGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    row.Selected = true;
                    SolutionGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }

                _isSolutionRowAdded = false; // Снимаем флаг
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
    }
}
