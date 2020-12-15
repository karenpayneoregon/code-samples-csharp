namespace PersonalData
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
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MvpCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateAddedTextBox = new System.Windows.Forms.TextBox();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Image = global::PersonalData.Properties.Resources.JSONFile_16x;
            this.DeserializeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeserializeButton.Location = new System.Drawing.Point(15, 120);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(243, 23);
            this.DeserializeButton.TabIndex = 0;
            this.DeserializeButton.Text = "Deserialize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display name";
            // 
            // DisplayNameTextBox
            // 
            this.DisplayNameTextBox.Location = new System.Drawing.Point(15, 25);
            this.DisplayNameTextBox.Name = "DisplayNameTextBox";
            this.DisplayNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.DisplayNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MVP";
            // 
            // MvpCheckBox
            // 
            this.MvpCheckBox.AutoSize = true;
            this.MvpCheckBox.Location = new System.Drawing.Point(232, 25);
            this.MvpCheckBox.Name = "MvpCheckBox";
            this.MvpCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MvpCheckBox.TabIndex = 4;
            this.MvpCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date added";
            // 
            // DateAddedTextBox
            // 
            this.DateAddedTextBox.Location = new System.Drawing.Point(15, 78);
            this.DateAddedTextBox.Name = "DateAddedTextBox";
            this.DateAddedTextBox.Size = new System.Drawing.Size(194, 20);
            this.DateAddedTextBox.TabIndex = 6;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(301, 21);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(125, 121);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePictureBox.TabIndex = 7;
            this.ProfilePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 178);
            this.Controls.Add(this.ProfilePictureBox);
            this.Controls.Add(this.DateAddedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MvpCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeserializeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q&A Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DisplayNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MvpCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DateAddedTextBox;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
    }
}

