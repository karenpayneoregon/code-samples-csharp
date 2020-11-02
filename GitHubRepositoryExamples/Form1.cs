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
using GiHubLibrary;

namespace GitHubRepositoryExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseLocalFileButton_Click(object sender, EventArgs e)
        {
            GitOperations.Parse(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json"));
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            GitOperations.DownLoad();
        }

        private void RepoDetailsButton_Click(object sender, EventArgs e)
        {
            var resultsDetails = GitOperations.Details();
            Console.WriteLine(resultsDetails.public_repos);
        }
    }
}
