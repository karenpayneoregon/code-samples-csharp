using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiHubLibrary;
using GitHubRepositoryDownloader.Classes;

namespace GitHubRepositoryDownloader.Forms
{
    public partial class GitMenuItemsConfigurationForm : Form
    {
        private BindingList<GitToolMenuItem> _gitMenuItemsBindingList;
        private readonly BindingSource _bindingSource = new BindingSource();

        public delegate void OnUpdateList(List<GitToolMenuItem> list);
        public event OnUpdateList OnUpdateListEvent;

        public GitMenuItemsConfigurationForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Shown += GitMenuItemsConfigurationForm_Shown;
        }

        private void GitMenuItemsConfigurationForm_Shown(object sender, EventArgs e)
        {
            _gitMenuItemsBindingList = new BindingList<GitToolMenuItem>(GitToolMenuOperations.ReadFromFile());
            _bindingSource.DataSource = _gitMenuItemsBindingList;
            dataGridView1.DataSource = _bindingSource;
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            dataGridView1.MoveRowUp(_bindingSource);
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            dataGridView1.MoveRowDown(_bindingSource);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            _gitMenuItemsBindingList.ToList().ReorderPositionMarker();
            OnUpdateListEvent?.Invoke(_gitMenuItemsBindingList.ToList());

            GitToolMenuOperations.WriteToFile(_gitMenuItemsBindingList.ToList());
            Close();

        }
    }
}
