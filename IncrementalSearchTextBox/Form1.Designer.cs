
namespace IncrementalSearchTextBox
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
            this.GirlsNameListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GirlsNameListBox
            // 
            this.GirlsNameListBox.FormattingEnabled = true;
            this.GirlsNameListBox.Location = new System.Drawing.Point(31, 34);
            this.GirlsNameListBox.Name = "GirlsNameListBox";
            this.GirlsNameListBox.Size = new System.Drawing.Size(166, 225);
            this.GirlsNameListBox.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(31, 265);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(166, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(31, 291);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(166, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 332);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.GirlsNameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GirlsNameListBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button CurrentButton;
    }
}

