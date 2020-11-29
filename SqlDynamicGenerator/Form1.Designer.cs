namespace SqlDynamicGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProcessSuppliersByNameButton = new System.Windows.Forms.Button();
            this.SuppliersNamesListBox = new System.Windows.Forms.ListBox();
            this.SuppliersNameResultsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuppliersIdsResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuppliersIdsListBox = new System.Windows.Forms.ListBox();
            this.ProcessSuppliersByIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HardCodedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessSuppliersByNameButton
            // 
            this.ProcessSuppliersByNameButton.Location = new System.Drawing.Point(8, 130);
            this.ProcessSuppliersByNameButton.Name = "ProcessSuppliersByNameButton";
            this.ProcessSuppliersByNameButton.Size = new System.Drawing.Size(150, 23);
            this.ProcessSuppliersByNameButton.TabIndex = 0;
            this.ProcessSuppliersByNameButton.Text = "Process suppliers names";
            this.ProcessSuppliersByNameButton.UseVisualStyleBackColor = true;
            this.ProcessSuppliersByNameButton.Click += new System.EventHandler(this.ProcessSuppliersByNameButton_Click);
            // 
            // SuppliersNamesListBox
            // 
            this.SuppliersNamesListBox.FormattingEnabled = true;
            this.SuppliersNamesListBox.Location = new System.Drawing.Point(8, 24);
            this.SuppliersNamesListBox.Name = "SuppliersNamesListBox";
            this.SuppliersNamesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SuppliersNamesListBox.Size = new System.Drawing.Size(150, 95);
            this.SuppliersNamesListBox.TabIndex = 1;
            // 
            // SuppliersNameResultsTextBox
            // 
            this.SuppliersNameResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuppliersNameResultsTextBox.Location = new System.Drawing.Point(10, 161);
            this.SuppliersNameResultsTextBox.Name = "SuppliersNameResultsTextBox";
            this.SuppliersNameResultsTextBox.Size = new System.Drawing.Size(456, 20);
            this.SuppliersNameResultsTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SuppliersNameResultsTextBox);
            this.groupBox1.Controls.Add(this.SuppliersNamesListBox);
            this.groupBox1.Controls.Add(this.ProcessSuppliersByNameButton);
            this.groupBox1.Location = new System.Drawing.Point(4, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By supplier names";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SuppliersIdsResultsTextBox);
            this.groupBox2.Controls.Add(this.SuppliersIdsListBox);
            this.groupBox2.Controls.Add(this.ProcessSuppliersByIdButton);
            this.groupBox2.Location = new System.Drawing.Point(4, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 192);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By supplier names";
            // 
            // SuppliersIdsResultsTextBox
            // 
            this.SuppliersIdsResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuppliersIdsResultsTextBox.Location = new System.Drawing.Point(10, 161);
            this.SuppliersIdsResultsTextBox.Name = "SuppliersIdsResultsTextBox";
            this.SuppliersIdsResultsTextBox.Size = new System.Drawing.Size(456, 20);
            this.SuppliersIdsResultsTextBox.TabIndex = 2;
            // 
            // SuppliersIdsListBox
            // 
            this.SuppliersIdsListBox.FormattingEnabled = true;
            this.SuppliersIdsListBox.Location = new System.Drawing.Point(8, 24);
            this.SuppliersIdsListBox.Name = "SuppliersIdsListBox";
            this.SuppliersIdsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SuppliersIdsListBox.Size = new System.Drawing.Size(150, 95);
            this.SuppliersIdsListBox.TabIndex = 1;
            // 
            // ProcessSuppliersByIdButton
            // 
            this.ProcessSuppliersByIdButton.Location = new System.Drawing.Point(8, 130);
            this.ProcessSuppliersByIdButton.Name = "ProcessSuppliersByIdButton";
            this.ProcessSuppliersByIdButton.Size = new System.Drawing.Size(150, 23);
            this.ProcessSuppliersByIdButton.TabIndex = 0;
            this.ProcessSuppliersByIdButton.Text = "Process suppliers ids";
            this.ProcessSuppliersByIdButton.UseVisualStyleBackColor = true;
            this.ProcessSuppliersByIdButton.Click += new System.EventHandler(this.ProcessSuppliersByIdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make sure to test generated sql in SSMS or run in Visual Studio using a .sql file" +
    "";
            // 
            // HardCodedButton
            // 
            this.HardCodedButton.Location = new System.Drawing.Point(16, 457);
            this.HardCodedButton.Name = "HardCodedButton";
            this.HardCodedButton.Size = new System.Drawing.Size(146, 23);
            this.HardCodedButton.TabIndex = 7;
            this.HardCodedButton.Text = "Hard coded";
            this.HardCodedButton.UseVisualStyleBackColor = true;
            this.HardCodedButton.Click += new System.EventHandler(this.HardCodedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 509);
            this.Controls.Add(this.HardCodedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Where in generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessSuppliersByNameButton;
        private System.Windows.Forms.ListBox SuppliersNamesListBox;
        private System.Windows.Forms.TextBox SuppliersNameResultsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SuppliersIdsResultsTextBox;
        private System.Windows.Forms.ListBox SuppliersIdsListBox;
        private System.Windows.Forms.Button ProcessSuppliersByIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HardCodedButton;
    }
}

