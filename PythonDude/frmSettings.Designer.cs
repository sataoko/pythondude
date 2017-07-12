namespace PythonDude
{
    partial class frmSettings
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
            this.txtPythonPath = new System.Windows.Forms.TextBox();
            this.lblPythonPath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPythonPath
            // 
            this.txtPythonPath.Location = new System.Drawing.Point(110, 53);
            this.txtPythonPath.Name = "txtPythonPath";
            this.txtPythonPath.Size = new System.Drawing.Size(254, 20);
            this.txtPythonPath.TabIndex = 0;
            // 
            // lblPythonPath
            // 
            this.lblPythonPath.AutoSize = true;
            this.lblPythonPath.Location = new System.Drawing.Point(39, 56);
            this.lblPythonPath.Name = "lblPythonPath";
            this.lblPythonPath.Size = new System.Drawing.Size(65, 13);
            this.lblPythonPath.TabIndex = 1;
            this.lblPythonPath.Text = "Python Path";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 256);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPythonPath);
            this.Controls.Add(this.txtPythonPath);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPythonPath;
        private System.Windows.Forms.Label lblPythonPath;
        private System.Windows.Forms.Button btnSave;
    }
}