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
using GitHubRepositoryDownloader.Classes;
using GitHubRepositoryDownloader.LanguageExtensions;

namespace GitHubRepositoryDownloader.Forms
{
    public partial class CreateDownloadBatchForm : Form
    {
        private List<string> _directoryNameList;
        private string _repository;
        public CreateDownloadBatchForm()
        {
            InitializeComponent();
        }

        public CreateDownloadBatchForm(List<string> directoryNameList, string repo)
        {
            InitializeComponent();

            _directoryNameList = directoryNameList;
            _repository = repo;
            Shown += CreateDownloadBatchForm_Shown;
        }

        private void CreateDownloadBatchForm_Shown(object sender, EventArgs e)
        {
            ProjectCheckedListBox.DataSource = _directoryNameList;
        }

        private void SelectProjectsButton_Click(object sender, EventArgs e)
        {
            var items = ProjectCheckedListBox.SelectedFolders();

            if (items.Count == 0)
            {
                MessageBox.Show(@"Need one or more projects selected to continue");
                return;
            }
        
            var sb = new StringBuilder();
            sb.AppendLine("mkdir code");
            sb.AppendLine("cd code");
            sb.AppendLine("git init");
            sb.AppendLine($"git remote add -f origin {_repository}");
            sb.AppendLine("git sparse-checkout init --cone");

            foreach (var project in items)
            {
                sb.AppendLine($"git sparse-checkout add {project}");
            }

            sb.AppendLine("git pull origin master");
            sb.AppendLine(":clean-up");
            sb.AppendLine("del .gitattributes");
            sb.AppendLine("del .gitignore");
            sb.AppendLine("del *.md");
            sb.AppendLine("del *.sln");

            /*
             * Batch file name is hard coded, feel free to change this as see fit
             */
            File.WriteAllText("GitDownloadScript.bat", sb.ToString());


            if (CommonDialogs.Question("Copy script to Windows Clipboard?"))
            {
                Clipboard.SetText(sb.ToString());
            }
            

        }
    }
}
