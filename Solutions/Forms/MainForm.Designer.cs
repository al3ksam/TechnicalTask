
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.SolutionGridView = new System.Windows.Forms.DataGridView();
            this.SolutionsLabel = new System.Windows.Forms.Label();
            this.SolutionDelBtn = new System.Windows.Forms.Button();
            this.SolutionAddBtn = new System.Windows.Forms.Button();
            this.ComponentsGridView = new System.Windows.Forms.DataGridView();
            this.ComponentsLabel = new System.Windows.Forms.Label();
            this.ComponentDelBtn = new System.Windows.Forms.Button();
            this.ComponentAddBtn = new System.Windows.Forms.Button();
            this.SolutionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComIsMainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            resources.ApplyResources(this.UpdateBtn, "UpdateBtn");
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsBtn
            // 
            resources.ApplyResources(this.SettingsBtn, "SettingsBtn");
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // SolutionGridView
            // 
            this.SolutionGridView.AllowUserToAddRows = false;
            this.SolutionGridView.AllowUserToDeleteRows = false;
            this.SolutionGridView.AllowUserToResizeColumns = false;
            this.SolutionGridView.AllowUserToResizeRows = false;
            this.SolutionGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SolutionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.SolutionGridView, "SolutionGridView");
            this.SolutionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SolutionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SolutionIdColumn,
            this.SolutionNameColumn,
            this.SolutionVolumeColumn});
            this.SolutionGridView.EnableHeadersVisualStyles = false;
            this.SolutionGridView.MultiSelect = false;
            this.SolutionGridView.Name = "SolutionGridView";
            this.SolutionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SolutionGridView.RowHeadersVisible = false;
            this.SolutionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SolutionGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionGridView.RowTemplate.Height = 40;
            this.SolutionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SolutionGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SolutionGridView_EditingControlShowing);
            this.SolutionGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SolutionGridView_RowsAdded);
            this.SolutionGridView.SelectionChanged += new System.EventHandler(this.SolutionGridView_SelectionChanged);
            // 
            // SolutionsLabel
            // 
            resources.ApplyResources(this.SolutionsLabel, "SolutionsLabel");
            this.SolutionsLabel.Name = "SolutionsLabel";
            // 
            // SolutionDelBtn
            // 
            resources.ApplyResources(this.SolutionDelBtn, "SolutionDelBtn");
            this.SolutionDelBtn.Name = "SolutionDelBtn";
            this.SolutionDelBtn.UseVisualStyleBackColor = true;
            this.SolutionDelBtn.Click += new System.EventHandler(this.SolutionDelBtn_Click);
            // 
            // SolutionAddBtn
            // 
            resources.ApplyResources(this.SolutionAddBtn, "SolutionAddBtn");
            this.SolutionAddBtn.Name = "SolutionAddBtn";
            this.SolutionAddBtn.UseVisualStyleBackColor = true;
            this.SolutionAddBtn.Click += new System.EventHandler(this.SolutionAddBtn_Click);
            // 
            // ComponentsGridView
            // 
            this.ComponentsGridView.AllowUserToAddRows = false;
            this.ComponentsGridView.AllowUserToDeleteRows = false;
            this.ComponentsGridView.AllowUserToResizeColumns = false;
            this.ComponentsGridView.AllowUserToResizeRows = false;
            this.ComponentsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ComponentsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            resources.ApplyResources(this.ComponentsGridView, "ComponentsGridView");
            this.ComponentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ComponentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComIdColumn,
            this.SolIdColumn,
            this.ComNameColumn,
            this.ComAmountColumn,
            this.ComIsMainColumn});
            this.ComponentsGridView.EnableHeadersVisualStyles = false;
            this.ComponentsGridView.MultiSelect = false;
            this.ComponentsGridView.Name = "ComponentsGridView";
            this.ComponentsGridView.ReadOnly = true;
            this.ComponentsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ComponentsGridView.RowHeadersVisible = false;
            this.ComponentsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ComponentsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentsGridView.RowTemplate.Height = 40;
            this.ComponentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComponentsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ComponentsGridView_RowsAdded);
            this.ComponentsGridView.SelectionChanged += new System.EventHandler(this.ComponentsGridView_SelectionChanged);
            // 
            // ComponentsLabel
            // 
            resources.ApplyResources(this.ComponentsLabel, "ComponentsLabel");
            this.ComponentsLabel.Name = "ComponentsLabel";
            // 
            // ComponentDelBtn
            // 
            resources.ApplyResources(this.ComponentDelBtn, "ComponentDelBtn");
            this.ComponentDelBtn.Name = "ComponentDelBtn";
            this.ComponentDelBtn.UseVisualStyleBackColor = true;
            this.ComponentDelBtn.Click += new System.EventHandler(this.ComponentDelBtn_Click);
            // 
            // ComponentAddBtn
            // 
            resources.ApplyResources(this.ComponentAddBtn, "ComponentAddBtn");
            this.ComponentAddBtn.Name = "ComponentAddBtn";
            this.ComponentAddBtn.UseVisualStyleBackColor = true;
            this.ComponentAddBtn.Click += new System.EventHandler(this.ComponentAddBtn_Click);
            // 
            // SolutionIdColumn
            // 
            this.SolutionIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.SolutionIdColumn, "SolutionIdColumn");
            this.SolutionIdColumn.Name = "SolutionIdColumn";
            this.SolutionIdColumn.ReadOnly = true;
            // 
            // SolutionNameColumn
            // 
            this.SolutionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SolutionNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.SolutionNameColumn, "SolutionNameColumn");
            this.SolutionNameColumn.MaxInputLength = 128;
            this.SolutionNameColumn.Name = "SolutionNameColumn";
            // 
            // SolutionVolumeColumn
            // 
            this.SolutionVolumeColumn.DataPropertyName = "Volume";
            resources.ApplyResources(this.SolutionVolumeColumn, "SolutionVolumeColumn");
            this.SolutionVolumeColumn.MaxInputLength = 9;
            this.SolutionVolumeColumn.Name = "SolutionVolumeColumn";
            // 
            // ComIdColumn
            // 
            this.ComIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.ComIdColumn, "ComIdColumn");
            this.ComIdColumn.Name = "ComIdColumn";
            this.ComIdColumn.ReadOnly = true;
            // 
            // SolIdColumn
            // 
            this.SolIdColumn.DataPropertyName = "SolutionId";
            resources.ApplyResources(this.SolIdColumn, "SolIdColumn");
            this.SolIdColumn.Name = "SolIdColumn";
            this.SolIdColumn.ReadOnly = true;
            // 
            // ComNameColumn
            // 
            this.ComNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComNameColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.ComNameColumn, "ComNameColumn");
            this.ComNameColumn.MaxInputLength = 128;
            this.ComNameColumn.Name = "ComNameColumn";
            this.ComNameColumn.ReadOnly = true;
            // 
            // ComAmountColumn
            // 
            this.ComAmountColumn.DataPropertyName = "Percent";
            resources.ApplyResources(this.ComAmountColumn, "ComAmountColumn");
            this.ComAmountColumn.MaxInputLength = 5;
            this.ComAmountColumn.Name = "ComAmountColumn";
            this.ComAmountColumn.ReadOnly = true;
            // 
            // ComIsMainColumn
            // 
            this.ComIsMainColumn.DataPropertyName = "IsMain";
            resources.ApplyResources(this.ComIsMainColumn, "ComIsMainColumn");
            this.ComIsMainColumn.Name = "ComIsMainColumn";
            this.ComIsMainColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ComponentAddBtn);
            this.Controls.Add(this.ComponentDelBtn);
            this.Controls.Add(this.ComponentsLabel);
            this.Controls.Add(this.ComponentsGridView);
            this.Controls.Add(this.SolutionAddBtn);
            this.Controls.Add(this.SolutionDelBtn);
            this.Controls.Add(this.SolutionsLabel);
            this.Controls.Add(this.SolutionGridView);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UpdateBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.DataGridView SolutionGridView;
        private System.Windows.Forms.Label SolutionsLabel;
        private System.Windows.Forms.Button SolutionDelBtn;
        private System.Windows.Forms.Button SolutionAddBtn;
        private System.Windows.Forms.DataGridView ComponentsGridView;
        private System.Windows.Forms.Label ComponentsLabel;
        private System.Windows.Forms.Button ComponentDelBtn;
        private System.Windows.Forms.Button ComponentAddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionVolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComIsMainColumn;
    }
}

