using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsProcessRunningWithProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void WatchProcessTimer_Tick(object sender, EventArgs e)
        {
            // replace with your executable name (excluding .exe)
            var process = Process.GetProcessesByName("ChunkIncomingTextFile");
            if (process.FirstOrDefault() == null)
            {
                progressBar1.Visible = false;
                RunningLabel.Text = "Not running";
            }
            else
            {
                // replace the string for StartsWith with the path to the executable above
                var isRunning = process.FirstOrDefault(currentProcess => 
                    currentProcess.MainModule != null && 
                    currentProcess.MainModule.FileName.StartsWith(@"C:\OED\Dotnetland\SIDES MPC\Debug")) != default(Process);

                if (isRunning)
                {
                    progressBar1.Visible = true;
                }
                RunningLabel.Text = "Running";
            }

        }
    }
}
