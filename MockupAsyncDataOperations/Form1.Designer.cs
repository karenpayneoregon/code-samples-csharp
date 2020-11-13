namespace MockupAsyncDataOperations
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
            this.RunProcessButton = new System.Windows.Forms.Button();
            this.CancelProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunProcessButton
            // 
            this.RunProcessButton.Location = new System.Drawing.Point(29, 22);
            this.RunProcessButton.Name = "RunProcessButton";
            this.RunProcessButton.Size = new System.Drawing.Size(116, 23);
            this.RunProcessButton.TabIndex = 0;
            this.RunProcessButton.Text = "Run process";
            this.RunProcessButton.UseVisualStyleBackColor = true;
            this.RunProcessButton.Click += new System.EventHandler(this.RunProcessButton_Click);
            // 
            // CancelProcessButton
            // 
            this.CancelProcessButton.Location = new System.Drawing.Point(151, 22);
            this.CancelProcessButton.Name = "CancelProcessButton";
            this.CancelProcessButton.Size = new System.Drawing.Size(116, 23);
            this.CancelProcessButton.TabIndex = 1;
            this.CancelProcessButton.Text = "Cancel process";
            this.CancelProcessButton.UseVisualStyleBackColor = true;
            this.CancelProcessButton.Click += new System.EventHandler(this.CancelProcessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 81);
            this.Controls.Add(this.CancelProcessButton);
            this.Controls.Add(this.RunProcessButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mockup data operation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunProcessButton;
        private System.Windows.Forms.Button CancelProcessButton;
    }
}

