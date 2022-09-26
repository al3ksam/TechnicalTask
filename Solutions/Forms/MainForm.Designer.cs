
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
            this.SolutionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolutionsLabel = new System.Windows.Forms.Label();
            this.SolutionDelBtn = new System.Windows.Forms.Button();
            this.SolutionAddBtn = new System.Windows.Forms.Button();
            this.ComponentsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SolutionId,
            this.SolutionName,
            this.SolutionVolume});
            this.SolutionGridView.EnableHeadersVisualStyles = false;
            this.SolutionGridView.MultiSelect = false;
            this.SolutionGridView.Name = "SolutionGridView";
            this.SolutionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SolutionGridView.RowHeadersVisible = false;
            this.SolutionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SolutionGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionGridView.RowTemplate.Height = 40;
            this.SolutionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SolutionGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.SolutionGridView_DataBindingComplete);
            this.SolutionGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.SolutionGridView_EditingControlShowing);
            this.SolutionGridView.SelectionChanged += new System.EventHandler(this.SolutionGridView_SelectionChanged);
            // 
            // SolutionId
            // 
            this.SolutionId.DataPropertyName = "Id";
            resources.ApplyResources(this.SolutionId, "SolutionId");
            this.SolutionId.Name = "SolutionId";
            this.SolutionId.ReadOnly = true;
            // 
            // SolutionName
            // 
            this.SolutionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SolutionName.DataPropertyName = "Name";
            resources.ApplyResources(this.SolutionName, "SolutionName");
            this.SolutionName.MaxInputLength = 128;
            this.SolutionName.Name = "SolutionName";
            // 
            // SolutionVolume
            // 
            this.SolutionVolume.DataPropertyName = "Volume";
            resources.ApplyResources(this.SolutionVolume, "SolutionVolume");
            this.SolutionVolume.MaxInputLength = 9;
            this.SolutionVolume.Name = "SolutionVolume";
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
            this.dataGridViewTextBoxColumn1,
            this.SolId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.IsMain});
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
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SolId
            // 
            this.SolId.DataPropertyName = "SolutionId";
            resources.ApplyResources(this.SolId, "SolId");
            this.SolId.Name = "SolId";
            this.SolId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.MaxInputLength = 128;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Percent";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // IsMain
            // 
            this.IsMain.DataPropertyName = "IsMain";
            resources.ApplyResources(this.IsMain, "IsMain");
            this.IsMain.Name = "IsMain";
            this.IsMain.ReadOnly = true;
            // 
            // ComponentsLabel
            // 
            resources.ApplyResources(this.ComponentsLabel, "ComponentsLabel");
            this.ComponentsLabel.Name = "ComponentsLabel";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionVolume;
        private System.Windows.Forms.DataGridView ComponentsGridView;
        private System.Windows.Forms.Label ComponentsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMain;
    }
}

