namespace GitHubRepositoryExamples.Forms
{
    partial class CreateDownloadBatchForm
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
            this.ProjectCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectProjectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectCheckedListBox
            // 
            this.ProjectCheckedListBox.FormattingEnabled = true;
            this.ProjectCheckedListBox.Location = new System.Drawing.Point(15, 10);
            this.ProjectCheckedListBox.Name = "ProjectCheckedListBox";
            this.ProjectCheckedListBox.Size = new System.Drawing.Size(319, 244);
            this.ProjectCheckedListBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Close_8x_16x;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(214, 272);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectProjectsButton
            // 
            this.SelectProjectsButton.Image = global::GitHubRepositoryExamples.Properties.Resources.ExportFile_16x;
            this.SelectProjectsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectProjectsButton.Location = new System.Drawing.Point(15, 272);
            this.SelectProjectsButton.Name = "SelectProjectsButton";
            this.SelectProjectsButton.Size = new System.Drawing.Size(120, 23);
            this.SelectProjectsButton.TabIndex = 1;
            this.SelectProjectsButton.Text = "Process selected";
            this.SelectProjectsButton.UseVisualStyleBackColor = true;
            this.SelectProjectsButton.Click += new System.EventHandler(this.SelectProjectsButton_Click);
            // 
            // CreateDownloadBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 306);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectProjectsButton);
            this.Controls.Add(this.ProjectCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateDownloadBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create batch file";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProjectCheckedListBox;
        private System.Windows.Forms.Button SelectProjectsButton;
        private System.Windows.Forms.Button CancelButton;
    }
}