using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            StopWatcher.Instance.Start();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            
            Console.WriteLine(StopWatcher.Instance.DateTime);
            Console.WriteLine(StopWatcher.Instance.DateTimeFormatted);
            Console.WriteLine(StopWatcher.Instance.ElapsedFormatted);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopWatcher.Instance.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(StopWatcher.Instance);
        }
    }
}
