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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RepositoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HtmlUrlTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.BrowseRepositoryButton = new System.Windows.Forms.Button();
            this.FetchRepositoriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RepositoryListBox
            // 
            this.RepositoryListBox.FormattingEnabled = true;
            this.RepositoryListBox.Location = new System.Drawing.Point(18, 18);
            this.RepositoryListBox.Name = "RepositoryListBox";
            this.RepositoryListBox.Size = new System.Drawing.Size(335, 355);
            this.RepositoryListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(375, 34);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(602, 20);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(902, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full name";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(375, 84);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(602, 20);
            this.FullNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // HtmlUrlTextBox
            // 
            this.HtmlUrlTextBox.Location = new System.Drawing.Point(375, 146);
            this.HtmlUrlTextBox.Name = "HtmlUrlTextBox";
            this.HtmlUrlTextBox.Size = new System.Drawing.Size(602, 20);
            this.HtmlUrlTextBox.TabIndex = 11;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(18, 379);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(335, 20);
            this.SearchTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Language";
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(375, 208);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(602, 20);
            this.LanguageTextBox.TabIndex = 15;
            // 
            // BrowseRepositoryButton
            // 
            this.BrowseRepositoryButton.Image = global::GitHubRepositoryExamples.Properties.Resources.Web_16x;
            this.BrowseRepositoryButton.Location = new System.Drawing.Point(983, 143);
            this.BrowseRepositoryButton.Name = "BrowseRepositoryButton";
            this.BrowseRepositoryButton.Size = new System.Drawing.Size(33, 23);
            this.BrowseRepositoryButton.TabIndex = 13;
            this.BrowseRepositoryButton.UseVisualStyleBackColor = true;
            this.BrowseRepositoryButton.Click += new System.EventHandler(this.BrowseRepositoryButton_Click);
            // 
            // FetchRepositoriesButton
            // 
            this.FetchRepositoriesButton.Image = global::GitHubRepositoryExamples.Properties.Resources.ASX_Run_blue_16x;
            this.FetchRepositoriesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FetchRepositoriesButton.Location = new System.Drawing.Point(375, 376);
            this.FetchRepositoriesButton.Name = "FetchRepositoriesButton";
            this.FetchRepositoriesButton.Size = new System.Drawing.Size(125, 23);
            this.FetchRepositoriesButton.TabIndex = 3;
            this.FetchRepositoriesButton.Text = "Fetch repositories";
            this.FetchRepositoriesButton.UseVisualStyleBackColor = true;
            this.FetchRepositoriesButton.Click += new System.EventHandler(this.FetchRepositoriesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 421);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseRepositoryButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.HtmlUrlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepositoryListBox);
            this.Controls.Add(this.FetchRepositoriesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FetchRepositoriesButton;
        private System.Windows.Forms.ListBox RepositoryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HtmlUrlTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button BrowseRepositoryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LanguageTextBox;
    }
}

