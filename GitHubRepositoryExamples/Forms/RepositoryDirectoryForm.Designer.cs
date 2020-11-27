namespace GitHubRepositoryDownloader.Forms
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
            this.CloseButton = new System.Windows.Forms.Button();
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
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseButton.Image = global::GitHubRepositoryDownloader.Properties.Resources.Close_8x_16x;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.Location = new System.Drawing.Point(254, 269);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(154, 23);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // RepositoryDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 314);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DirectoryNamesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepositoryDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repository Directories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DirectoryNamesListBox;
        private System.Windows.Forms.Button CloseButton;
    }
}