using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostBuildRemoveFolder.Classes;
using PostBuildRemoveFolder.Forms;

namespace PostBuildRemoveFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            var configurationForm = new ConfigurationForm();
            try
            {
                configurationForm.ShowDialog();
            }
            finally
            {
                configurationForm.Dispose();
            }
        }
    }
}
