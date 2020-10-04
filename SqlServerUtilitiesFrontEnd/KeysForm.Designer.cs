namespace SqlServerUtilitiesFrontEnd
{
    partial class KeysForm
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
            this.TableNameListBox = new System.Windows.Forms.ListBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetCustomersForeignConstraintsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.Location = new System.Drawing.Point(23, 34);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(204, 134);
            this.TableNameListBox.TabIndex = 0;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(248, 34);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(247, 131);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Foriegn key names";
            // 
            // GetCustomersForeignConstraintsButton
            // 
            this.GetCustomersForeignConstraintsButton.Location = new System.Drawing.Point(23, 197);
            this.GetCustomersForeignConstraintsButton.Name = "GetCustomersForeignConstraintsButton";
            this.GetCustomersForeignConstraintsButton.Size = new System.Drawing.Size(204, 23);
            this.GetCustomersForeignConstraintsButton.TabIndex = 4;
            this.GetCustomersForeignConstraintsButton.Text = "Get Customers FK\'s";
            this.GetCustomersForeignConstraintsButton.UseVisualStyleBackColor = true;
            this.GetCustomersForeignConstraintsButton.Click += new System.EventHandler(this.GetCustomersForeignConstraintsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 237);
            this.Controls.Add(this.GetCustomersForeignConstraintsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.TableNameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get constraints for database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TableNameListBox;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetCustomersForeignConstraintsButton;
    }
}

