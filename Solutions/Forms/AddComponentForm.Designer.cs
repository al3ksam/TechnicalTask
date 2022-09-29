
namespace Solutions.Forms
{
    partial class AddComponentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComponentForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "CancelBtn");
            this.cancelBtn.Name = "CancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.addBtn, "AddBtn");
            this.addBtn.Name = "AddBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AmountNumeric
            // 
            this.amountNumeric.DecimalPlaces = 1;
            resources.ApplyResources(this.amountNumeric, "AmountNumeric");
            this.amountNumeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            65536});
            this.amountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountNumeric.Name = "AmountNumeric";
            this.amountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountLabel
            // 
            resources.ApplyResources(this.amountLabel, "AmountLabel");
            this.amountLabel.Name = "AmountLabel";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "NameTextBox");
            this.nameTextBox.Name = "NameTextBox";
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.nameLabel, "NameLabel");
            this.nameLabel.Name = "NameLabel";
            // 
            // AddComponentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddComponentForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}