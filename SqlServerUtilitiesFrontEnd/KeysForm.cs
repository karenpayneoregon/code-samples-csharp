using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlServerUtilities;
using SqlServerUtilities.Classes;

namespace SqlServerUtilitiesFrontEnd
{
    public partial class KeysForm : Form
    {
        private List<Constraints> _constraints;
        public KeysForm()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _constraints = Informational.GetAllTablesForeignConstraints();

            TableNameListBox.DataSource = Informational.GetTableNameList();
            DisplayForeignConstraintNames();

            TableNameListBox.SelectedIndexChanged += TableNameListBox_SelectedIndexChanged;
        }

        private void TableNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayForeignConstraintNames();
        }

        private void DisplayForeignConstraintNames()
        {
            var constraints = _constraints
                .Where(item => item.TableName == TableNameListBox.Text).ToList();

            var sb = new StringBuilder();

            foreach (var constraint in constraints)
            {
                sb.AppendLine($"{constraint.ConstraintName}, {constraint.ReferencedColumn}");
            }

            ResultsTextBox.Text = sb.Length == 0 ? "None" : sb.ToString();
            
        }

        private void GetCustomersForeignConstraintsButton_Click(object sender, EventArgs e)
        {

            var constraints = Informational.GetTableForeignConstraints("Customers");
            var sb = new StringBuilder();

            foreach (var constraint in constraints)
            {
                sb.AppendLine($"{constraint.ConstraintName}, {constraint.ReferencedColumn}");
            }

            ResultsTextBox.Text = sb.Length == 0 ? "None" : sb.ToString();
        }
    }
}
