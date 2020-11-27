using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiHubLibrary;

namespace GitHubRepositoryDownloader.Forms
{
    public partial class RepositoryRecentCommitsForm : Form
    {
        private readonly RepositoryCommitItem[] _commitItems;
        public RepositoryRecentCommitsForm(RepositoryCommitItem[] commitItems)
        {
            InitializeComponent();
            _commitItems = commitItems;

            Shown += RepositoryRecentCommitsForm_Shown;
        }

        private void RepositoryRecentCommitsForm_Shown(object sender, EventArgs e)
        {
            var index = 1;

            foreach (var repositoryCommitItem in _commitItems)
            {
                var item = new ListViewItem($"{index:00}") {Tag = repositoryCommitItem.commit.message};
                item.SubItems.Add(repositoryCommitItem.commit.author.date.ToString("MM/dd/yyyy hh:mm tt"));
                listView1.Items.Add(item);
                index += 1;
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;

            listView1.FocusedItem = listView1.Items[0];
            listView1.Items[0].Selected = true;
            ActiveControl = listView1;
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                Console.WriteLine(e.Item.Tag);
                CommentTextBox.Text = e.Item.Tag.ToString();
            }
        }
    }
}
