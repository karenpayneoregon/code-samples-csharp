using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiHubLibrary;
using GitHubRepositoryExamples.Classes;


namespace GitHubRepositoryExamples
{
    public partial class Form1 : Form
    {
        private BindingList<Repository> _repositories;
        public Form1()
        {
            InitializeComponent();

            SearchTextBox.TextChanged += SearchTextBox_TextChanged;

        }

        private string _lastSelectedRepositoryName;

        /// <summary>
        /// Fetch repositories from GitHub
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FetchRepositoriesButton_Click(object sender, EventArgs e)
        {
            if (RepositoryListBox.DataSource != null)
            {
                _lastSelectedRepositoryName = RepositoryListBox.Text;
            }



            RepositoryListBox.DataSource = null;

            _repositories = new BindingList<Repository>(await GitOperations.DownLoadPublicRepositoriesAsync());
            RepositoryListBox.DataSource = _repositories;

            BindControls();
            ControlHelpers.SetWaterMarkers(this);

            if (!string.IsNullOrWhiteSpace(_lastSelectedRepositoryName))
            {
                var index = RepositoryListBox.FindString(_lastSelectedRepositoryName);
                if (index >= 0)
                {
                    RepositoryListBox.SelectedIndex = index;
                }
            }

            ActiveControl = RepositoryListBox;

        }
        /// <summary>
        /// Incremental search on loaded repositories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_repositories == null) return;

            var index = RepositoryListBox.FindString(SearchTextBox.Text);
            if (index >= 0)
            {
                RepositoryListBox.SelectedIndex = index;
            }
        }


        /// <summary>
        /// DataBind all TextBoxes
        /// </summary>
        private void BindControls()
        {

            ControlHelpers.ClearTextBoxBindings(this);

            DescriptionTextBox.DataBindings.Add("Text", _repositories, "Description");
            FullNameTextBox.DataBindings.Add("Text", _repositories, "full_name");
            HtmlUrlTextBox.DataBindings.Add("Text", _repositories, "html_url");
            LanguageTextBox.DataBindings.Add("Text", _repositories, "language");

        }
        /// <summary>
        /// Temp code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var current = (Repository) RepositoryListBox.SelectedItem;
            Console.WriteLine();
        }
        /// <summary>
        /// Browse to current repository on GitHub in default web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseRepositoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(HtmlUrlTextBox.Text))
            {
                Process.Start(HtmlUrlTextBox.Text);
            }
        }
    }
}
