
namespace Solutions.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this._serverNameLabel = new System.Windows.Forms.Label();
            this._authMethodLabel = new System.Windows.Forms.Label();
            this._serverNameTextBox = new System.Windows.Forms.TextBox();
            this._authMethodComboBox = new System.Windows.Forms.ComboBox();
            this._userPanel = new System.Windows.Forms.Panel();
            this._savePwdCheckBox = new System.Windows.Forms.CheckBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._usernameTextBox = new System.Windows.Forms.TextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._testConnectionBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._separatorLabel = new System.Windows.Forms.Label();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._userPanel.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _serverNameLabel
            // 
            resources.ApplyResources(this._serverNameLabel, "_serverNameLabel");
            this._serverNameLabel.Name = "_serverNameLabel";
            // 
            // _authMethodLabel
            // 
            resources.ApplyResources(this._authMethodLabel, "_authMethodLabel");
            this._authMethodLabel.Name = "_authMethodLabel";
            // 
            // _serverNameTextBox
            // 
            resources.ApplyResources(this._serverNameTextBox, "_serverNameTextBox");
            this._serverNameTextBox.Name = "_serverNameTextBox";
            // 
            // _authMethodComboBox
            // 
            this._authMethodComboBox.DisplayMember = "0";
            this._authMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._authMethodComboBox.FormattingEnabled = true;
            this._authMethodComboBox.Items.AddRange(new object[] {
            resources.GetString("_authMethodComboBox.Items"),
            resources.GetString("_authMethodComboBox.Items1")});
            resources.ApplyResources(this._authMethodComboBox, "_authMethodComboBox");
            this._authMethodComboBox.Name = "_authMethodComboBox";
            this._authMethodComboBox.SelectedIndexChanged += new System.EventHandler(this._authMethodComboBox_SelectedIndexChanged);
            // 
            // _userPanel
            // 
            this._userPanel.Controls.Add(this._savePwdCheckBox);
            this._userPanel.Controls.Add(this._passwordTextBox);
            this._userPanel.Controls.Add(this._usernameTextBox);
            this._userPanel.Controls.Add(this._passwordLabel);
            this._userPanel.Controls.Add(this._usernameLabel);
            resources.ApplyResources(this._userPanel, "_userPanel");
            this._userPanel.Name = "_userPanel";
            // 
            // _savePwdCheckBox
            // 
            resources.ApplyResources(this._savePwdCheckBox, "_savePwdCheckBox");
            this._savePwdCheckBox.Name = "_savePwdCheckBox";
            this._savePwdCheckBox.UseVisualStyleBackColor = true;
            // 
            // _passwordTextBox
            // 
            resources.ApplyResources(this._passwordTextBox, "_passwordTextBox");
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.UseSystemPasswordChar = true;
            // 
            // _usernameTextBox
            // 
            resources.ApplyResources(this._usernameTextBox, "_usernameTextBox");
            this._usernameTextBox.Name = "_usernameTextBox";
            // 
            // _passwordLabel
            // 
            resources.ApplyResources(this._passwordLabel, "_passwordLabel");
            this._passwordLabel.Name = "_passwordLabel";
            // 
            // _usernameLabel
            // 
            resources.ApplyResources(this._usernameLabel, "_usernameLabel");
            this._usernameLabel.Name = "_usernameLabel";
            // 
            // _testConnectionBtn
            // 
            resources.ApplyResources(this._testConnectionBtn, "_testConnectionBtn");
            this._testConnectionBtn.Name = "_testConnectionBtn";
            this._testConnectionBtn.UseVisualStyleBackColor = true;
            this._testConnectionBtn.Click += new System.EventHandler(this._testConnectionBtn_Click);
            // 
            // _cancelBtn
            // 
            resources.ApplyResources(this._cancelBtn, "_cancelBtn");
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // _separatorLabel
            // 
            this._separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this._separatorLabel, "_separatorLabel");
            this._separatorLabel.Name = "_separatorLabel";
            // 
            // _statusStrip
            // 
            resources.ApplyResources(this._statusStrip, "_statusStrip");
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripStatusLabel});
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.SizingGrip = false;
            // 
            // _toolStripStatusLabel
            // 
            this._toolStripStatusLabel.Name = "_toolStripStatusLabel";
            resources.ApplyResources(this._toolStripStatusLabel, "_toolStripStatusLabel");
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._separatorLabel);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._testConnectionBtn);
            this.Controls.Add(this._userPanel);
            this.Controls.Add(this._authMethodComboBox);
            this.Controls.Add(this._serverNameTextBox);
            this.Controls.Add(this._authMethodLabel);
            this.Controls.Add(this._serverNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this._userPanel.ResumeLayout(false);
            this._userPanel.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _serverNameLabel;
        private System.Windows.Forms.Label _authMethodLabel;
        private System.Windows.Forms.TextBox _serverNameTextBox;
        private System.Windows.Forms.ComboBox _authMethodComboBox;
        private System.Windows.Forms.Panel _userPanel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _usernameTextBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.CheckBox _savePwdCheckBox;
        private System.Windows.Forms.Button _testConnectionBtn;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.Label _separatorLabel;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _toolStripStatusLabel;
    }
}