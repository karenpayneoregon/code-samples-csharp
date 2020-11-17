namespace GitHubRepositoryExamples.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RepositoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FoldersForSelectedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HtmlUrlTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StarGazersCountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RepoListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateDownLoadBatchFileButton = new System.Windows.Forms.Button();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.ProjectRecentCommitsButton = new System.Windows.Forms.Button();
            this.WorkingPictureBox = new System.Windows.Forms.PictureBox();
            this.BrowseRepositoryButton = new System.Windows.Forms.Button();
            this.FetchRepositoriesButton = new System.Windows.Forms.Button();
            this.RepositoryTextBox = new GitHubRepositoryExamples.Classes.NoBeepTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RepositoryListBox
            // 
            this.RepositoryListBox.FormattingEnabled = true;
            this.RepositoryListBox.Location = new System.Drawing.Point(18, 50);
            this.RepositoryListBox.Name = "RepositoryListBox";
            this.RepositoryListBox.Size = new System.Drawing.Size(335, 355);
            this.RepositoryListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(375, 66);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(602, 20);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // FoldersForSelectedButton
            // 
            this.FoldersForSelectedButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Folder_16x;
            this.FoldersForSelectedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoldersForSelectedButton.Location = new System.Drawing.Point(375, 368);
            this.FoldersForSelectedButton.Name = "FoldersForSelectedButton";
            this.FoldersForSelectedButton.Size = new System.Drawing.Size(174, 23);
            this.FoldersForSelectedButton.TabIndex = 7;
            this.FoldersForSelectedButton.Text = "Folder for selected";
            this.FoldersForSelectedButton.UseVisualStyleBackColor = true;
            this.FoldersForSelectedButton.Click += new System.EventHandler(this.FoldersForSelectedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full name";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(375, 116);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(602, 20);
            this.FullNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // HtmlUrlTextBox
            // 
            this.HtmlUrlTextBox.Location = new System.Drawing.Point(375, 171);
            this.HtmlUrlTextBox.Name = "HtmlUrlTextBox";
            this.HtmlUrlTextBox.Size = new System.Drawing.Size(602, 20);
            this.HtmlUrlTextBox.TabIndex = 11;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(18, 411);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(335, 20);
            this.SearchTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Language";
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(375, 224);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(602, 20);
            this.LanguageTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last updated";
            // 
            // LastUpdatedTextBox
            // 
            this.LastUpdatedTextBox.Location = new System.Drawing.Point(375, 270);
            this.LastUpdatedTextBox.Name = "LastUpdatedTextBox";
            this.LastUpdatedTextBox.Size = new System.Drawing.Size(138, 20);
            this.LastUpdatedTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stars count";
            // 
            // StarGazersCountTextBox
            // 
            this.StarGazersCountTextBox.Location = new System.Drawing.Point(375, 319);
            this.StarGazersCountTextBox.Name = "StarGazersCountTextBox";
            this.StarGazersCountTextBox.Size = new System.Drawing.Size(138, 20);
            this.StarGazersCountTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Repository";
            // 
            // RepoListContextMenu
            // 
            this.RepoListContextMenu.Name = "RepoListContextMenu";
            this.RepoListContextMenu.Size = new System.Drawing.Size(181, 26);
            // 
            // CreateDownLoadBatchFileButton
            // 
            this.CreateDownLoadBatchFileButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Download_16x;
            this.CreateDownLoadBatchFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateDownLoadBatchFileButton.Location = new System.Drawing.Point(555, 368);
            this.CreateDownLoadBatchFileButton.Name = "CreateDownLoadBatchFileButton";
            this.CreateDownLoadBatchFileButton.Size = new System.Drawing.Size(174, 23);
            this.CreateDownLoadBatchFileButton.TabIndex = 28;
            this.CreateDownLoadBatchFileButton.Text = "Create batch for  download";
            this.CreateDownLoadBatchFileButton.UseVisualStyleBackColor = true;
            this.CreateDownLoadBatchFileButton.Click += new System.EventHandler(this.CreateDownLoadBatchFileButton_Click);
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Close_8x_16x;
            this.CloseApplicationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseApplicationButton.Location = new System.Drawing.Point(842, 409);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(174, 23);
            this.CloseApplicationButton.TabIndex = 27;
            this.CloseApplicationButton.Text = "Close";
            this.CloseApplicationButton.UseVisualStyleBackColor = true;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButton_Click);
            // 
            // ProjectRecentCommitsButton
            // 
            this.ProjectRecentCommitsButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Commit_16x;
            this.ProjectRecentCommitsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProjectRecentCommitsButton.Location = new System.Drawing.Point(555, 411);
            this.ProjectRecentCommitsButton.Name = "ProjectRecentCommitsButton";
            this.ProjectRecentCommitsButton.Size = new System.Drawing.Size(174, 23);
            this.ProjectRecentCommitsButton.TabIndex = 25;
            this.ProjectRecentCommitsButton.Text = "Project recent commits";
            this.ProjectRecentCommitsButton.UseVisualStyleBackColor = true;
            this.ProjectRecentCommitsButton.Click += new System.EventHandler(this.ProjectRecentCommitsButton_Click);
            // 
            // WorkingPictureBox
            // 
            this.WorkingPictureBox.Location = new System.Drawing.Point(653, 270);
            this.WorkingPictureBox.Name = "WorkingPictureBox";
            this.WorkingPictureBox.Size = new System.Drawing.Size(67, 65);
            this.WorkingPictureBox.TabIndex = 24;
            this.WorkingPictureBox.TabStop = false;
            // 
            // BrowseRepositoryButton
            // 
            this.BrowseRepositoryButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Web_16x;
            this.BrowseRepositoryButton.Location = new System.Drawing.Point(983, 171);
            this.BrowseRepositoryButton.Name = "BrowseRepositoryButton";
            this.BrowseRepositoryButton.Size = new System.Drawing.Size(33, 23);
            this.BrowseRepositoryButton.TabIndex = 13;
            this.BrowseRepositoryButton.UseVisualStyleBackColor = true;
            this.BrowseRepositoryButton.Click += new System.EventHandler(this.BrowseRepositoryButton_Click);
            // 
            // FetchRepositoriesButton
            // 
            this.FetchRepositoriesButton.Image = global::GitHubRepositoryExamples.Properties.Resources.ASX_Run_blue_16x;
            this.FetchRepositoriesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FetchRepositoriesButton.Location = new System.Drawing.Point(375, 411);
            this.FetchRepositoriesButton.Name = "FetchRepositoriesButton";
            this.FetchRepositoriesButton.Size = new System.Drawing.Size(174, 23);
            this.FetchRepositoriesButton.TabIndex = 3;
            this.FetchRepositoriesButton.Text = "Fetch repositories";
            this.FetchRepositoriesButton.UseVisualStyleBackColor = true;
            this.FetchRepositoriesButton.Click += new System.EventHandler(this.FetchRepositoriesButton_Click);
            // 
            // RepositoryTextBox
            // 
            this.RepositoryTextBox.ContextMenuStrip = this.RepoListContextMenu;
            this.RepositoryTextBox.Location = new System.Drawing.Point(18, 26);
            this.RepositoryTextBox.Name = "RepositoryTextBox";
            this.RepositoryTextBox.Size = new System.Drawing.Size(335, 20);
            this.RepositoryTextBox.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 449);
            this.Controls.Add(this.CreateDownLoadBatchFileButton);
            this.Controls.Add(this.CloseApplicationButton);
            this.Controls.Add(this.ProjectRecentCommitsButton);
            this.Controls.Add(this.WorkingPictureBox);
            this.Controls.Add(this.RepositoryTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StarGazersCountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastUpdatedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseRepositoryButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.HtmlUrlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FoldersForSelectedButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepositoryListBox);
            this.Controls.Add(this.FetchRepositoriesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub stuff";
            ((System.ComponentModel.ISupportInitialize)(this.WorkingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FetchRepositoriesButton;
        private System.Windows.Forms.ListBox RepositoryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button FoldersForSelectedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HtmlUrlTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button BrowseRepositoryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LanguageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastUpdatedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StarGazersCountTextBox;
        private System.Windows.Forms.Label label7;
        private Classes.NoBeepTextBox RepositoryTextBox;
        private System.Windows.Forms.ContextMenuStrip RepoListContextMenu;
        private System.Windows.Forms.PictureBox WorkingPictureBox;
        private System.Windows.Forms.Button ProjectRecentCommitsButton;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Button CreateDownLoadBatchFileButton;
    }
}

