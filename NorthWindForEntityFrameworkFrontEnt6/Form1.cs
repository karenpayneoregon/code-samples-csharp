using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindForEntityFramework6;
using NorthWindForEntityFramework6.Classes;
using NorthWindForEntityFrameworkFrontEnt6.Extensions;

namespace NorthWindForEntityFrameworkFrontEnt6
{
    public partial class Form1 : Form
    {

        private List<Button> _buttons;
        public Form1()
        {
            InitializeComponent();

            _buttons = this.AllButtons();

            _buttons.ForEach(button => button.Enabled = false);

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            var modelName = await EntityFrameworkHelper.GeModelNames<NorthContext>();
            
            ModelNamesListBox.DataSource = modelName;

            _buttons.ForEach(button => button.Enabled = true);
            _buttons = null;
        }

        /// <summary>
        /// Example for traversing a model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TraverseButton_Click(object sender, EventArgs e)
        {
            const int indent = 20;

            ReadOnlyMetadataCollection<NavigationProperty> metadata = EntityFrameworkHelper.GetNavigationProperties<Order,NorthContext>();

            var nameParts = metadata.FirstOrDefault().DeclaringType.FullName.Split('.');
            Debug.WriteLine($"namespace: {nameParts[0]}");
            Debug.WriteLine($"    class: {nameParts[1]}");

            Debug.WriteLine("");

            Debug.WriteLine("navigation model names");

            var navigationPropertyNames = metadata.Select(np => np.Name).ToList();
            

            foreach (var name in navigationPropertyNames)
            {
                Debug.WriteLine($"{name,indent}");
            }

            Debug.WriteLine("");
            Debug.WriteLine("RelationshipType names");
            var relationNames = metadata.Select(np => np.RelationshipType.Name).ToList();
            foreach (var relationName in relationNames)
            {
                Debug.WriteLine($"{relationName,indent}");
            }


            MessageBox.Show("See output window");
        }

        private async void ModelDetailsButton_Click(object sender, EventArgs e)
        {
            var results = await EntityInfo.DatabaseTableInformation();
            Debug.WriteLine(""); // place breakpoint here and examine
        }
        /// <summary>
        /// Example for getting navigation properties for a model in referenced class project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationsForModelButton_Click(object sender, EventArgs e)
        {
            NavigationListBox.DataSource = null;

            Type type = Type.GetType($"NorthWindForEntityFramework6.{ModelNamesListBox.Text}, NorthWindForEntityFramework6");
            NavigationListBox.DataSource = EntityCrawler.GetNavigationProperties(type);
        }
    }
}
