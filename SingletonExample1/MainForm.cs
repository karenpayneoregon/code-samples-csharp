using System;
using System.Windows.Forms;
using SingletonExample1.Classes;

namespace SingletonExample1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RuntimeSettings.OnDatabasePathChangedEvent += 
                RuntimeSettingsOnOnDatabasePathChangedEvent;
        }

        private void RuntimeSettingsOnOnDatabasePathChangedEvent()
        {
            DatabasePathTextBox.Text = RuntimeSettings.Instance.DatabasePath;
        }

        private void GetDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabasePathTextBox.Text = RuntimeSettings.Instance.DatabasePath;
        }

        private void SetDatabasePathButton_Click(object sender, EventArgs e)
        {
            RuntimeSettings.Instance.DatabasePath = DatabasePathTextBox.Text;
        }

        private void OpenChildForm_Click(object sender, EventArgs e)
        {
            
            var childForm = new ChildForm();
            try
            {
                childForm.ShowDialog();
            }
            finally
            {
                childForm.Dispose();
            }
        }
    }
}
