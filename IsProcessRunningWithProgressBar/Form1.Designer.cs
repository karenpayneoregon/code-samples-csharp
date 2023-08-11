namespace IsProcessRunningWithProgressBar
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
            this.WatchProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.RunningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WatchProcessTimer
            // 
            this.WatchProcessTimer.Enabled = true;
            this.WatchProcessTimer.Tick += new System.EventHandler(this.WatchProcessTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(346, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // RunningLabel
            // 
            this.RunningLabel.AutoSize = true;
            this.RunningLabel.Location = new System.Drawing.Point(13, 107);
            this.RunningLabel.Name = "RunningLabel";
            this.RunningLabel.Size = new System.Drawing.Size(25, 13);
            this.RunningLabel.TabIndex = 2;
            this.RunningLabel.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 139);
            this.Controls.Add(this.RunningLabel);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch process with visual using ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WatchProcessTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label RunningLabel;
    }
}

