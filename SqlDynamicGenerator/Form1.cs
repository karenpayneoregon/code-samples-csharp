using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlHelperLibrary;

namespace SqlDynamicGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SuppliersNamesListBox.DataSource = new List<string>() { "Google", "Kimberly-Clark", "Tyson Foods" };
            SuppliersIdsListBox.DataSource = new List<string>() {"1","2","3","4","5"};
        }
        /// <summary>
        /// Create WHERE IN for string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessSuppliersByNameButton_Click(object sender, EventArgs e)
        {
            var selections = SuppliersNamesListBox.SelectedItems.Cast<string>().ToArray();

            if (selections.Length >0)
            {
                var sqlGenerator = new SqlGenerator
                {
                    Text = string.Join(",", selections),
                    SelectStatement = "SELECT supplier_id,supplier_name,city,[state] FROM WhereInSimple",
                    DataType = DataTypes.String,
                    ColumnName = "supplier_name"
                };

                sqlGenerator.CreateWhereStatement();

                SuppliersNameResultsTextBox.Text = sqlGenerator.Statement;
            }
            else
            {
                MessageBox.Show("Please select one or more suppliers");
            }
        }
        /// <summary>
        /// Create WHERE IN for int
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessSuppliersByIdButton_Click(object sender, EventArgs e)
        {
            var selections = SuppliersIdsListBox.SelectedItems.Cast<string>().ToArray();

            if (selections.Length > 0)
            {
                var sqlGenerator = new SqlGenerator
                {
                    Text = string.Join(",", selections),
                    SelectStatement = "SELECT supplier_id,supplier_name,city,[state] FROM WhereInSimple",
                    DataType = DataTypes.Integer,
                    ColumnName = "supplier_id"
                };

                sqlGenerator.CreateWhereStatement();

                SuppliersIdsResultsTextBox.Text = sqlGenerator.Statement;
            }
            else
            {
                MessageBox.Show("Please select one or more suppliers identifiers");
            }
        }
    }
}
