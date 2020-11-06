using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitHubRepositoryExamples.Forms
{
    public partial class RepositoryDirectoryForm : Form
    {
        private List<string> _directoryNameList;
        public RepositoryDirectoryForm(List<string> directoryNameList)
        {
            InitializeComponent();
            _directoryNameList = directoryNameList;

            Shown += RepositoryDirectoryForm_Shown;
        }

        private void RepositoryDirectoryForm_Shown(object sender, EventArgs e)
        {
            DirectoryNamesListBox.DataSource = _directoryNameList;
        }
    }
}
