namespace SingletonExample1
{
    partial class ChildForm
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
            this.SetDatabasePathButton = new System.Windows.Forms.Button();
            this.DatabasePathTextBox = new System.Windows.Forms.TextBox();
            this.GetDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetDatabasePathButton
            // 
            this.SetDatabasePathButton.Location = new System.Drawing.Point(249, 20);
            this.SetDatabasePathButton.Name = "SetDatabasePathButton";
            this.SetDatabasePathButton.Size = new System.Drawing.Size(150, 23);
            this.SetDatabasePathButton.TabIndex = 5;
            this.SetDatabasePathButton.Text = "Set database";
            this.SetDatabasePathButton.UseVisualStyleBackColor = true;
            this.SetDatabasePathButton.Click += new System.EventHandler(this.SetDatabasePathButton_Click);
            // 
            // DatabasePathTextBox
            // 
            this.DatabasePathTextBox.Location = new System.Drawing.Point(33, 49);
            this.DatabasePathTextBox.Name = "DatabasePathTextBox";
            this.DatabasePathTextBox.Size = new System.Drawing.Size(366, 20);
            this.DatabasePathTextBox.TabIndex = 4;
            // 
            // GetDatabaseButton
            // 
            this.GetDatabaseButton.Location = new System.Drawing.Point(33, 20);
            this.GetDatabaseButton.Name = "GetDatabaseButton";
            this.GetDatabaseButton.Size = new System.Drawing.Size(150, 23);
            this.GetDatabaseButton.TabIndex = 3;
            this.GetDatabaseButton.Text = "Get database";
            this.GetDatabaseButton.UseVisualStyleBackColor = true;
            this.GetDatabaseButton.Click += new System.EventHandler(this.GetDatabaseButton_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 88);
            this.Controls.Add(this.SetDatabasePathButton);
            this.Controls.Add(this.DatabasePathTextBox);
            this.Controls.Add(this.GetDatabaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetDatabasePathButton;
        private System.Windows.Forms.TextBox DatabasePathTextBox;
        private System.Windows.Forms.Button GetDatabaseButton;
    }
}