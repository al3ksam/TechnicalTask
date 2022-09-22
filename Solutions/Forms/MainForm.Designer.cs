
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
            this._updateBtn = new System.Windows.Forms.Button();
            this._saveBtn = new System.Windows.Forms.Button();
            this._settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _updateBtn
            // 
            resources.ApplyResources(this._updateBtn, "_updateBtn");
            this._updateBtn.Name = "_updateBtn";
            this._updateBtn.UseVisualStyleBackColor = true;
            this._updateBtn.Click += new System.EventHandler(this._updateBtn_Click);
            // 
            // _saveBtn
            // 
            resources.ApplyResources(this._saveBtn, "_saveBtn");
            this._saveBtn.Name = "_saveBtn";
            this._saveBtn.UseVisualStyleBackColor = true;
            // 
            // _settingsBtn
            // 
            resources.ApplyResources(this._settingsBtn, "_settingsBtn");
            this._settingsBtn.Name = "_settingsBtn";
            this._settingsBtn.UseVisualStyleBackColor = true;
            this._settingsBtn.Click += new System.EventHandler(this._settingsBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._settingsBtn);
            this.Controls.Add(this._saveBtn);
            this.Controls.Add(this._updateBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _updateBtn;
        private System.Windows.Forms.Button _saveBtn;
        private System.Windows.Forms.Button _settingsBtn;
    }
}

