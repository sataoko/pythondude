using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PythonDude
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PythonPath = txtPythonPath.Text;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtPythonPath.Text = Properties.Settings.Default.PythonPath;
        }
    }
}
