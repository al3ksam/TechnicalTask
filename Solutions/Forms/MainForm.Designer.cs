
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
            this.DeleteSolutionBtn = new System.Windows.Forms.Button();
            this.SolutionAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).BeginInit();
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
            this.SolutionName.Name = "SolutionName";
            // 
            // SolutionVolume
            // 
            this.SolutionVolume.DataPropertyName = "Volume";
            resources.ApplyResources(this.SolutionVolume, "SolutionVolume");
            this.SolutionVolume.Name = "SolutionVolume";
            // 
            // SolutionsLabel
            // 
            resources.ApplyResources(this.SolutionsLabel, "SolutionsLabel");
            this.SolutionsLabel.Name = "SolutionsLabel";
            // 
            // DeleteSolutionBtn
            // 
            resources.ApplyResources(this.DeleteSolutionBtn, "DeleteSolutionBtn");
            this.DeleteSolutionBtn.Name = "DeleteSolutionBtn";
            this.DeleteSolutionBtn.UseVisualStyleBackColor = true;
            this.DeleteSolutionBtn.Click += new System.EventHandler(this.DeleteSolutionBtn_Click);
            // 
            // SolutionAddBtn
            // 
            resources.ApplyResources(this.SolutionAddBtn, "SolutionAddBtn");
            this.SolutionAddBtn.Name = "SolutionAddBtn";
            this.SolutionAddBtn.UseVisualStyleBackColor = true;
            this.SolutionAddBtn.Click += new System.EventHandler(this.SolutionAddBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.SolutionAddBtn);
            this.Controls.Add(this.DeleteSolutionBtn);
            this.Controls.Add(this.SolutionsLabel);
            this.Controls.Add(this.SolutionGridView);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UpdateBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.SolutionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.DataGridView SolutionGridView;
        private System.Windows.Forms.Label SolutionsLabel;
        private System.Windows.Forms.Button DeleteSolutionBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolutionVolume;
        private System.Windows.Forms.Button SolutionAddBtn;
    }
}

