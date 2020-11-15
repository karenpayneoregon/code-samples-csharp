using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionHandling;
using GiHubLibrary;
using GitHubRepositoryExamples.Classes;
using static GitHubRepositoryExamples.Properties.Resources;


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
        private BindingList<Repository> _repositories;
        private BindingSource _repositoriesBindingSource = new BindingSource();
        public MainForm()
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
            if (string.IsNullOrWhiteSpace(RepositoryTextBox.Text))
            {
                MessageBox.Show("Requires a repo");
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
                _repositories = new BindingList<Repository>(await GitOperations.DownLoadPublicRepositoriesAsync(RepositoryTextBox.Text));
            }
            catch (Exception ex)
            {
                WorkingPictureBox.Image = null;
                // a consideration is rate limit
                MessageBox.Show($"Failed to get repositories\n{ex.Message}");
                return;
            }

            _repositoriesBindingSource.DataSource = _repositories;
            RepositoryListBox.DataSource = _repositoriesBindingSource;

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

        private void CreateDownLoadBatchFileButton_Click(object sender, EventArgs e)
        {
            if (RepositoryListBox.DataSource == null || string.IsNullOrWhiteSpace(RepositoryListBox.Text)) return;

            var directories = GitOperations.Directories(RepositoryTextBox.Text, RepositoryListBox.Text);
            var dirNames = directories.Where(item => item.type == "dir").Select(item => item.name).ToList();

            var f = new CreateDownloadBatchForm(dirNames, HtmlUrlTextBox.Text);

            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
    }
}
