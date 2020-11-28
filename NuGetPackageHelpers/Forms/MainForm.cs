using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NuGetPackageHelpers.Classes;
using NuGetPackageHelpers.Classes.Containers;

namespace NuGetPackageHelpers.Forms
{
    public partial class MainForm : Form
    {

        public Solution Solution = new Solution();

        public MainForm()
        {
            InitializeComponent();

            Operations.DisplayInformationHandler += Operations_DisplayHandler;
            Operations.ExportWebPageFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "results.html");

            ProjectTypeComboBox.DataSource = ProjectTypes.ProjectTypesList();

            Shown += Form1_Shown;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveControl = ProcessSelectSolutionButton;
        }

        /// <summary>
        /// Font for project name row in ListView
        /// </summary>
        private readonly Font _projectNameFont = new Font("Calibri", 10, FontStyle.Bold); 

        /// <summary>
        /// Display progress in real time. Here there are three possibilities
        /// * project name
        /// * package name an version
        /// * empty line to separate projects (could also have done a group)
        /// </summary>
        /// <param name="sender">Information to add to ListView</param>
        /// <param name="bold"></param>
        private void Operations_DisplayHandler(string sender, bool bold)
        {
            if (bold)
            {
                var item = new ListViewItem(sender) {Font = _projectNameFont};
                item.ForeColor = Color.Crimson;
                listView1.Items.Add(item);
            }
            else
            {
                listView1.Items.Add(sender);
            }
            
        }
        /// <summary>
        /// Display confirmation of solution selected and solution folder
        /// selected.
        /// </summary>
        private void DisplayDetails()
        {
            SolutionFolderLabel.Text = $"Folder: {Solution.Folder}";
            SolutionLabel.Text = $"Solution: {Solution.SolutionName}";
        }

        /// <summary>
        /// Process the current solution this project resides in by language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessCurrentSolutionButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var projectType = ((ProjectType) ProjectTypeComboBox.SelectedItem).Extension;
            Operations.BuilderPackageTable(GetFoldersToParent.GetSolutionFolderPath(), projectType);

            Solution = Operations.Solution;

            DisplayDetails();
            ExportToWebPageButton.Enabled = Solution.Packages.Any();

            PackageComboBox.DataSource = Operations.DistinctPackageNames();

        }
        /// <summary>
        /// Process the selected solution from the folder dialog by language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessSelectSolutionButton_Click(object sender, EventArgs e)
        {
            Solution = Operations.Solution;
            listView1.Items.Clear();

            var initialPath = @"C:\OED\Dotnetland\VS2019\";

            if (Environment.UserName != "PayneK")
            {
                initialPath = @"C:\";
            }
            var dialog = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog
            {

                SelectedPath = initialPath,
                ShowNewFolderButton = false,
                Description = @"Select solution folder",
                UseDescriptionForTitle = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                var projectType = ((ProjectType)ProjectTypeComboBox.SelectedItem).Extension;
                Operations.BuilderPackageTable(dialog.SelectedPath, projectType);

                Solution = Operations.Solution;

                DisplayDetails();

                ExportToWebPageButton.Enabled = Solution.Packages.Any();

                PackageComboBox.DataSource = Operations.DistinctPackageNames();

            }
        }
        /// <summary>
        /// Process ListView items to HTML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToWebPageButtonButton_Click(object sender, EventArgs e)
        {

            if (Solution.Count >0)
            {
                Operations.ExportAsWebPage();
            }
            else
            {
                MessageBox.Show("Please select and process and solution");
            }
        }
        /// <summary>
        /// Find package in ComboBox across all projects in the solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckVersioningButton_Click(object sender, EventArgs e)
        {
            if (Operations.Solution == null || Operations.Solution.Packages.Count <= 0) return;

            PackagesListView.Items.Clear();
            _packageItemList.Clear();

            var packages = Operations.Solution.Packages;
            _packageItemList = new List<PackageItem>();

            foreach (var package in packages)
            { 

                var packageItems = package
                    .PackageItems
                    .Where(x => x.Name == PackageComboBox.Text);

                if (packageItems.Any())
                {
                    _packageItemList.AddRange(packageItems.Select(packageItem => new PackageItem() {Name = package.ProjectName, Version = packageItem.Version}));
                }
            }

            foreach (var packageItem in _packageItemList)
            {
                PackagesListView.Items.Add(new ListViewItem(packageItem.ItemArray));
            }

            PackagesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            VersionCountLabel.Text = _packageItemList.Select(x => x.Version).Distinct().Count().ToString();
        }

        private List<PackageItem> _packageItemList = new List<PackageItem>();

        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (Operations.Solution == null || Operations.Solution.Packages.Count <= 0) return;


            var viewForm = new VersionsForm(PackageComboBox.Text,Operations.VersionGroup(PackageComboBox.Text, _packageItemList));

            try
            {
                viewForm.ShowDialog();
            }
            finally
            {
                viewForm.Dispose();
            }

        }
    }
}
