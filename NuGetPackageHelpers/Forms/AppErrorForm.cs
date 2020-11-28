using System;
using System.Windows.Forms;

namespace NuGetPackageHelpers.Forms
{
    public partial class AppErrorForm : Form
    {
        public AppErrorForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
