namespace PostBuildRemoveFolder
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
            this.ConfigurationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfigurationButton
            // 
            this.ConfigurationButton.Image = global::PostBuildRemoveFolder.Properties.Resources.Writeable_16x;
            this.ConfigurationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigurationButton.Location = new System.Drawing.Point(40, 50);
            this.ConfigurationButton.Name = "ConfigurationButton";
            this.ConfigurationButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ConfigurationButton.Size = new System.Drawing.Size(157, 23);
            this.ConfigurationButton.TabIndex = 0;
            this.ConfigurationButton.Text = "Configuration";
            this.ConfigurationButton.UseVisualStyleBackColor = true;
            this.ConfigurationButton.Click += new System.EventHandler(this.ConfigurationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 130);
            this.Controls.Add(this.ConfigurationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build events 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfigurationButton;
    }
}

