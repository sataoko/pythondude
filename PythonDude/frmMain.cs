using ICSharpCode.TextEditor.Document;
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
    public partial class frmMain : Form
    {
        private void AddCode(string code)
        {
            rtbCode.ActiveTextAreaControl.TextArea.InsertString(code);
        }

        private void RunPython(string args)
        {
            string s = DOSPrompt.CMDAutomate(args, Properties.Settings.Default.PythonPath);
            rtbConsole.Text = s;
        }

        private void LoadFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbCode.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                lblFileName.Text = openFileDialog1.FileName;
            }

        }

        private void SaveFile()
        {
            if(!string.IsNullOrEmpty(rtbCode.Text))
            System.IO.File.WriteAllText(lblFileName.Text, rtbCode.Text);
            // rtbCode.SaveFile(lblFileName.Text, RichTextBoxStreamType.PlainText);

        }

        private void SaveFileAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, rtbCode.Text);
                lblFileName.Text = saveFileDialog1.FileName;
            }

        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbRun_Click(object sender, EventArgs e)
        {
            RunPython("-c \"" + rtbCode.Text + "\"");
        }

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            FileSyntaxModeProvider fsmp = new FileSyntaxModeProvider(Application.StartupPath);

            HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
            rtbCode.SetHighlighting("Python");

            openFileDialog1.InitialDirectory = Application.StartupPath + "\\python_samples";


        }

        private void rtbCode_TextChanged(object sender, EventArgs e)
        {
            //          
        }

        #region ADDCODE

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCode("print()");
        }

        #endregion

        private void tsbSettings_Click(object sender, EventArgs e)
        {
            frmSettings x = new frmSettings();
            x.ShowDialog();
        }
    }
}
