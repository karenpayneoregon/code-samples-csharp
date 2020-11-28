namespace NuGetPackageHelpers.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PackagesListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackageComboBox = new System.Windows.Forms.ComboBox();
            this.CheckVersioningButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProcessSelectSolutionButton = new System.Windows.Forms.Button();
            this.ProcessCurrentSolutionButton = new System.Windows.Forms.Button();
            this.ExportToWebPageButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.SolutionFolderLabel = new System.Windows.Forms.Label();
            this.ReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VersionCountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VersionCountLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.PackagesListView);
            this.panel1.Controls.Add(this.PackageComboBox);
            this.panel1.Controls.Add(this.CheckVersioningButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 411);
            this.panel1.TabIndex = 2;
            // 
            // PackagesListView
            // 
            this.PackagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.PackagesListView.HideSelection = false;
            this.PackagesListView.Location = new System.Drawing.Point(17, 164);
            this.PackagesListView.Name = "PackagesListView";
            this.PackagesListView.Size = new System.Drawing.Size(459, 235);
            this.PackagesListView.TabIndex = 8;
            this.PackagesListView.UseCompatibleStateImageBehavior = false;
            this.PackagesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            // 
            // PackageComboBox
            // 
            this.PackageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackageComboBox.DropDownWidth = 350;
            this.PackageComboBox.FormattingEnabled = true;
            this.PackageComboBox.Location = new System.Drawing.Point(16, 122);
            this.PackageComboBox.Name = "PackageComboBox";
            this.PackageComboBox.Size = new System.Drawing.Size(189, 21);
            this.PackageComboBox.TabIndex = 7;
            // 
            // CheckVersioningButton
            // 
            this.CheckVersioningButton.Location = new System.Drawing.Point(211, 120);
            this.CheckVersioningButton.Name = "CheckVersioningButton";
            this.CheckVersioningButton.Size = new System.Drawing.Size(123, 23);
            this.CheckVersioningButton.TabIndex = 6;
            this.CheckVersioningButton.Text = "Check versions";
            this.CheckVersioningButton.UseVisualStyleBackColor = true;
            this.CheckVersioningButton.Click += new System.EventHandler(this.CheckVersioningButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProjectTypeComboBox);
            this.groupBox1.Controls.Add(this.ProcessSelectSolutionButton);
            this.groupBox1.Controls.Add(this.ProcessCurrentSolutionButton);
            this.groupBox1.Controls.Add(this.ExportToWebPageButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ProjectTypeComboBox
            // 
            this.ProjectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectTypeComboBox.FormattingEnabled = true;
            this.ProjectTypeComboBox.Location = new System.Drawing.Point(10, 70);
            this.ProjectTypeComboBox.Name = "ProjectTypeComboBox";
            this.ProjectTypeComboBox.Size = new System.Drawing.Size(183, 21);
            this.ProjectTypeComboBox.TabIndex = 3;
            // 
            // ProcessSelectSolutionButton
            // 
            this.ProcessSelectSolutionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessSelectSolutionButton.Image = global::NuGetPackageHelpers.Properties.Resources.SolutionFolderSwitch_16x;
            this.ProcessSelectSolutionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProcessSelectSolutionButton.Location = new System.Drawing.Point(10, 41);
            this.ProcessSelectSolutionButton.Name = "ProcessSelectSolutionButton";
            this.ProcessSelectSolutionButton.Size = new System.Drawing.Size(440, 23);
            this.ProcessSelectSolutionButton.TabIndex = 2;
            this.ProcessSelectSolutionButton.Text = "Select a solution";
            this.ProcessSelectSolutionButton.UseVisualStyleBackColor = true;
            this.ProcessSelectSolutionButton.Click += new System.EventHandler(this.ProcessSelectSolutionButton_Click);
            // 
            // ProcessCurrentSolutionButton
            // 
            this.ProcessCurrentSolutionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessCurrentSolutionButton.Image = global::NuGetPackageHelpers.Properties.Resources.Process_16x;
            this.ProcessCurrentSolutionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProcessCurrentSolutionButton.Location = new System.Drawing.Point(10, 12);
            this.ProcessCurrentSolutionButton.Name = "ProcessCurrentSolutionButton";
            this.ProcessCurrentSolutionButton.Size = new System.Drawing.Size(440, 23);
            this.ProcessCurrentSolutionButton.TabIndex = 0;
            this.ProcessCurrentSolutionButton.Text = "Process current solution";
            this.ProcessCurrentSolutionButton.UseVisualStyleBackColor = true;
            this.ProcessCurrentSolutionButton.Click += new System.EventHandler(this.ProcessCurrentSolutionButton_Click);
            // 
            // ExportToWebPageButton
            // 
            this.ExportToWebPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportToWebPageButton.Enabled = false;
            this.ExportToWebPageButton.Image = global::NuGetPackageHelpers.Properties.Resources.Web_16x;
            this.ExportToWebPageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportToWebPageButton.Location = new System.Drawing.Point(302, 68);
            this.ExportToWebPageButton.Name = "ExportToWebPageButton";
            this.ExportToWebPageButton.Size = new System.Drawing.Size(148, 23);
            this.ExportToWebPageButton.TabIndex = 1;
            this.ExportToWebPageButton.Text = "Export as web page";
            this.ExportToWebPageButton.UseVisualStyleBackColor = true;
            this.ExportToWebPageButton.Click += new System.EventHandler(this.ExportToWebPageButtonButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 202);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Information";
            this.columnHeader1.Width = 420;
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.Location = new System.Drawing.Point(19, 223);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(45, 13);
            this.SolutionLabel.TabIndex = 4;
            this.SolutionLabel.Text = "Solution";
            // 
            // SolutionFolderLabel
            // 
            this.SolutionFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolutionFolderLabel.AutoSize = true;
            this.SolutionFolderLabel.Location = new System.Drawing.Point(19, 210);
            this.SolutionFolderLabel.Name = "SolutionFolderLabel";
            this.SolutionFolderLabel.Size = new System.Drawing.Size(36, 13);
            this.SolutionFolderLabel.TabIndex = 5;
            this.SolutionFolderLabel.Text = "Folder";
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(353, 122);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(123, 23);
            this.ReportButton.TabIndex = 9;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Version count";
            // 
            // VersionCountLabel
            // 
            this.VersionCountLabel.AutoSize = true;
            this.VersionCountLabel.Location = new System.Drawing.Point(291, 148);
            this.VersionCountLabel.Name = "VersionCountLabel";
            this.VersionCountLabel.Size = new System.Drawing.Size(25, 13);
            this.VersionCountLabel.TabIndex = 11;
            this.VersionCountLabel.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 650);
            this.Controls.Add(this.SolutionFolderLabel);
            this.Controls.Add(this.SolutionLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuGet package list";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessCurrentSolutionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button ExportToWebPageButton;
        private System.Windows.Forms.Button ProcessSelectSolutionButton;
        private System.Windows.Forms.ComboBox ProjectTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SolutionLabel;
        private System.Windows.Forms.Label SolutionFolderLabel;
        private System.Windows.Forms.Button CheckVersioningButton;
        private System.Windows.Forms.ComboBox PackageComboBox;
        private System.Windows.Forms.ListView PackagesListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Label VersionCountLabel;
        private System.Windows.Forms.Label label1;
    }
}

