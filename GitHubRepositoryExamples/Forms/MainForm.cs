using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using GiHubLibrary;
using GitHubRepositoryExamples.Classes;
using static GitHubRepositoryExamples.Properties.Resources;
using Formatting = System.Xml.Formatting;


namespace GitHubRepositoryExamples.Forms
{
    /// <summary>
    /// Entry form for application
    /// </summary>
    /// <remarks>
    /// Larger repositories will take longer to load.
    /// </remarks>
    public partial class MainForm : Form
    {
        private BindingList<Repository> _repositoriesBindingList;
        private BindingSource _repositoriesBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();

            exitToolStripMenuItem.Click += CloseApplicationButton_Click;

            CueBannerTextCode.SetCueText(RepositoryTextBox,"Right click for list");

            // handles incremental search in repository ListBox
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;

            // notification ENTER was pressed to invoke repository fetch.
            RepositoryTextBox.TriggerEvent += RepositoryTextBox_TriggerEvent;

            LoadToolStripFromFile();

            GitOperations.OnExceptionEvent += GitOperations_OnExceptionEvent;

        }

        private void GitOperations_OnExceptionEvent(Exception exception)
        {
            MessageBox.Show($"An error occoured\n{exception.Message}");
        }

        /// <summary>
        /// Load menu items from json file
        /// </summary>
        private void LoadToolStripFromFile()
        {
            var menuItems = GitToolMenuOperations.ReadFromFile();

            foreach (var item in menuItems.Select(gitToolMenu => new ToolStripMenuItem { Text = gitToolMenu.Text, Tag = gitToolMenu.Id }))
            {
                RepoListContextMenu.Items.Add(item);
            }

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
            var test = ((ToolStripMenuItem)sender).Text;
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
            if (string.IsNullOrWhiteSpace(RepositoryTextBox.Text))
            {
                MessageBox.Show(@"Requires a repository");
                return;
            }

            WorkingPictureBox.Image = spinner;

            if (RepositoryListBox.DataSource != null)
            {
                _lastSelectedRepositoryName = RepositoryListBox.Text;
            }

            RepositoryListBox.DataSource = null;

            try
            {
                _repositoriesBindingList = new BindingList<Repository>(await GitOperations.DownLoadPublicRepositoriesAsync(RepositoryTextBox.Text));
            }
            catch (Exception ex)
            {
                WorkingPictureBox.Image = null;
                // a consideration is rate limit
                MessageBox.Show($@"Failed to get repositories {ex.Message}");
                return;
            }

            _repositoriesBindingSource.DataSource = _repositoriesBindingList;
            RepositoryListBox.DataSource = _repositoriesBindingSource;

            if (_repositoriesBindingSource.Count >0)
            {
                RepositoryListBox.SelectedIndex = 0;
            }

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
            if (_repositoriesBindingList == null) return;

            var index = RepositoryListBox.FindString(SearchTextBox.Text);
            if (index >= 0)
            {
                _repositoriesBindingSource.Position = index;
            }
        }


        /// <summary>
        /// DataBind all TextBoxes
        /// </summary>
        private void BindControls()
        {

            ControlHelpers.ClearTextBoxBindings(this);

            DescriptionTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "Description");
            FullNameTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "full_name");
            HtmlUrlTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "html_url");
            LanguageTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "language");
            LastUpdatedTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "LastUpdated");
            StarGazersCountTextBox.DataBindings.Add("Text", _repositoriesBindingSource, "StarGazersCount");

        }
        /// <summary>
        /// Temp code for testing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoldersForSelectedButton_Click(object sender, EventArgs e)
        {
            if (RepositoryListBox.DataSource == null || string.IsNullOrWhiteSpace(RepositoryListBox.Text)) return;

            var directories = GitOperations.Directories(RepositoryTextBox.Text, RepositoryListBox.Text);
            var directoryNameList = directories.Where(item => item.type == "dir").Select(item => item.name).ToList();

            var repoDirectoryForm = new RepositoryDirectoryForm(directoryNameList);
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
        /// <summary>
        /// Get last 30 or less commits for current repository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectRecentCommitsButton_Click(object sender, EventArgs e)
        {
            RepositoryCommitItem[] recentCommits = {};

            try
            {
                recentCommits = GitOperations.RecentCommits(RepositoryTextBox.Text, RepositoryListBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to get commits\n{ex.Message}");
                Exceptions.Write(ex);
                return;
            }

            if (recentCommits.Length > 0)
            {
                var commitForm = new RepositoryRecentCommitsForm(recentCommits);
                try
                {
                    commitForm.ShowDialog();
                }
                finally
                {
                    commitForm.Dispose();
                }
            }
            else
            {
                MessageBox.Show("No commits found");
            }
        }

        private void CloseApplicationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Provides logic to move menu items up/down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateDownLoadBatchFileButton_Click(object sender, EventArgs e)
        {
            if (RepositoryListBox.DataSource == null || string.IsNullOrWhiteSpace(RepositoryListBox.Text)) return;

            var directories = GitOperations.Directories(RepositoryTextBox.Text, RepositoryListBox.Text);
            var directoryList = directories.Where(item => item.type == "dir").Select(item => item.name).ToList();

            var f = new CreateDownloadBatchForm(directoryList, HtmlUrlTextBox.Text);

            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }

        private void repositoryConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new GitMenuItemsConfigurationForm();
            f.OnUpdateListEvent += OnUpdateMenuListEvent;
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
        /// <summary>
        /// Invoked from GitMenuItemsConfigurationForm save button
        /// </summary>
        /// <param name="list"></param>
        private void OnUpdateMenuListEvent(List<GitToolMenuItem> list)
        {
            RepoListContextMenu
                .Items.Cast<ToolStripItem>()
                .ToList()
                .ForEach(item => item.Click -= ContextMenuItem_Click);

            RepoListContextMenu.Items.Clear();

            foreach (var gitToolMenu in list)
            {
                var item = new ToolStripMenuItem { Text = gitToolMenu.Text, Tag = gitToolMenu.Id };
                RepoListContextMenu.Items.Add(item);

            }

            RepoListContextMenu
                .Items.Cast<ToolStripItem>()
                .ToList()
                .ForEach(item => item.Click += ContextMenuItem_Click);

        }

        private void GetMainReadMeFileButton_Click(object sender, EventArgs e)
        {
            var url = GitOperations.GetRepositoryMainReadmeFileLink(RepositoryTextBox.Text, RepositoryListBox.Text);
            RepositoryReadMeTextBox.Text = url;
        }

        private void TraverseToReadmeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RepositoryReadMeTextBox.Text))
            {
                Process.Start(RepositoryReadMeTextBox.Text);
            }
        }
    }

}
