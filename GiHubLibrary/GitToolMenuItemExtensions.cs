using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiHubLibrary
{
    public static class GitToolMenuItemExtensions
    {
        /// <summary>
        /// For reordering primary key before saving data back to json file.
        /// </summary>
        /// <param name="sender"></param>
        public static void ReorderPositionMarker(this List<GitToolMenuItem> sender)
        {
            int indexer = 1;
            for (int index = 0; index < sender.Count - 1; index++)
            {
                sender[index].Id = indexer;
                indexer += 1;
            }
        }
    }
}
