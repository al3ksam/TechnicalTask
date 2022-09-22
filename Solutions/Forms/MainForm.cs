using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solutions.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _updateBtn_Click(object sender, EventArgs e)
        {
            Database db = Database.GetInstance();
            
            db.Connect("DESKTOP-NIGHT");

            Console.WriteLine(db.IsConnected);
        }

        private void _settingsBtn_Click(object sender, EventArgs e)
        {
            using(SettingsForm settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog();
            }
        }
    }
}
