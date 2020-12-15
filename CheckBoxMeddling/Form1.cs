using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxMeddling
{
    public partial class Form1 : Form
    {
        private List<CheckBox> _checkBoxes = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _checkBoxes = this.DescendantsOfCheckBoxes();
            
            _checkBoxes.ForEach(cb => 
            {
                cb.CheckedChanged += CheckedChanged;
                cb.FlatStyle = FlatStyle.Popup;
            });
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox) sender;
            var number =  cb.Name.ToInt();

            if (number > 5)
            {
                if (cb.FlatStyle == FlatStyle.Popup)
                {
                    cb.FlatStyle = FlatStyle.Flat;

                    cb.ForeColor = Color.Crimson;
                    cb.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    cb.FlatStyle = FlatStyle.Popup;
                    cb.ForeColor = SystemColors.ControlText;
                    cb.BackColor = SystemColors.Control;
                }
            }

        }
    }
}
