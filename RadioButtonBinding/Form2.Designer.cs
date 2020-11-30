namespace RadioButtonBinding
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeopleNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SuffixRadioGroupBox = new RadioButtonBinding.RadioGroupBox();
            this.MissRadioButton = new System.Windows.Forms.RadioButton();
            this.MrsRadioButton = new System.Windows.Forms.RadioButton();
            this.MrRadioButton = new System.Windows.Forms.RadioButton();
            this.InspectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNavigator)).BeginInit();
            this.PeopleNavigator.SuspendLayout();
            this.SuffixRadioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(221, 107);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(221, 58);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First";
            // 
            // PeopleNavigator
            // 
            this.PeopleNavigator.AddNewItem = null;
            this.PeopleNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PeopleNavigator.DeleteItem = null;
            this.PeopleNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.PeopleNavigator.Location = new System.Drawing.Point(0, 0);
            this.PeopleNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PeopleNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PeopleNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PeopleNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PeopleNavigator.Name = "PeopleNavigator";
            this.PeopleNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PeopleNavigator.Size = new System.Drawing.Size(344, 25);
            this.PeopleNavigator.TabIndex = 11;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SuffixRadioGroupBox
            // 
            this.SuffixRadioGroupBox.Controls.Add(this.MissRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrsRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrRadioButton);
            this.SuffixRadioGroupBox.Location = new System.Drawing.Point(12, 42);
            this.SuffixRadioGroupBox.Name = "SuffixRadioGroupBox";
            this.SuffixRadioGroupBox.Selected = 0;
            this.SuffixRadioGroupBox.Size = new System.Drawing.Size(184, 61);
            this.SuffixRadioGroupBox.TabIndex = 12;
            this.SuffixRadioGroupBox.TabStop = false;
            this.SuffixRadioGroupBox.Text = "Suffix";
            // 
            // MissRadioButton
            // 
            this.MissRadioButton.AutoSize = true;
            this.MissRadioButton.Location = new System.Drawing.Point(113, 24);
            this.MissRadioButton.Name = "MissRadioButton";
            this.MissRadioButton.Size = new System.Drawing.Size(46, 17);
            this.MissRadioButton.TabIndex = 2;
            this.MissRadioButton.TabStop = true;
            this.MissRadioButton.Tag = "";
            this.MissRadioButton.Text = "Miss";
            this.MissRadioButton.UseVisualStyleBackColor = true;
            // 
            // MrsRadioButton
            // 
            this.MrsRadioButton.AutoSize = true;
            this.MrsRadioButton.Location = new System.Drawing.Point(65, 24);
            this.MrsRadioButton.Name = "MrsRadioButton";
            this.MrsRadioButton.Size = new System.Drawing.Size(42, 17);
            this.MrsRadioButton.TabIndex = 1;
            this.MrsRadioButton.TabStop = true;
            this.MrsRadioButton.Tag = "";
            this.MrsRadioButton.Text = "Mrs";
            this.MrsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MrRadioButton
            // 
            this.MrRadioButton.AutoSize = true;
            this.MrRadioButton.Location = new System.Drawing.Point(13, 24);
            this.MrRadioButton.Name = "MrRadioButton";
            this.MrRadioButton.Size = new System.Drawing.Size(37, 17);
            this.MrRadioButton.TabIndex = 0;
            this.MrRadioButton.TabStop = true;
            this.MrRadioButton.Tag = "";
            this.MrRadioButton.Text = "Mr";
            this.MrRadioButton.UseVisualStyleBackColor = true;
            // 
            // InspectButton
            // 
            this.InspectButton.Location = new System.Drawing.Point(19, 118);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(75, 23);
            this.InspectButton.TabIndex = 13;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = true;
            this.InspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 149);
            this.Controls.Add(this.InspectButton);
            this.Controls.Add(this.SuffixRadioGroupBox);
            this.Controls.Add(this.PeopleNavigator);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data bind three radio buttons";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNavigator)).EndInit();
            this.PeopleNavigator.ResumeLayout(false);
            this.PeopleNavigator.PerformLayout();
            this.SuffixRadioGroupBox.ResumeLayout(false);
            this.SuffixRadioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator PeopleNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private RadioGroupBox SuffixRadioGroupBox;
        private System.Windows.Forms.RadioButton MissRadioButton;
        private System.Windows.Forms.RadioButton MrsRadioButton;
        private System.Windows.Forms.RadioButton MrRadioButton;
        private System.Windows.Forms.Button InspectButton;
    }
}