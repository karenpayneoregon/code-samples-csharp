namespace GitHubRepositoryExamples
{
    partial class RepositoryDirectoryForm
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
            this.DirectoryNamesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DirectoryNamesListBox
            // 
            this.DirectoryNamesListBox.FormattingEnabled = true;
            this.DirectoryNamesListBox.Location = new System.Drawing.Point(10, 8);
            this.DirectoryNamesListBox.Name = "DirectoryNamesListBox";
            this.DirectoryNamesListBox.Size = new System.Drawing.Size(400, 238);
            this.DirectoryNamesListBox.TabIndex = 0;
            // 
            // RepositoryDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 314);
            this.Controls.Add(this.DirectoryNamesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepositoryDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repository Directories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DirectoryNamesListBox;
    }
}