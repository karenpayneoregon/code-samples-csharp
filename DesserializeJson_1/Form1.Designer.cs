namespace DesserializeJson_1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReadOrdersButton1 = new System.Windows.Forms.Button();
            this.ReadOrdersButton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deserialize json to html";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // ReadOrdersButton1
            // 
            this.ReadOrdersButton1.Location = new System.Drawing.Point(27, 111);
            this.ReadOrdersButton1.Name = "ReadOrdersButton1";
            this.ReadOrdersButton1.Size = new System.Drawing.Size(258, 23);
            this.ReadOrdersButton1.TabIndex = 4;
            this.ReadOrdersButton1.Text = "Read orders 1";
            this.ReadOrdersButton1.UseVisualStyleBackColor = true;
            this.ReadOrdersButton1.Click += new System.EventHandler(this.ReadOrdersButton1_Click);
            // 
            // ReadOrdersButton2
            // 
            this.ReadOrdersButton2.Location = new System.Drawing.Point(27, 140);
            this.ReadOrdersButton2.Name = "ReadOrdersButton2";
            this.ReadOrdersButton2.Size = new System.Drawing.Size(258, 23);
            this.ReadOrdersButton2.TabIndex = 5;
            this.ReadOrdersButton2.Text = "Read orders 2";
            this.ReadOrdersButton2.UseVisualStyleBackColor = true;
            this.ReadOrdersButton2.Click += new System.EventHandler(this.ReadOrdersButton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReadOrdersButton2);
            this.Controls.Add(this.ReadOrdersButton1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReadOrdersButton1;
        private System.Windows.Forms.Button ReadOrdersButton2;
        private System.Windows.Forms.Button button3;
    }
}

