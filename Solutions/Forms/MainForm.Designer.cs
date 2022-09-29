
namespace Solutions.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.solutionGridView = new System.Windows.Forms.DataGridView();
            this.solutionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionsLabel = new System.Windows.Forms.Label();
            this.solutionDelBtn = new System.Windows.Forms.Button();
            this.solutionAddBtn = new System.Windows.Forms.Button();
            this.componentsGridView = new System.Windows.Forms.DataGridView();
            this.componentsLabel = new System.Windows.Forms.Label();
            this.componentDelBtn = new System.Windows.Forms.Button();
            this.componentAddBtn = new System.Windows.Forms.Button();
            this.comIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comIsMainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.solutionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            resources.ApplyResources(this.updateBtn, "UpdateBtn");
            this.updateBtn.Name = "UpdateBtn";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.saveBtn, "SaveBtn");
            this.saveBtn.Name = "SaveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsBtn
            // 
            resources.ApplyResources(this.settingsBtn, "SettingsBtn");
            this.settingsBtn.Name = "SettingsBtn";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SolutionGridView
            // 
            this.solutionGridView.AllowUserToAddRows = false;
            this.solutionGridView.AllowUserToDeleteRows = false;
            this.solutionGridView.AllowUserToResizeColumns = false;
            this.solutionGridView.AllowUserToResizeRows = false;
            this.solutionGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.solutionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.solutionGridView, "SolutionGridView");
            this.solutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.solutionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.solutionIdColumn,
            this.solutionNameColumn,
            this.solutionVolumeColumn});
            this.solutionGridView.EnableHeadersVisualStyles = false;
            this.solutionGridView.MultiSelect = false;
            this.solutionGridView.Name = "SolutionGridView";
            this.solutionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.solutionGridView.RowHeadersVisible = false;
            this.solutionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.solutionGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionGridView.RowTemplate.Height = 40;
            this.solutionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.solutionGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SolutionGridView_EditingControlShowing);
            this.solutionGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SolutionGridView_RowsAdded);
            this.solutionGridView.SelectionChanged += new System.EventHandler(this.SolutionGridView_SelectionChanged);
            // 
            // SolutionIdColumn
            // 
            this.solutionIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.solutionIdColumn, "SolutionIdColumn");
            this.solutionIdColumn.Name = "SolutionIdColumn";
            this.solutionIdColumn.ReadOnly = true;
            // 
            // SolutionNameColumn
            // 
            this.solutionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.solutionNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.solutionNameColumn, "SolutionNameColumn");
            this.solutionNameColumn.MaxInputLength = 128;
            this.solutionNameColumn.Name = "SolutionNameColumn";
            // 
            // SolutionVolumeColumn
            // 
            this.solutionVolumeColumn.DataPropertyName = "Volume";
            resources.ApplyResources(this.solutionVolumeColumn, "SolutionVolumeColumn");
            this.solutionVolumeColumn.MaxInputLength = 9;
            this.solutionVolumeColumn.Name = "SolutionVolumeColumn";
            // 
            // SolutionsLabel
            // 
            resources.ApplyResources(this.solutionsLabel, "SolutionsLabel");
            this.solutionsLabel.Name = "SolutionsLabel";
            // 
            // SolutionDelBtn
            // 
            resources.ApplyResources(this.solutionDelBtn, "SolutionDelBtn");
            this.solutionDelBtn.Name = "SolutionDelBtn";
            this.solutionDelBtn.UseVisualStyleBackColor = true;
            this.solutionDelBtn.Click += new System.EventHandler(this.SolutionDelBtn_Click);
            // 
            // SolutionAddBtn
            // 
            resources.ApplyResources(this.solutionAddBtn, "SolutionAddBtn");
            this.solutionAddBtn.Name = "SolutionAddBtn";
            this.solutionAddBtn.UseVisualStyleBackColor = true;
            this.solutionAddBtn.Click += new System.EventHandler(this.SolutionAddBtn_Click);
            // 
            // ComponentsGridView
            // 
            this.componentsGridView.AllowUserToAddRows = false;
            this.componentsGridView.AllowUserToDeleteRows = false;
            this.componentsGridView.AllowUserToResizeColumns = false;
            this.componentsGridView.AllowUserToResizeRows = false;
            this.componentsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.componentsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.componentsGridView, "ComponentsGridView");
            this.componentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.componentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comIdColumn,
            this.solIdColumn,
            this.comNameColumn,
            this.comAmountColumn,
            this.comIsMainColumn});
            this.componentsGridView.EnableHeadersVisualStyles = false;
            this.componentsGridView.MultiSelect = false;
            this.componentsGridView.Name = "ComponentsGridView";
            this.componentsGridView.ReadOnly = true;
            this.componentsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.componentsGridView.RowHeadersVisible = false;
            this.componentsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.componentsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsGridView.RowTemplate.Height = 40;
            this.componentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.componentsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ComponentsGridView_RowsAdded);
            this.componentsGridView.SelectionChanged += new System.EventHandler(this.ComponentsGridView_SelectionChanged);
            // 
            // ComponentsLabel
            // 
            resources.ApplyResources(this.componentsLabel, "ComponentsLabel");
            this.componentsLabel.Name = "ComponentsLabel";
            // 
            // ComponentDelBtn
            // 
            resources.ApplyResources(this.componentDelBtn, "ComponentDelBtn");
            this.componentDelBtn.Name = "ComponentDelBtn";
            this.componentDelBtn.UseVisualStyleBackColor = true;
            this.componentDelBtn.Click += new System.EventHandler(this.ComponentDelBtn_Click);
            // 
            // ComponentAddBtn
            // 
            resources.ApplyResources(this.componentAddBtn, "ComponentAddBtn");
            this.componentAddBtn.Name = "ComponentAddBtn";
            this.componentAddBtn.UseVisualStyleBackColor = true;
            this.componentAddBtn.Click += new System.EventHandler(this.ComponentAddBtn_Click);
            // 
            // ComIdColumn
            // 
            this.comIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.comIdColumn, "ComIdColumn");
            this.comIdColumn.Name = "ComIdColumn";
            this.comIdColumn.ReadOnly = true;
            // 
            // SolIdColumn
            // 
            this.solIdColumn.DataPropertyName = "SolutionId";
            resources.ApplyResources(this.solIdColumn, "SolIdColumn");
            this.solIdColumn.Name = "SolIdColumn";
            this.solIdColumn.ReadOnly = true;
            // 
            // ComNameColumn
            // 
            this.comNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.comNameColumn, "ComNameColumn");
            this.comNameColumn.MaxInputLength = 128;
            this.comNameColumn.Name = "ComNameColumn";
            this.comNameColumn.ReadOnly = true;
            // 
            // ComAmountColumn
            // 
            this.comAmountColumn.DataPropertyName = "Percent";
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.comAmountColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.comAmountColumn, "ComAmountColumn");
            this.comAmountColumn.MaxInputLength = 5;
            this.comAmountColumn.Name = "ComAmountColumn";
            this.comAmountColumn.ReadOnly = true;
            // 
            // ComIsMainColumn
            // 
            this.comIsMainColumn.DataPropertyName = "IsMain";
            resources.ApplyResources(this.comIsMainColumn, "ComIsMainColumn");
            this.comIsMainColumn.Name = "ComIsMainColumn";
            this.comIsMainColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.componentAddBtn);
            this.Controls.Add(this.componentDelBtn);
            this.Controls.Add(this.componentsLabel);
            this.Controls.Add(this.componentsGridView);
            this.Controls.Add(this.solutionAddBtn);
            this.Controls.Add(this.solutionDelBtn);
            this.Controls.Add(this.solutionsLabel);
            this.Controls.Add(this.solutionGridView);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.updateBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.solutionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.DataGridView solutionGridView;
        private System.Windows.Forms.Label solutionsLabel;
        private System.Windows.Forms.Button solutionDelBtn;
        private System.Windows.Forms.Button solutionAddBtn;
        private System.Windows.Forms.DataGridView componentsGridView;
        private System.Windows.Forms.Label componentsLabel;
        private System.Windows.Forms.Button componentDelBtn;
        private System.Windows.Forms.Button componentAddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comIsMainColumn;
    }
}

