using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerUtilities.Classes;
using SqlServerUtilities.Enums;
using static SqlServerUtilities.Classes.GenericUtils;

namespace SqlServerUtilitiesFrontEnd
{
    public partial class FlexibleKeysForm : Form
    {
        public FlexibleKeysForm()
        {
            InitializeComponent();

            Shown += FlexibleForm_Shown;
        }

        private void FlexibleForm_Shown(object sender, EventArgs e)
        {
            ConstraintTypeComboBox.DataSource = Enum.GetNames(typeof(ConstraintType)).ToList();
            TableNameListBox.DataSource = Informational.GetTableNameList();

            DisplayDetails();

            TableNameListBox.SelectedIndexChanged += TableNameListBox_SelectedIndexChanged;
            ConstraintTypeComboBox.SelectedIndexChanged += ConstraintTypeComboBox_SelectedIndexChanged;
        }

        private void ConstraintTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void TableNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDetails();
        }
        /// <summary>
        /// Display desired details
        /// </summary>
        private void DisplayDetails()
        {
            var selectedType = EnumParser<ConstraintType>(ConstraintTypeComboBox.Text);
            var results = Informational.GetConstraints(selectedType, TableNameListBox.Text);

            var sb = new StringBuilder();
            sb.AppendLine($"{ConstraintTypeComboBox.Text}");

            if (results.Count >0)
            {
                foreach (var constraints in results)
                {
                    sb.AppendLine($"{constraints.ConstraintName}, {constraints.ColumnName}");
                }
            }
            else
            {
                sb.AppendLine("None");
            }


            ResultsTextBox.Text = sb.ToString();
        }
    }
}
