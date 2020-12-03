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
using ExamineZipFile.Classes;

namespace ExamineZipFile
{
    public partial class Form1 : Form
    {

        private bool _failed = false;
        public Form1()
        {
            InitializeComponent();

            ArchiveOperations.OnExceptionEvent += ArchiveOperations_OnExceptionEvent;

            treeView1.ImageList = imageList1;

        }
        /// <summary>
        /// A runtime exception was thrown while attempting to get .zip file contents.
        /// </summary>
        /// <param name="exception"></param>
        private void ArchiveOperations_OnExceptionEvent(Exception exception)
        {
            _failed = true;
            MessageBox.Show($"Failed to extract files\n{exception.Message}");
        }

        /// <summary>
        /// Get .zip file contents into the TreeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectButton_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();
            /*
             * Get folders and files in .zip file
             */
            var containers = ArchiveOperations.Work("SampleZip.zip");

            if (_failed)
            {
                return;
            }

            List<TreeNode> childTreeNodes;
            TreeNode fileNode;

            foreach (var resultContainer in containers)
            {
                childTreeNodes = new List<TreeNode>();

                foreach (var fileContainer in resultContainer.List)
                {
                    fileNode = new TreeNode(fileContainer.NodeValue) { ImageIndex = 1 };
                    childTreeNodes.Add(fileNode);
                    
                }

                var treeNode = new TreeNode(resultContainer.FolderName, childTreeNodes.ToArray()) { ImageIndex = 0 };
                treeView1.Nodes.Add(treeNode);

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.SelectedImageIndex = 1;
            }
        }
    }
}
