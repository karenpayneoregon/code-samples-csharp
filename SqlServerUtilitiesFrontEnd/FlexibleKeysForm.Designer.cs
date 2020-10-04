namespace SqlServerUtilitiesFrontEnd
{
    partial class FlexibleKeysForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TableNameListBox = new System.Windows.Forms.ListBox();
            this.ConstraintTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table names";
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.Location = new System.Drawing.Point(15, 34);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(204, 134);
            this.TableNameListBox.TabIndex = 3;
            // 
            // ConstraintTypeComboBox
            // 
            this.ConstraintTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConstraintTypeComboBox.FormattingEnabled = true;
            this.ConstraintTypeComboBox.Location = new System.Drawing.Point(15, 207);
            this.ConstraintTypeComboBox.Name = "ConstraintTypeComboBox";
            this.ConstraintTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.ConstraintTypeComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Constraint type";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(242, 34);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(342, 131);
            this.ResultsTextBox.TabIndex = 7;
            // 
            // FlexibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 258);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConstraintTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FlexibleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flexible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TableNameListBox;
        private System.Windows.Forms.ComboBox ConstraintTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultsTextBox;
    }
}