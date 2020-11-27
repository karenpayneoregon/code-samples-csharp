using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiHubLibrary;

namespace GitHubRepositoryDownloader.Classes
{
    /// <summary>
    /// Specific extensions for git menu items
    /// </summary>
    public static class DataGridViewExtensions
    {
        /// <summary>
        /// Move selected row bound via a BindingSource up/down
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pBindingSource"></param>
        public static void MoveRowUp(this DataGridView pDataGridView, BindingSource pBindingSource)
        {
            if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
            {
                pBindingSource.Sort = "";
            }

            var currentColumnIndex = pDataGridView.CurrentCell.ColumnIndex;
            var newIndex = Convert.ToInt32((pBindingSource.Position == 0) ? 0 : pBindingSource.Position - 1);

            var bindingList = (BindingList<GitToolMenuItem>)pBindingSource.DataSource;
            var rowToMove = (GitToolMenuItem)pBindingSource.Current;

            bindingList.RemoveAt(pBindingSource.Position);


            bindingList.Insert(newIndex, rowToMove);
            pBindingSource.Position = newIndex;
            pDataGridView.CurrentCell = pDataGridView[currentColumnIndex, newIndex];
        }
        /// <summary>
        /// Move selected row bound via a BindingSource up/down
        /// </summary>
        /// <param name="pDataGridView"></param>
        /// <param name="pBindingSource"></param>
        public static void MoveRowDown(this DataGridView pDataGridView, BindingSource pBindingSource)
        {
            if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
            {
                pBindingSource.Sort = "";
            }

            var currentColumnIndex = pDataGridView.CurrentCell.ColumnIndex;
            var upperLimit = pBindingSource.Count - 1;
            var newIndex = Convert.ToInt32((pBindingSource.Position + 1 >= upperLimit) ? upperLimit : pBindingSource.Position + 1);

            var bindingList = (BindingList<GitToolMenuItem>)pBindingSource.DataSource;
            var rowToMove = (GitToolMenuItem)pBindingSource.Current;

            bindingList.RemoveAt(pBindingSource.Position);


            bindingList.Insert(newIndex, rowToMove);
            pBindingSource.Position = newIndex;
            pDataGridView.CurrentCell = pDataGridView[currentColumnIndex, newIndex];
        }
    }
}
