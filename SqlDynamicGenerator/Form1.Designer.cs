﻿namespace SqlDynamicGenerator
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
            this.CustomersDataTableButton = new System.Windows.Forms.Button();
            this.CustomerListButton = new System.Windows.Forms.Button();
            this.ProductListButton = new System.Windows.Forms.Button();
            this.DumpStatementsButton = new System.Windows.Forms.Button();
            this.DisplayFormattedSqlCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderDatesButton = new System.Windows.Forms.Button();
            this.OrdersResultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessSuppliersByNameButton
            // 
            this.ProcessSuppliersByNameButton.Location = new System.Drawing.Point(6, 95);
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
            this.SuppliersNamesListBox.Size = new System.Drawing.Size(150, 56);
            this.SuppliersNamesListBox.TabIndex = 1;
            // 
            // SuppliersNameResultsTextBox
            // 
            this.SuppliersNameResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuppliersNameResultsTextBox.Location = new System.Drawing.Point(6, 124);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 170);
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
            this.groupBox2.Location = new System.Drawing.Point(4, 222);
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
            // CustomersDataTableButton
            // 
            this.CustomersDataTableButton.Location = new System.Drawing.Point(15, 419);
            this.CustomersDataTableButton.Name = "CustomersDataTableButton";
            this.CustomersDataTableButton.Size = new System.Drawing.Size(192, 23);
            this.CustomersDataTableButton.TabIndex = 7;
            this.CustomersDataTableButton.Text = "Customers DataTable";
            this.CustomersDataTableButton.UseVisualStyleBackColor = true;
            this.CustomersDataTableButton.Click += new System.EventHandler(this.CustomersDataTableButtonButton_Click);
            // 
            // CustomerListButton
            // 
            this.CustomerListButton.Location = new System.Drawing.Point(15, 448);
            this.CustomerListButton.Name = "CustomerListButton";
            this.CustomerListButton.Size = new System.Drawing.Size(192, 23);
            this.CustomerListButton.TabIndex = 8;
            this.CustomerListButton.Text = "Customers list";
            this.CustomerListButton.UseVisualStyleBackColor = true;
            this.CustomerListButton.Click += new System.EventHandler(this.CustomerListButton_Click);
            // 
            // ProductListButton
            // 
            this.ProductListButton.Location = new System.Drawing.Point(15, 477);
            this.ProductListButton.Name = "ProductListButton";
            this.ProductListButton.Size = new System.Drawing.Size(192, 23);
            this.ProductListButton.TabIndex = 9;
            this.ProductListButton.Text = "Products List";
            this.ProductListButton.UseVisualStyleBackColor = true;
            this.ProductListButton.Click += new System.EventHandler(this.ProductListButton_Click);
            // 
            // DumpStatementsButton
            // 
            this.DumpStatementsButton.Location = new System.Drawing.Point(278, 477);
            this.DumpStatementsButton.Name = "DumpStatementsButton";
            this.DumpStatementsButton.Size = new System.Drawing.Size(192, 23);
            this.DumpStatementsButton.TabIndex = 10;
            this.DumpStatementsButton.Text = "Dump statements";
            this.DumpStatementsButton.UseVisualStyleBackColor = true;
            this.DumpStatementsButton.Click += new System.EventHandler(this.DumpStatementsButton_Click);
            // 
            // DisplayFormattedSqlCheckBox
            // 
            this.DisplayFormattedSqlCheckBox.AutoSize = true;
            this.DisplayFormattedSqlCheckBox.Location = new System.Drawing.Point(278, 425);
            this.DisplayFormattedSqlCheckBox.Name = "DisplayFormattedSqlCheckBox";
            this.DisplayFormattedSqlCheckBox.Size = new System.Drawing.Size(116, 17);
            this.DisplayFormattedSqlCheckBox.TabIndex = 11;
            this.DisplayFormattedSqlCheckBox.Text = "Show formatted sql";
            this.DisplayFormattedSqlCheckBox.UseVisualStyleBackColor = true;
            this.DisplayFormattedSqlCheckBox.CheckedChanged += new System.EventHandler(this.DisplayFormattedSqlCheckBox_CheckedChanged);
            // 
            // OrderDatesButton
            // 
            this.OrderDatesButton.Location = new System.Drawing.Point(15, 506);
            this.OrderDatesButton.Name = "OrderDatesButton";
            this.OrderDatesButton.Size = new System.Drawing.Size(189, 23);
            this.OrderDatesButton.TabIndex = 3;
            this.OrderDatesButton.Text = "Orders Date example";
            this.OrderDatesButton.UseVisualStyleBackColor = true;
            this.OrderDatesButton.Click += new System.EventHandler(this.OrderDatesButton_Click);
            // 
            // OrdersResultTextBox
            // 
            this.OrdersResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersResultTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersResultTextBox.Location = new System.Drawing.Point(14, 535);
            this.OrdersResultTextBox.Multiline = true;
            this.OrdersResultTextBox.Name = "OrdersResultTextBox";
            this.OrdersResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OrdersResultTextBox.Size = new System.Drawing.Size(456, 110);
            this.OrdersResultTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 657);
            this.Controls.Add(this.OrdersResultTextBox);
            this.Controls.Add(this.OrderDatesButton);
            this.Controls.Add(this.DisplayFormattedSqlCheckBox);
            this.Controls.Add(this.DumpStatementsButton);
            this.Controls.Add(this.ProductListButton);
            this.Controls.Add(this.CustomerListButton);
            this.Controls.Add(this.CustomersDataTableButton);
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
        private System.Windows.Forms.Button CustomersDataTableButton;
        private System.Windows.Forms.Button CustomerListButton;
        private System.Windows.Forms.Button ProductListButton;
        private System.Windows.Forms.Button DumpStatementsButton;
        private System.Windows.Forms.CheckBox DisplayFormattedSqlCheckBox;
        private System.Windows.Forms.Button OrderDatesButton;
        private System.Windows.Forms.TextBox OrdersResultTextBox;
    }
}

