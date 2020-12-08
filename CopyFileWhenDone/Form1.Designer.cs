namespace CopyFileWhenDone
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
            this.components = new System.ComponentModel.Container();
            this.CopyFileNoDelayButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CopyFileWithDelayButton = new System.Windows.Forms.Button();
            this.numericTextBox1 = new WorkingWithTimeUsingMovies.Classes.NumericTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CopyFileNoDelayButton
            // 
            this.CopyFileNoDelayButton.Location = new System.Drawing.Point(12, 12);
            this.CopyFileNoDelayButton.Name = "CopyFileNoDelayButton";
            this.CopyFileNoDelayButton.Size = new System.Drawing.Size(118, 23);
            this.CopyFileNoDelayButton.TabIndex = 0;
            this.CopyFileNoDelayButton.Text = "Copy file no delay";
            this.CopyFileNoDelayButton.UseVisualStyleBackColor = true;
            this.CopyFileNoDelayButton.Click += new System.EventHandler(this.CopyFileNoDelayButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(670, 82);
            this.listBox1.TabIndex = 2;
            // 
            // CopyFileWithDelayButton
            // 
            this.CopyFileWithDelayButton.Location = new System.Drawing.Point(136, 12);
            this.CopyFileWithDelayButton.Name = "CopyFileWithDelayButton";
            this.CopyFileWithDelayButton.Size = new System.Drawing.Size(118, 23);
            this.CopyFileWithDelayButton.TabIndex = 3;
            this.CopyFileWithDelayButton.Text = "Copy file with delay";
            this.CopyFileWithDelayButton.UseVisualStyleBackColor = true;
            this.CopyFileWithDelayButton.Click += new System.EventHandler(this.CopyFileWithDelayButton_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(260, 12);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 4;
            this.numericTextBox1.Text = "1000";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(377, 9);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 157);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.CopyFileWithDelayButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CopyFileNoDelayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyFileNoDelayButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CopyFileWithDelayButton;
        private WorkingWithTimeUsingMovies.Classes.NumericTextBox numericTextBox1;
        private System.Windows.Forms.Button CancelButton;
    }
}

