using System;
using System.Windows.Forms;
using SingletonExample1.Classes;

namespace SingletonExample1
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void GetDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabasePathTextBox.Text = RuntimeSettings.Instance.DatabasePath;
        }

        private void SetDatabasePathButton_Click(object sender, EventArgs e)
        {
            RuntimeSettings.Instance.DatabasePath = DatabasePathTextBox.Text;
        }
    }
}
