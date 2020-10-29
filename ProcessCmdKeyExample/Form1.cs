using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlsExtensions;

namespace ProcessCmdKeyExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }
        /// <summary>
        /// Pick a key combination to toggle the CheckBox
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Space))
            {

                this.CheckBoxList().ForEach(cb =>
                {
                    var cBox = (CheckBox) cb;
                    if (cBox.Checked)
                    {
                        cBox.Checked = false;
                    }
                    else
                    {
                        cBox.Checked = true;
                    }
                });

                return true;
            }

            if (keyData == Keys.Tab)
            {
                if (ActiveControl.Name == FirstNameTextBox.Name)
                {
                    ActiveControl = checkBox1;
                    return true;
                }

            }

            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
}
