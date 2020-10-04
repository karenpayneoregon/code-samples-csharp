namespace IEqualityComparerApp
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
            this.CustomerByNameCountryCityComparerButton = new System.Windows.Forms.Button();
            this.NameSurnameEqualityComparerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerByNameCountryCityComparerButton
            // 
            this.CustomerByNameCountryCityComparerButton.Location = new System.Drawing.Point(21, 25);
            this.CustomerByNameCountryCityComparerButton.Name = "CustomerByNameCountryCityComparerButton";
            this.CustomerByNameCountryCityComparerButton.Size = new System.Drawing.Size(224, 23);
            this.CustomerByNameCountryCityComparerButton.TabIndex = 0;
            this.CustomerByNameCountryCityComparerButton.Text = "Customer By Name Country City Comparer";
            this.CustomerByNameCountryCityComparerButton.UseVisualStyleBackColor = true;
            this.CustomerByNameCountryCityComparerButton.Click += new System.EventHandler(this.CustomerByNameCountryCityComparerButton_Click);
            // 
            // NameSurnameEqualityComparerButton
            // 
            this.NameSurnameEqualityComparerButton.Location = new System.Drawing.Point(21, 66);
            this.NameSurnameEqualityComparerButton.Name = "NameSurnameEqualityComparerButton";
            this.NameSurnameEqualityComparerButton.Size = new System.Drawing.Size(224, 23);
            this.NameSurnameEqualityComparerButton.TabIndex = 1;
            this.NameSurnameEqualityComparerButton.Text = "Name Surname Equality Comparer";
            this.NameSurnameEqualityComparerButton.UseVisualStyleBackColor = true;
            this.NameSurnameEqualityComparerButton.Click += new System.EventHandler(this.NameSurnameEqualityComparerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Results appear in the IDE output window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameSurnameEqualityComparerButton);
            this.Controls.Add(this.CustomerByNameCountryCityComparerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code samples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerByNameCountryCityComparerButton;
        private System.Windows.Forms.Button NameSurnameEqualityComparerButton;
        private System.Windows.Forms.Label label1;
    }
}

