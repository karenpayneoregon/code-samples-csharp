using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubRepositoryExamples.LanguageExtensions
{
    public static class CheckedListBoxExtensions
    {
        public static List<string> SelectedFolders(this CheckedListBox sender)
        {
            return sender.Items.Cast<string>().Where((cat, index) => sender.GetItemChecked(index)).Select(item => item).ToList();
        }
    }
}
