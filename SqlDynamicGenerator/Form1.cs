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
using SqlHelperLibrary;

namespace SqlDynamicGenerator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Container for SQL statements and the method called them
        /// </summary>
        private readonly List<StatementContainer> _statementContainers = new List<StatementContainer>();
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;

            Mocked.OnShowCommandStatementEvent += Mocked_OnShowCommandStatementEvent;
        }

        private void Mocked_OnShowCommandStatementEvent(string methodName,string statement)
        {
            _statementContainers.Add(new StatementContainer() {MethodName =  methodName, Text = statement});
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SuppliersNamesListBox.DataSource = new List<string>() { "Google", "Kimberly-Clark", "Tyson Foods" };
            SuppliersIdsListBox.DataSource = new List<string>() {"1","2","3","4","5"};

            Mocked.OnExceptionEvent += Mocked_OnExceptionEvent;
        }

        private bool _hasException;
        private Exception _lastException;

        private void Mocked_OnExceptionEvent(Exception exception)
        {
            _hasException = true;
            _lastException = exception;
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
                    DelimitedValues = string.Join(",", selections),
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
                    DelimitedValues = string.Join(",", selections),
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

        private void CustomersDataTableButtonButton_Click(object sender, EventArgs e)
        {
            /*
             * Contact types passed to ExampleCustomersList1 are existing values in the ContactType table
             */
            var dataTable = Mocked.ExampleCustomersDataTable1(new List<string>() { "Assistant Sales Agent", "Owner"});
            if (_hasException)
            {
                MessageBox.Show($"Failed with\n{_lastException.Message}");
            }
            else
            {
                MessageBox.Show($"Returned {dataTable.Rows.Count} rows");
            }
        }

        private void CustomerListButton_Click(object sender, EventArgs e)
        {
            /*
             * Contact types passed to ExampleCustomersList1 are existing values in the ContactType table
             */
            var customers = Mocked.ExampleCustomersList1(new List<string>() { "Assistant Sales Agent", "Owner" });
            if (_hasException)
            {
                MessageBox.Show($"Failed with\n{_lastException.Message}");
            }
            else
            {
                MessageBox.Show($"Returned {customers.Count} rows");
            }
        }

        private void ProductListButton_Click(object sender, EventArgs e)
        {
            /*
             * Categories passed to ExampleProductsList are existing values in the Category table
             */
            var customers = Mocked.ExampleProductsList(new List<string>() { "Beverages", "Dairy Products", "Condiments" });
            if (_hasException)
            {
                MessageBox.Show($"Failed with\n{_lastException.Message}");
            }
            else
            {
                MessageBox.Show($"Returned {customers.Count} rows");
            }
        }

        private void DumpStatementsButton_Click(object sender, EventArgs e)
        {
            var fileName = "SqlStatements.txt";
            var existingText = "";

            if (File.Exists(fileName))
            {
                existingText = File.ReadAllText(fileName);
            }

            var sb = new StringBuilder();

            foreach (var statementContainer in _statementContainers)
            {
                sb.AppendLine(statementContainer.Data);
            }

            File.WriteAllText(fileName, string.Concat(existingText, sb.ToString()));
        }

        /// <summary>
        /// Controls displaying of formatted SQL to the IDE output window.
        /// As coded Console.WriteLine is used, if using any version of Visual Studio newer
        /// than 2017 change to Debug.WriteLine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayFormattedSqlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Mocked.DisplayFormattedSql = DisplayFormattedSqlCheckBox.Checked;
        }
    }
}
