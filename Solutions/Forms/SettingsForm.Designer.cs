
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
            this.connectionBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.authMethodComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionBtn
            // 
            resources.ApplyResources(this.connectionBtn, "connectionBtn");
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.TabStop = false;
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.TabStop = false;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StatusStrip
            // 
            resources.ApplyResources(this.statusStrip, "StatusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Name = "StatusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // ToolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "ToolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "ToolStripStatusLabel");
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.serverNameTextBox);
            this.connectionPanel.Controls.Add(this.authMethodComboBox);
            this.connectionPanel.Controls.Add(this.authMethodLabel);
            this.connectionPanel.Controls.Add(this.serverNameLabel);
            this.connectionPanel.Controls.Add(this.userPanel);
            resources.ApplyResources(this.connectionPanel, "connectionPanel");
            this.connectionPanel.Name = "connectionPanel";
            // 
            // serverNameTextBox
            // 
            resources.ApplyResources(this.serverNameTextBox, "serverNameTextBox");
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.TextChanged += new System.EventHandler(this.ControlsValueChanged);
            // 
            // authMethodComboBox
            // 
            this.authMethodComboBox.DisplayMember = "0";
            this.authMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authMethodComboBox.FormattingEnabled = true;
            this.authMethodComboBox.Items.AddRange(new object[] {
            resources.GetString("authMethodComboBox.Items"),
            resources.GetString("authMethodComboBox.Items1")});
            resources.ApplyResources(this.authMethodComboBox, "authMethodComboBox");
            this.authMethodComboBox.Name = "authMethodComboBox";
            this.authMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthMethodComboBox_SelectedIndexChanged);
            // 
            // authMethodLabel
            // 
            resources.ApplyResources(this.authMethodLabel, "authMethodLabel");
            this.authMethodLabel.Name = "authMethodLabel";
            // 
            // serverNameLabel
            // 
            resources.ApplyResources(this.serverNameLabel, "serverNameLabel");
            this.serverNameLabel.Name = "serverNameLabel";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.usernameTextBox);
            this.userPanel.Controls.Add(this.passwordTextBox);
            this.userPanel.Controls.Add(this.passwordLabel);
            this.userPanel.Controls.Add(this.usernameLabel);
            resources.ApplyResources(this.userPanel, "userPanel");
            this.userPanel.Name = "userPanel";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.ControlsValueChanged);
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.separatorLabel, "separatorLabel");
            this.separatorLabel.Name = "separatorLabel";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.connectionPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.connectionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ComboBox authMethodComboBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label authMethodLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label separatorLabel;
    }
}