namespace SingletonExample1
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
            this.GetDatabaseButton = new System.Windows.Forms.Button();
            this.DatabasePathTextBox = new System.Windows.Forms.TextBox();
            this.SetDatabasePathButton = new System.Windows.Forms.Button();
            this.OpenChildForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetDatabaseButton
            // 
            this.GetDatabaseButton.Location = new System.Drawing.Point(12, 12);
            this.GetDatabaseButton.Name = "GetDatabaseButton";
            this.GetDatabaseButton.Size = new System.Drawing.Size(150, 23);
            this.GetDatabaseButton.TabIndex = 0;
            this.GetDatabaseButton.Text = "Get database";
            this.GetDatabaseButton.UseVisualStyleBackColor = true;
            this.GetDatabaseButton.Click += new System.EventHandler(this.GetDatabaseButton_Click);
            // 
            // DatabasePathTextBox
            // 
            this.DatabasePathTextBox.Location = new System.Drawing.Point(12, 41);
            this.DatabasePathTextBox.Name = "DatabasePathTextBox";
            this.DatabasePathTextBox.Size = new System.Drawing.Size(366, 20);
            this.DatabasePathTextBox.TabIndex = 1;
            // 
            // SetDatabasePathButton
            // 
            this.SetDatabasePathButton.Location = new System.Drawing.Point(228, 12);
            this.SetDatabasePathButton.Name = "SetDatabasePathButton";
            this.SetDatabasePathButton.Size = new System.Drawing.Size(150, 23);
            this.SetDatabasePathButton.TabIndex = 2;
            this.SetDatabasePathButton.Text = "Set database";
            this.SetDatabasePathButton.UseVisualStyleBackColor = true;
            this.SetDatabasePathButton.Click += new System.EventHandler(this.SetDatabasePathButton_Click);
            // 
            // OpenChildForm
            // 
            this.OpenChildForm.Location = new System.Drawing.Point(124, 78);
            this.OpenChildForm.Name = "OpenChildForm";
            this.OpenChildForm.Size = new System.Drawing.Size(150, 23);
            this.OpenChildForm.TabIndex = 3;
            this.OpenChildForm.Text = "Open Child form";
            this.OpenChildForm.UseVisualStyleBackColor = true;
            this.OpenChildForm.Click += new System.EventHandler(this.OpenChildForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 117);
            this.Controls.Add(this.OpenChildForm);
            this.Controls.Add(this.SetDatabasePathButton);
            this.Controls.Add(this.DatabasePathTextBox);
            this.Controls.Add(this.GetDatabaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singleton code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDatabaseButton;
        private System.Windows.Forms.TextBox DatabasePathTextBox;
        private System.Windows.Forms.Button SetDatabasePathButton;
        private System.Windows.Forms.Button OpenChildForm;
    }
}

