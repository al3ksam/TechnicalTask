using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Solutions.Data;
using Solutions.Units;

namespace Solutions.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Форма с настройками соединения
        /// </summary>
        private readonly SettingsForm _settingsForm;

        private int _maxSolutionId = 0; // Максимальный Id таблицы "Растворы"
        private int _maxComponentId = 0; // Максимальный Id таблицы "Растворы"
        private bool _isSolutionRowAdded = false; // Флаг добавления записи в таблицу "Растворы"
        private bool _isComponentRowAdded = false; // Флаг добавления записи в таблицу "Компоненты"

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

        // Сообщение об ошибке
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
            solutionGridView.DataSource = table;

            table2 = new DataTable();
            componentsGridView.DataSource = table2;
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

                sqlAdapter2 = new SqlDataAdapter("SELECT *  FROM [MudDBTest].[dbo].[Components]", Database.GetInstance()._sqlConnection);

                sqlBuilder2 = new SqlCommandBuilder(sqlAdapter2);

                sqlBuilder2.GetUpdateCommand();
                sqlBuilder2.GetInsertCommand();
                sqlBuilder2.GetDeleteCommand();

                table2.Rows.Clear();
                sqlAdapter2.Fill(table2);

                if (table2.Rows.Count > 0)
                {
                    // Ищем максимальное значение индекса компонентов
                    string indexComColName = table2.Columns[0].ColumnName;
                    DataRow indexRowComponent = table2.Select($"{indexComColName}=MAX({indexComColName})")[0];
                    _maxComponentId = indexRowComponent.Field<int>(0); // Сохраняем
                }
                else
                {
                    _maxComponentId = 0;
                }
                

                table.Rows.Clear();
                sqlAdapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    // Ищем максимальное значение индекса растворов
                    string indexSolColName = table.Columns[0].ColumnName;
                    DataRow indexRowSolution = table.Select($"{indexSolColName}=MAX({indexSolColName})")[0];
                    _maxSolutionId = indexRowSolution.Field<int>(0); // Сохраняем
                }
                else
                {
                    _maxSolutionId = 0;
                }

                saveBtn.Enabled = true;
                solutionAddBtn.Enabled = true;
            }
            catch (Exception exception)
            {
                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик нажатия на кнопку "Сохранить"
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CheckDbConnection() == false || sqlAdapter == null || sqlAdapter2 == null) return;

            try
            {
                if (table != null && table2 != null)
                {

                    // Сохраняем изменения в БД.
                    sqlAdapter2.Update(table2);
                    sqlAdapter.Update(table);
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
            Focus();
        }

        // Обработчик добавления записи в таблицу "Растворы"
        private void SolutionAddBtn_Click(object sender, EventArgs e)
        {
            if (table == null || table2 == null) return;

            try
            {
                using (AddSolutionForm addSolutionForm = new AddSolutionForm())
                {
                    DialogResult dialogResult = addSolutionForm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        // Создаем новую строку и заполняем значениями
                        DataRow solutionRow = table.NewRow();
                        solutionRow.SetField(0, ++_maxSolutionId);
                        solutionRow.SetField(1, addSolutionForm.SolutionName);
                        solutionRow.SetField(2, addSolutionForm.SolutionVolume);

                        // Устанавливаем флаг добавления строки
                        _isSolutionRowAdded = true;

                        table.Rows.Add(solutionRow); // Добавляем строку раствора

                        // Добавляем основной компонент
                        DataRow componentRow = table2.NewRow();
                        componentRow.SetField(0, ++_maxComponentId);
                        componentRow.SetField(1, _maxSolutionId);
                        componentRow.SetField(2, "Вода");
                        componentRow.SetField(3, 100);
                        componentRow.SetField(4, true);

                        table2.Rows.Add(componentRow); // Добавляем строку основного компонента
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
                if (solutionGridView.SelectedRows.Count > 0)
                {
                    int index = Convert.ToInt32(solutionGridView.SelectedRows[0].Cells[0].Value);

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
                if (solutionGridView.Rows.Count == 0)
                {
                    solutionDelBtn.Enabled = false;
                }
            }
        }

        // Обработчик изменения текущего выбора в GridView растворов
        private void SolutionGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (solutionGridView.SelectedRows.Count > 0)
            {
                try
                {
                    // Фильтрация компонентов по раствору
                    if (table2 != null && table2.Rows.Count > 0)
                    {
                        int index = Convert.ToInt32(solutionGridView.SelectedRows[0].Cells[0].Value);
                        table2.DefaultView.RowFilter = string.Format($"{table2.Columns[1].ColumnName} = {index}");                        
                    }
                }
                catch (Exception exception)
                {
                    ShowErrorMsgDialog(exception);
                }

                // Включаем кнопку удаления раствора, если выбрана строка
                solutionDelBtn.Enabled = true;
            }
            else
            {
                // Отключаем кнопку, если не выбран раствор
                solutionDelBtn.Enabled = false;
            }
        }

        // Обработчик добавления строк в GridView растворов
        private void SolutionGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Если добавили строку
            if (_isSolutionRowAdded == true)
            {
                // Выделяем строку и "скроллимся" на неё
                DataGridViewRow row = solutionGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    row.Selected = true;
                    solutionGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }

                _isSolutionRowAdded = false; // Снимаем флаг
            }

        }

        // Обработчик отображения элемента управления для редактирования ячейки таблицы "Растворы"
        private void SolutionGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e != null)
            {
                // Когда редактируем значение ячейки, вешаем на ячейку обработчик нажатия кнопок клавиатуры
                e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
                if (solutionGridView.CurrentCell.ColumnIndex == 2)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                    }
                }
            }
        }

        // Обработчик добавления строк в компонентов растворов
        private void ComponentsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Если добавили строку
            if (_isComponentRowAdded == true)
            {
                // Выделяем строку и "скроллимся" на неё
                DataGridViewRow row = componentsGridView.Rows[e.RowIndex];
                if (row != null)
                {
                    row.Selected = true;
                    componentsGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }

                _isComponentRowAdded = false; // Снимаем флаг
            }
        }

        // Обработчик добавления записи в таблицу "Компоненты"
        private void ComponentAddBtn_Click(object sender, EventArgs e)
        {
            if (table2 == null || solutionGridView.SelectedRows.Count == 0) return;

            try
            {
                // Создаем раствор
                Solution solution = new Solution();
                // Заполняем компонентами
                FillSolutionFromComponentsGridView(solution);

                using (AddComponentForm addComponentForm = new AddComponentForm())
                {
                    DialogResult dialogResult = DialogResult.None;

                    while (dialogResult != DialogResult.Cancel)
                    {
                        dialogResult = addComponentForm.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {

                            Component component = new Component(_maxSolutionId + 1, addComponentForm.ComponentAmount);

                            // Если получилось добавить компонент в раствор: 
                            if (solution.AddComponent(component))
                            {
                                // Id раствора
                                int solutionId = Convert.ToInt32(solutionGridView.SelectedRows[0].Cells[0].Value);

                                // Создаем новую строку и заполняем значениями
                                DataRow componentRow = table2.NewRow();
                                componentRow.SetField(0, ++_maxComponentId);
                                componentRow.SetField(1, solutionId);
                                componentRow.SetField(2, addComponentForm.ComponentName);
                                componentRow.SetField(3, addComponentForm.ComponentAmount);
                                componentRow.SetField(4, false);

                                // Устанавливаем флаг добавления строки
                                _isComponentRowAdded = true;

                                table2.Rows.Add(componentRow); // Добавляем строку раствора

                                SetWaterValueInCompDbGrid(solution.Water);

                                break;
                            }
                            else // Иначе выводим сообщение и возможное количество воды для нового компонента
                            {
                                MessageBox.Show(
                                    Program.ResManager.GetString("MsgDlgWater") + " => " + solution.WaterForComponent + "%",
                                    Program.ResManager.GetString("MsgDlgInfoCaption"),
                                    MessageBoxButtons.OK, MessageBoxIcon.Information
                                );
                            }
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                // Снимаем флаг, если была ошибка
                if (_isComponentRowAdded == true)
                {
                    _isComponentRowAdded = false;
                }

                ShowErrorMsgDialog(exception);
            }
        }

        // Обработчик удаления записи с таблицы "Компоненты"
        private void ComponentDelBtn_Click(object sender, EventArgs e)
        {
            if (table2 == null) return;

            try
            {
                if (componentsGridView.SelectedRows.Count > 0)
                {
                    int index = Convert.ToInt32(componentsGridView.SelectedRows[0].Cells[0].Value);

                    // Ищем строки по индексу и удаляем.
                    DataRow[] componentRows = table2.Select($"{table2.Columns[0].ColumnName} = {index}");

                    // Создаем раствор
                    Solution solution = new Solution();
                    // Заполняем компонентами
                    FillSolutionFromComponentsGridView(solution);

                    foreach (var componentRow in componentRows)
                    {
                        // Удаляем компонент из раствора
                        solution.DeleteComponent(componentRow.Field<int>(0));
                        SetWaterValueInCompDbGrid(solution.Water); // Устанавливаем новое значение воды

                        componentRow.Delete(); // Удаляем запись раствора
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
                if (componentsGridView.Rows.Count == 0)
                {
                    componentDelBtn.Enabled = false;
                }
            }
        }

        // Обработчик изменения текущего выбора в GridView компонентов
        private void ComponentsGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Если есть выбранный компонент
            if (componentsGridView.SelectedRows.Count > 0)
            {
                try
                {
                    componentAddBtn.Enabled = true; // Включаем кнопку добавления компонентов

                    // Отключаем кнопку удаления компонента, если это главный компонент
                    bool isComponentMain = Convert.ToBoolean(componentsGridView.SelectedRows[0].Cells[4].Value);

                    if (isComponentMain)
                    {
                        componentDelBtn.Enabled = false;
                    }
                    else
                    {
                        componentDelBtn.Enabled = true;
                    }
                }
                catch (Exception exeption)
                {
                    ShowErrorMsgDialog(exeption);
                }
            }
            else // Компонент не выбран
            {
                // Если нет записей, отключаем кнопку добавления
                if (componentsGridView.Rows.Count > 0)
                {
                    componentAddBtn.Enabled = true;
                }
                else
                {
                    componentAddBtn.Enabled = false;
                }

                componentDelBtn.Enabled = false; // Отключаем кнопку удаления компонента
            }
        }

        // Заполнить объект "Раствор" из таблицы "Компоненты"
        private void FillSolutionFromComponentsGridView(Solution solution)
        {
            if (solution != null && componentsGridView.Rows.Count > 0)
            {
                // Добавляем компоненты в раствор
                foreach (DataGridViewRow dgViewcomponentRow in componentsGridView.Rows)
                {
                    // Игнорируем основной компонент - воду
                    if (Convert.ToBoolean(dgViewcomponentRow.Cells[4].Value) == true) continue;

                    int compId = Convert.ToInt32(dgViewcomponentRow.Cells[0].Value);
                    decimal compAmount = Convert.ToDecimal(dgViewcomponentRow.Cells[3].Value);

                    // Создаем компонент
                    Component component = new Component(compId, compAmount);
                    solution.AddComponent(component); // Добавляем компонент в раствор
                }
            }
        }

        // Установить значение воды для строки с "водой" в таблице "Компоненты"
        private void SetWaterValueInCompDbGrid(decimal waterValue)
        {
            if (componentsGridView.Rows.Count > 0)
            {
                // Ищем в таблице "воду"
                foreach (DataGridViewRow compRow in componentsGridView.Rows)
                {
                    // Если нашли воду
                    if (Convert.ToBoolean(compRow.Cells[4].Value) == true)
                    {
                        // записываем значение
                        compRow.Cells[3].Value = waterValue;
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
    }
}
