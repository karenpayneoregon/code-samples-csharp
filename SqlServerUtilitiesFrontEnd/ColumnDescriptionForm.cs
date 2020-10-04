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

namespace SqlServerUtilitiesFrontEnd
{
    public partial class ColumnDescriptionForm : Form
    {
        public ColumnDescriptionForm()
        {
            InitializeComponent();

            Shown += ColumnDescriptionForm_Shown;
        }

        private void ColumnDescriptionForm_Shown(object sender, EventArgs e)
        {
            TableNameListBox.DataSource = Informational.GetTableNameList();

            DisplayDetails();

            TableNameListBox.SelectedIndexChanged += TableNameListBox_SelectedIndexChanged;
        }

        private void TableNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            var contacts = Informational.GetColumnDescriptions(TableNameListBox.Text);

            ColumnDescriptionsListView.BeginUpdate();
            ColumnDescriptionsListView.Items.Clear();

            foreach (var contact in contacts)
            {
                ColumnDescriptionsListView.Items.Add(new ListViewItem(contact.ItemArray) { });
            }

            ColumnDescriptionsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ColumnDescriptionsListView.EndUpdate();

            ActiveControl = ColumnDescriptionsListView;
        }
    }
}
