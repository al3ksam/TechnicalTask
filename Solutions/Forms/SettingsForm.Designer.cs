
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
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AuthMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.AuthMethodLabel = new System.Windows.Forms.Label();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionBtn
            // 
            resources.ApplyResources(this.ConnectionBtn, "ConnectionBtn");
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StatusStrip
            // 
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.SizingGrip = false;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            resources.ApplyResources(this.ToolStripStatusLabel, "ToolStripStatusLabel");
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.UserPanel);
            this.ConnectionPanel.Controls.Add(this.AuthMethodComboBox);
            this.ConnectionPanel.Controls.Add(this.ServerNameTextBox);
            this.ConnectionPanel.Controls.Add(this.AuthMethodLabel);
            this.ConnectionPanel.Controls.Add(this.ServerNameLabel);
            resources.ApplyResources(this.ConnectionPanel, "ConnectionPanel");
            this.ConnectionPanel.Name = "ConnectionPanel";
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.PasswordTextBox);
            this.UserPanel.Controls.Add(this.UsernameTextBox);
            this.UserPanel.Controls.Add(this.PasswordLabel);
            this.UserPanel.Controls.Add(this.UsernameLabel);
            resources.ApplyResources(this.UserPanel, "UserPanel");
            this.UserPanel.Name = "UserPanel";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            resources.ApplyResources(this.UsernameTextBox, "UsernameTextBox");
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // AuthMethodComboBox
            // 
            this.AuthMethodComboBox.DisplayMember = "0";
            this.AuthMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthMethodComboBox.FormattingEnabled = true;
            this.AuthMethodComboBox.Items.AddRange(new object[] {
            resources.GetString("AuthMethodComboBox.Items"),
            resources.GetString("AuthMethodComboBox.Items1")});
            resources.ApplyResources(this.AuthMethodComboBox, "AuthMethodComboBox");
            this.AuthMethodComboBox.Name = "AuthMethodComboBox";
            this.AuthMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthMethodComboBox_SelectedIndexChanged);
            // 
            // ServerNameTextBox
            // 
            resources.ApplyResources(this.ServerNameTextBox, "ServerNameTextBox");
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // AuthMethodLabel
            // 
            resources.ApplyResources(this.AuthMethodLabel, "AuthMethodLabel");
            this.AuthMethodLabel.Name = "AuthMethodLabel";
            // 
            // ServerNameLabel
            // 
            resources.ApplyResources(this.ServerNameLabel, "ServerNameLabel");
            this.ServerNameLabel.Name = "ServerNameLabel";
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.SeparatorLabel, "SeparatorLabel");
            this.SeparatorLabel.Name = "SeparatorLabel";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ConnectionPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SeparatorLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConnectionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ComboBox AuthMethodComboBox;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label AuthMethodLabel;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.Label SeparatorLabel;
    }
}