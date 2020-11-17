namespace DataGridViewCombo1
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DisplayInformationTextBox = new System.Windows.Forms.TextBox();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownColumnRight1 = new DataGridViewCombo1.Controls.NumericUpDownColumnRight();
            this.ItemTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.QtyNumericUpDownColumn = new DataGridViewCombo1.Controls.NumericUpDownColumnRight();
            this.InCartCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VendorComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.DisplayInformationTextBox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 187);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(563, 64);
            this.Panel1.TabIndex = 2;
            // 
            // DisplayInformationTextBox
            // 
            this.DisplayInformationTextBox.Location = new System.Drawing.Point(12, 20);
            this.DisplayInformationTextBox.Name = "DisplayInformationTextBox";
            this.DisplayInformationTextBox.Size = new System.Drawing.Size(539, 20);
            this.DisplayInformationTextBox.TabIndex = 3;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemTextBoxColumn,
            this.ColorComboBoxColumn,
            this.QtyNumericUpDownColumn,
            this.InCartCheckBoxColumn,
            this.VendorComboBoxColumn});
            this.CustomersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(563, 187);
            this.CustomersDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numericUpDownColumnRight1
            // 
            this.numericUpDownColumnRight1.DecimalPlaces = 2;
            this.numericUpDownColumnRight1.HeaderText = "Qty";
            this.numericUpDownColumnRight1.Name = "numericUpDownColumnRight1";
            // 
            // ItemTextBoxColumn
            // 
            this.ItemTextBoxColumn.HeaderText = "Item";
            this.ItemTextBoxColumn.Name = "ItemTextBoxColumn";
            // 
            // ColorComboBoxColumn
            // 
            this.ColorComboBoxColumn.HeaderText = "Color";
            this.ColorComboBoxColumn.Name = "ColorComboBoxColumn";
            this.ColorComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QtyNumericUpDownColumn
            // 
            this.QtyNumericUpDownColumn.DecimalPlaces = 2;
            this.QtyNumericUpDownColumn.HeaderText = "Qty";
            this.QtyNumericUpDownColumn.Name = "QtyNumericUpDownColumn";
            // 
            // InCartCheckBoxColumn
            // 
            this.InCartCheckBoxColumn.HeaderText = "Cart";
            this.InCartCheckBoxColumn.Name = "InCartCheckBoxColumn";
            // 
            // VendorComboBoxColumn
            // 
            this.VendorComboBoxColumn.HeaderText = "Vendor";
            this.VendorComboBoxColumn.Name = "VendorComboBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 251);
            this.Controls.Add(this.CustomersDataGridView);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo/Special number column sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridView CustomersDataGridView;
        private Controls.NumericUpDownColumnRight numericUpDownColumnRight1;
        private System.Windows.Forms.TextBox DisplayInformationTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColorComboBoxColumn;
        private Controls.NumericUpDownColumnRight QtyNumericUpDownColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InCartCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn VendorComboBoxColumn;
    }
}

