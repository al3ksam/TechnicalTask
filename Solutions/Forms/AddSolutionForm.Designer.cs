
namespace Solutions.Forms
{
    partial class AddSolutionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSolutionForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.nameLabel, "NameLabel");
            this.nameLabel.Name = "NameLabel";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "NameTextBox");
            this.nameTextBox.Name = "NameTextBox";
            // 
            // VolumeLabel
            // 
            resources.ApplyResources(this.volumeLabel, "VolumeLabel");
            this.volumeLabel.Name = "VolumeLabel";
            // 
            // VolumeNumeric
            // 
            resources.ApplyResources(this.volumeNumeric, "VolumeNumeric");
            this.volumeNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.volumeNumeric.Name = "VolumeNumeric";
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.addBtn, "AddBtn");
            this.addBtn.Name = "AddBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "CancelBtn");
            this.cancelBtn.Name = "CancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddSolutionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.volumeNumeric);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSolutionForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.NumericUpDown volumeNumeric;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}