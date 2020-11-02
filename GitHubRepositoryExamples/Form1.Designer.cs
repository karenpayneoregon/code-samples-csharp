namespace GitHubRepositoryExamples
{
    partial class Form1
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
            this.ParseLocalFileButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.RepoDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParseLocalFileButton
            // 
            this.ParseLocalFileButton.Location = new System.Drawing.Point(21, 33);
            this.ParseLocalFileButton.Name = "ParseLocalFileButton";
            this.ParseLocalFileButton.Size = new System.Drawing.Size(222, 23);
            this.ParseLocalFileButton.TabIndex = 0;
            this.ParseLocalFileButton.Text = "Parse local json";
            this.ParseLocalFileButton.UseVisualStyleBackColor = true;
            this.ParseLocalFileButton.Click += new System.EventHandler(this.ParseLocalFileButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(21, 62);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(222, 23);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download test";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // RepoDetailsButton
            // 
            this.RepoDetailsButton.Location = new System.Drawing.Point(22, 100);
            this.RepoDetailsButton.Name = "RepoDetailsButton";
            this.RepoDetailsButton.Size = new System.Drawing.Size(222, 23);
            this.RepoDetailsButton.TabIndex = 2;
            this.RepoDetailsButton.Text = "Repo details";
            this.RepoDetailsButton.UseVisualStyleBackColor = true;
            this.RepoDetailsButton.Click += new System.EventHandler(this.RepoDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 188);
            this.Controls.Add(this.RepoDetailsButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.ParseLocalFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub stuff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParseLocalFileButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button RepoDetailsButton;
    }
}

