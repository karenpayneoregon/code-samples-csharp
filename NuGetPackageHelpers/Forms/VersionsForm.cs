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
using NuGetPackageHelpers.Classes;
using NuGetPackageHelpers.Classes.Containers;

namespace NuGetPackageHelpers.Forms
{
    public partial class VersionsForm : Form
    {
        private readonly List<PackageResult> _packageResults;
        private string _packageName;
        public VersionsForm()
        {
            InitializeComponent();
        }

        public VersionsForm(string packageName,List<PackageResult> packageResults)
        {
            InitializeComponent();

            _packageResults = packageResults;
            _packageName = packageName;
            Shown += VersionsForm_Shown;
        }

        private void VersionsForm_Shown(object sender, EventArgs e)
        {

            Text = $"Package: '{_packageName}'";

            foreach (var packageResult in _packageResults)
            {
                var group = new ListViewGroup(packageResult.Version.ToString(), HorizontalAlignment.Left)
                {
                    Header = packageResult.Version.ToString()
                };

                listView1.Groups.Add(group);

                foreach (var packageItem in packageResult.List)
                {
                    var listViewItem = new ListViewItem(new []{packageItem.Name}) {Group = group};
                    listView1.Items.Add(listViewItem);
                }

                
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView1.FocusedItem = listView1.Items[0];
            listView1.Items[0].Selected = true;

            ActiveControl = listView1;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            var packageItems = new List<PackageItem>();

            foreach (var packageResult in _packageResults)
            {
                packageItems.AddRange(packageResult.List);
            }

            var results = Operations.VersionReport(Text, packageItems);
            File.WriteAllText("Results.csv",results);
            
        }
    }
}
