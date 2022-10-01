
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // updateBtn
            // 
            resources.ApplyResources(this.updateBtn, "updateBtn");
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // settingsBtn
            // 
            resources.ApplyResources(this.settingsBtn, "settingsBtn");
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // solutionGridView
            // 
            this.solutionGridView.AllowUserToAddRows = false;
            this.solutionGridView.AllowUserToDeleteRows = false;
            this.solutionGridView.AllowUserToResizeColumns = false;
            this.solutionGridView.AllowUserToResizeRows = false;
            this.solutionGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.solutionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.solutionGridView, "solutionGridView");
            this.solutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.solutionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.solutionIdColumn,
            this.solutionNameColumn,
            this.solutionVolumeColumn});
            this.solutionGridView.EnableHeadersVisualStyles = false;
            this.solutionGridView.MultiSelect = false;
            this.solutionGridView.Name = "solutionGridView";
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
            // solutionIdColumn
            // 
            this.solutionIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.solutionIdColumn, "solutionIdColumn");
            this.solutionIdColumn.Name = "solutionIdColumn";
            this.solutionIdColumn.ReadOnly = true;
            // 
            // solutionNameColumn
            // 
            this.solutionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.solutionNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.solutionNameColumn, "solutionNameColumn");
            this.solutionNameColumn.MaxInputLength = 128;
            this.solutionNameColumn.Name = "solutionNameColumn";
            // 
            // solutionVolumeColumn
            // 
            this.solutionVolumeColumn.DataPropertyName = "Volume";
            resources.ApplyResources(this.solutionVolumeColumn, "solutionVolumeColumn");
            this.solutionVolumeColumn.MaxInputLength = 9;
            this.solutionVolumeColumn.Name = "solutionVolumeColumn";
            // 
            // solutionsLabel
            // 
            resources.ApplyResources(this.solutionsLabel, "solutionsLabel");
            this.solutionsLabel.Name = "solutionsLabel";
            // 
            // solutionDelBtn
            // 
            resources.ApplyResources(this.solutionDelBtn, "solutionDelBtn");
            this.solutionDelBtn.Name = "solutionDelBtn";
            this.solutionDelBtn.UseVisualStyleBackColor = true;
            this.solutionDelBtn.Click += new System.EventHandler(this.SolutionDelBtn_Click);
            // 
            // solutionAddBtn
            // 
            resources.ApplyResources(this.solutionAddBtn, "solutionAddBtn");
            this.solutionAddBtn.Name = "solutionAddBtn";
            this.solutionAddBtn.UseVisualStyleBackColor = true;
            this.solutionAddBtn.Click += new System.EventHandler(this.SolutionAddBtn_Click);
            // 
            // componentsGridView
            // 
            this.componentsGridView.AllowUserToAddRows = false;
            this.componentsGridView.AllowUserToDeleteRows = false;
            this.componentsGridView.AllowUserToResizeColumns = false;
            this.componentsGridView.AllowUserToResizeRows = false;
            this.componentsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.componentsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.componentsGridView, "componentsGridView");
            this.componentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.componentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comIdColumn,
            this.solIdColumn,
            this.comNameColumn,
            this.comAmountColumn,
            this.comIsMainColumn});
            this.componentsGridView.EnableHeadersVisualStyles = false;
            this.componentsGridView.MultiSelect = false;
            this.componentsGridView.Name = "componentsGridView";
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
            // componentsLabel
            // 
            resources.ApplyResources(this.componentsLabel, "componentsLabel");
            this.componentsLabel.Name = "componentsLabel";
            // 
            // componentDelBtn
            // 
            resources.ApplyResources(this.componentDelBtn, "componentDelBtn");
            this.componentDelBtn.Name = "componentDelBtn";
            this.componentDelBtn.UseVisualStyleBackColor = true;
            this.componentDelBtn.Click += new System.EventHandler(this.ComponentDelBtn_Click);
            // 
            // componentAddBtn
            // 
            resources.ApplyResources(this.componentAddBtn, "componentAddBtn");
            this.componentAddBtn.Name = "componentAddBtn";
            this.componentAddBtn.UseVisualStyleBackColor = true;
            this.componentAddBtn.Click += new System.EventHandler(this.ComponentAddBtn_Click);
            // 
            // comIdColumn
            // 
            this.comIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.comIdColumn, "comIdColumn");
            this.comIdColumn.Name = "comIdColumn";
            this.comIdColumn.ReadOnly = true;
            // 
            // solIdColumn
            // 
            this.solIdColumn.DataPropertyName = "SolutionId";
            resources.ApplyResources(this.solIdColumn, "solIdColumn");
            this.solIdColumn.Name = "solIdColumn";
            this.solIdColumn.ReadOnly = true;
            // 
            // comNameColumn
            // 
            this.comNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.comNameColumn, "comNameColumn");
            this.comNameColumn.MaxInputLength = 128;
            this.comNameColumn.Name = "comNameColumn";
            this.comNameColumn.ReadOnly = true;
            // 
            // comAmountColumn
            // 
            this.comAmountColumn.DataPropertyName = "Percent";
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            this.comAmountColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.comAmountColumn, "comAmountColumn");
            this.comAmountColumn.MaxInputLength = 5;
            this.comAmountColumn.Name = "comAmountColumn";
            this.comAmountColumn.ReadOnly = true;
            // 
            // comIsMainColumn
            // 
            this.comIsMainColumn.DataPropertyName = "IsMain";
            resources.ApplyResources(this.comIsMainColumn, "comIsMainColumn");
            this.comIsMainColumn.Name = "comIsMainColumn";
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

