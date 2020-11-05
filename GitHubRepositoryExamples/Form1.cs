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
using static GitHubRepositoryExamples.Properties.Resources;


namespace GitHubRepositoryExamples
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Larger repositories will take longer to load.
    /// </remarks>
    public partial class Form1 : Form
    {
        private BindingList<Repository> _repositories;
        public Form1()
        {
            InitializeComponent();

            // handles incremental search in repository ListBox
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;

            // notification ENTER was pressed to invoke repository fetch.
            RepositoryTextBox.TriggerEvent += RepositoryTextBox_TriggerEvent;

            // for each menu item subscribe to the Click event
            RepoListContextMenu
                .Items.Cast<ToolStripItem>()
                .ToList()
                .ForEach(item => item.Click += ContextMenuItem_Click);
        }

        /// <summary>
        /// Place selected repository name into the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            RepositoryTextBox.Text = ((ToolStripMenuItem) sender).Text;
            ActiveControl = RepositoryTextBox;
        }
        /// <summary>
        /// Triggered when ENTER is pressed in the repository TextBox
        /// </summary>
        private async void RepositoryTextBox_TriggerEvent()
        {
            await FetchSelectedRepository();
        }

        private string _lastSelectedRepositoryName;

        /// <summary>
        /// Fetch repositories from GitHub
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FetchRepositoriesButton_Click(object sender, EventArgs e)
        {
            await FetchSelectedRepository();
        }
        /// <summary>
        /// Fetch repository in repository TextBox
        /// </summary>
        /// <returns></returns>
        private async Task FetchSelectedRepository()
        {

            WorkingPictureBox.Image = spinner;

            if (RepositoryListBox.DataSource != null)
            {
                _lastSelectedRepositoryName = RepositoryListBox.Text;
            }

            RepositoryListBox.DataSource = null;

            try
            {
                _repositories = new BindingList<Repository>(await GitOperations.DownLoadPublicRepositoriesAsync(RepositoryTextBox.Text));
            }
            catch (Exception ex)
            {
                // a consideration is rate limit
                MessageBox.Show($"Failed to get repositories\n{ex.Message}");
                return;
            }

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
            WorkingPictureBox.Image = null;
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
            LastUpdatedTextBox.DataBindings.Add("Text", _repositories, "LastUpdated");
            StarGazersCountTextBox.DataBindings.Add("Text", _repositories, "StarGazersCount");

        }
        /// <summary>
        /// Temp code for testing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TempCodeButton_Click(object sender, EventArgs e)
        {
            if (RepositoryListBox.DataSource == null || string.IsNullOrWhiteSpace(RepositoryListBox.Text)) return;

            var directories = GitOperations.Directories(RepositoryTextBox.Text, RepositoryListBox.Text);
            var dirNames = directories.Where(item => item.type == "dir").Select(item => item.name).ToList();

            var repoDirectoryForm = new RepositoryDirectoryForm(dirNames);
            try
            {
                repoDirectoryForm.ShowDialog();
            }
            finally
            {
                repoDirectoryForm.Dispose();
            }
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
