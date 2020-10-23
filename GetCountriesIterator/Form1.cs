using System;
using System.Windows.Forms;
using IteratingCodeSample;
using IteratingCodeSample.Classes;

namespace GetCountriesIterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Operations.DisplayInformationHandler += Operations_DisplayInformationHandler;

            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await Operations.GetCountries();

            CountryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            CountryListView.FocusedItem = CountryListView.Items[0];
            CountryListView.Items[0].Selected = true;

            ActiveControl = CountryListView;
        }

        private void Operations_DisplayInformationHandler(Countries sender)
        {
            CountryListView.Items.Add(new ListViewItem(sender.ItemArray) );
        }
    }
}
