using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SqlServerUtilities.Classes;

namespace SqlServerUtilitiesFrontEnd
{
    public partial class ColumnsDetailForm : Form
    {
        private readonly SqlInformation _tableInformation = new SqlInformation();

        public ColumnsDetailForm()
        {
            InitializeComponent();

            Shown += Form1_Shown;

            ColumnDetailsListView.ItemSelectionChanged += ColumnDetailsListView_ItemSelectionChanged;
            tableInformationComboBox.SelectedIndexChanged += TableInformationComboBox_SelectedIndexChanged;
        }


        /// <summary>
        /// Set description text box with (if present) the description for the
        /// current column.
        ///
        /// Note: if (e.IsSelected) prevents a common issue with developers of
        /// a double trigger of the ItemSelectionChanged change event where one
        /// time the item is not the selected item even though it will be the
        /// selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnDetailsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                DescriptionTextBox.Text = e.Item.Tag.ToString();
            }
            
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            var items = _tableInformation.TableDependencies();
            tableInformationComboBox.DataSource = new BindingSource(items, null);
            tableInformationComboBox.DisplayMember = "Key";
        }
        /// <summary>
        /// Retrieve column details for selected table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetInformationButton_Click(object sender, EventArgs e)
        {
            Display();
        }
        private void TableInformationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }


        private void Display()
        {
            ColumnDetailsListView.Items.Clear();

            var detailItems = ((KeyValuePair<string, List<ServerTableItem>>) tableInformationComboBox.SelectedItem);

            foreach (var serverTableItem in detailItems.Value)
            {

                var item = ColumnDetailsListView.Items.Add(serverTableItem.FieldOrder.ToString());

                item.SubItems.Add(serverTableItem.Field);
                item.SubItems.Add(serverTableItem.DataType);
                item.SubItems.Add(serverTableItem.Length.ToString());
                item.SubItems.Add(serverTableItem.Precision);
                item.SubItems.Add(serverTableItem.Scale.ToString());
                item.SubItems.Add(serverTableItem.AllowNulls);
                item.SubItems.Add(serverTableItem.Identity);
                item.SubItems.Add(serverTableItem.PrimaryKey);
                item.SubItems.Add(serverTableItem.ForeignKey);
                item.SubItems.Add(serverTableItem.RelatedTable);

                item.Tag = serverTableItem.Description;

            }

            ColumnDetailsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ColumnDetailsListView.FocusedItem = ColumnDetailsListView.Items[0];
            ColumnDetailsListView.Items[0].Selected = true;

            ActiveControl = ColumnDetailsListView;

            /*
             * Shade alternate rows
             */
            var index = 0;
            var shadedBackgroundColor = Color.FromArgb(240, 240, 240);

            foreach (ListViewItem item in ColumnDetailsListView.Items)
            {
                if (index++ % 2 != 1) continue;

                item.BackColor = shadedBackgroundColor;
                item.UseItemStyleForSubItems = true;
            }
        }
    }
}
