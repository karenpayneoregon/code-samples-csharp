namespace NorthWindForEntityFrameworkFrontEnt6
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
            this.TraverseButton = new System.Windows.Forms.Button();
            this.ModelDetailsButton = new System.Windows.Forms.Button();
            this.NavigationsForModelButton = new System.Windows.Forms.Button();
            this.ModelNamesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NavigationListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TraverseButton
            // 
            this.TraverseButton.Location = new System.Drawing.Point(358, 41);
            this.TraverseButton.Name = "TraverseButton";
            this.TraverseButton.Size = new System.Drawing.Size(149, 23);
            this.TraverseButton.TabIndex = 0;
            this.TraverseButton.Text = "Traverse Orders";
            this.TraverseButton.UseVisualStyleBackColor = true;
            this.TraverseButton.Click += new System.EventHandler(this.TraverseButton_Click);
            // 
            // ModelDetailsButton
            // 
            this.ModelDetailsButton.Location = new System.Drawing.Point(358, 12);
            this.ModelDetailsButton.Name = "ModelDetailsButton";
            this.ModelDetailsButton.Size = new System.Drawing.Size(149, 23);
            this.ModelDetailsButton.TabIndex = 1;
            this.ModelDetailsButton.Text = "Model details";
            this.ModelDetailsButton.UseVisualStyleBackColor = true;
            this.ModelDetailsButton.Click += new System.EventHandler(this.ModelDetailsButton_Click);
            // 
            // NavigationsForModelButton
            // 
            this.NavigationsForModelButton.Location = new System.Drawing.Point(6, 211);
            this.NavigationsForModelButton.Name = "NavigationsForModelButton";
            this.NavigationsForModelButton.Size = new System.Drawing.Size(149, 23);
            this.NavigationsForModelButton.TabIndex = 2;
            this.NavigationsForModelButton.Text = "Navigations for model";
            this.NavigationsForModelButton.UseVisualStyleBackColor = true;
            this.NavigationsForModelButton.Click += new System.EventHandler(this.NavigationsForModelButton_Click);
            // 
            // ModelNamesListBox
            // 
            this.ModelNamesListBox.FormattingEnabled = true;
            this.ModelNamesListBox.Location = new System.Drawing.Point(6, 19);
            this.ModelNamesListBox.Name = "ModelNamesListBox";
            this.ModelNamesListBox.Size = new System.Drawing.Size(149, 186);
            this.ModelNamesListBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NavigationListBox);
            this.groupBox1.Controls.Add(this.ModelNamesListBox);
            this.groupBox1.Controls.Add(this.NavigationsForModelButton);
            this.groupBox1.Location = new System.Drawing.Point(32, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 253);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model navigations";
            // 
            // NavigationListBox
            // 
            this.NavigationListBox.FormattingEnabled = true;
            this.NavigationListBox.Location = new System.Drawing.Point(161, 19);
            this.NavigationListBox.Name = "NavigationListBox";
            this.NavigationListBox.Size = new System.Drawing.Size(149, 186);
            this.NavigationListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModelDetailsButton);
            this.Controls.Add(this.TraverseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework crawler";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TraverseButton;
        private System.Windows.Forms.Button ModelDetailsButton;
        private System.Windows.Forms.Button NavigationsForModelButton;
        private System.Windows.Forms.ListBox ModelNamesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox NavigationListBox;
    }
}

