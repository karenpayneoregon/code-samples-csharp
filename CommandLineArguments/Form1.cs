using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandLineArguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            if (ApplicationHelper.HasCommandLineArguments)
            {
                Console.WriteLine(ApplicationHelper.AdminMode ? "Admin mode" : "Normal mode");
                Console.WriteLine(ApplicationHelper.Refresh ? "Refresh" : "Do not refresh");
            }
        }
    }
}
