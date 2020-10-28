using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessCmdKeyExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Pick a key combination to toggle the CheckBox
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Alt | Keys.Space))
            {
                checkBox1.Checked = !checkBox1.Checked;
                return true;
            }

            if (keyData == Keys.Tab)
            {
                if (ActiveControl.Name == FirstNameTextBox.Name)
                {
                    ActiveControl = checkBox1;
                    Console.WriteLine(this.ActiveControl.Name);
                    return true;
                }

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
