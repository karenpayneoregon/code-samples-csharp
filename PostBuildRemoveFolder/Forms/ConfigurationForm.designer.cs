namespace PostBuildRemoveFolder.Forms
{
    partial class ConfigurationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPdfDocumentPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcelFileName = new System.Windows.Forms.TextBox();
            this.cmdSelectDestimationPath = new System.Windows.Forms.Button();
            this.cmdSelectPdfPath = new System.Windows.Forms.Button();
            this.cmdSelectExcelFile = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSelectWorkSheet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkLoadOnStartUp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy file to path";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(125, 25);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(347, 20);
            this.txtDestinationPath.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtDestinationPath, "Where to copy PDF files too");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PDF document path";
            // 
            // txtPdfDocumentPath
            // 
            this.txtPdfDocumentPath.Location = new System.Drawing.Point(125, 55);
            this.txtPdfDocumentPath.Name = "txtPdfDocumentPath";
            this.txtPdfDocumentPath.Size = new System.Drawing.Size(347, 20);
            this.txtPdfDocumentPath.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPdfDocumentPath, "Location of PDF documents to check against Excel file");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Excel File name";
            // 
            // txtExcelFileName
            // 
            this.txtExcelFileName.Location = new System.Drawing.Point(125, 81);
            this.txtExcelFileName.Name = "txtExcelFileName";
            this.txtExcelFileName.Size = new System.Drawing.Size(347, 20);
            this.txtExcelFileName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtExcelFileName, "Excel path and file name to work with.");
            // 
            // cmdSelectDestimationPath
            // 
            this.cmdSelectDestimationPath.Location = new System.Drawing.Point(478, 24);
            this.cmdSelectDestimationPath.Name = "cmdSelectDestimationPath";
            this.cmdSelectDestimationPath.Size = new System.Drawing.Size(26, 20);
            this.cmdSelectDestimationPath.TabIndex = 7;
            this.cmdSelectDestimationPath.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectDestimationPath, "Select path");
            this.cmdSelectDestimationPath.UseVisualStyleBackColor = true;
            this.cmdSelectDestimationPath.Click += new System.EventHandler(this.cmdSelectDestimationPath_Click);
            // 
            // cmdSelectPdfPath
            // 
            this.cmdSelectPdfPath.Location = new System.Drawing.Point(478, 55);
            this.cmdSelectPdfPath.Name = "cmdSelectPdfPath";
            this.cmdSelectPdfPath.Size = new System.Drawing.Size(26, 20);
            this.cmdSelectPdfPath.TabIndex = 8;
            this.cmdSelectPdfPath.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectPdfPath, "Select path");
            this.cmdSelectPdfPath.UseVisualStyleBackColor = true;
            this.cmdSelectPdfPath.Click += new System.EventHandler(this.cmdSelectPdfPath_Click);
            // 
            // cmdSelectExcelFile
            // 
            this.cmdSelectExcelFile.Location = new System.Drawing.Point(478, 81);
            this.cmdSelectExcelFile.Name = "cmdSelectExcelFile";
            this.cmdSelectExcelFile.Size = new System.Drawing.Size(26, 20);
            this.cmdSelectExcelFile.TabIndex = 9;
            this.cmdSelectExcelFile.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectExcelFile, "Select file name");
            this.cmdSelectExcelFile.UseVisualStyleBackColor = true;
            this.cmdSelectExcelFile.Click += new System.EventHandler(this.cmdSelectExcelFile_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.Location = new System.Drawing.Point(36, 171);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save";
            this.toolTip1.SetToolTip(this.cmdSave, "Save/update configuration");
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(426, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button2, "Cancel changes if save button has not been clicked");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(125, 107);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(347, 20);
            this.txtSheetName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSheetName, "Worksheet to obtain GUID from");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Excel Worksheet";
            // 
            // cmdSelectWorkSheet
            // 
            this.cmdSelectWorkSheet.Location = new System.Drawing.Point(478, 107);
            this.cmdSelectWorkSheet.Name = "cmdSelectWorkSheet";
            this.cmdSelectWorkSheet.Size = new System.Drawing.Size(26, 20);
            this.cmdSelectWorkSheet.TabIndex = 14;
            this.cmdSelectWorkSheet.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectWorkSheet, "Select worksheet");
            this.cmdSelectWorkSheet.UseVisualStyleBackColor = true;
            this.cmdSelectWorkSheet.Click += new System.EventHandler(this.cmdSelectWorkSheet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkLoadOnStartUp
            // 
            this.chkLoadOnStartUp.AutoSize = true;
            this.chkLoadOnStartUp.Location = new System.Drawing.Point(125, 133);
            this.chkLoadOnStartUp.Name = "chkLoadOnStartUp";
            this.chkLoadOnStartUp.Size = new System.Drawing.Size(15, 14);
            this.chkLoadOnStartUp.TabIndex = 4;
            this.toolTip1.SetToolTip(this.chkLoadOnStartUp, "Open current file at startup of program");
            this.chkLoadOnStartUp.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Load on startup";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkLoadOnStartUp);
            this.Controls.Add(this.cmdSelectWorkSheet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdSelectExcelFile);
            this.Controls.Add(this.cmdSelectPdfPath);
            this.Controls.Add(this.cmdSelectDestimationPath);
            this.Controls.Add(this.txtExcelFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPdfDocumentPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPdfDocumentPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExcelFileName;
        private System.Windows.Forms.Button cmdSelectDestimationPath;
        private System.Windows.Forms.Button cmdSelectPdfPath;
        private System.Windows.Forms.Button cmdSelectExcelFile;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSelectWorkSheet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkLoadOnStartUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}