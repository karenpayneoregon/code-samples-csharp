using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncrementalSearchTextBox.Classes;
using IncrementalSearchTextBox.Containers;

namespace IncrementalSearchTextBox
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _girlNamesBindingSource = new BindingSource();
        private BindingList<GirlName> _girlsNamesBindingList;  

        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
            SearchTextBox.TextChanged += SearchTextBoxOnTextChanged;
        }

        private void SearchTextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (_girlNamesBindingSource == null) return;

            List<GirlName> filtered = _girlsNamesBindingList.Where(nameItem => 
                nameItem.DisplayText.StartsWith(
                    SearchTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            _girlNamesBindingSource.DataSource = filtered;

        }

        private void OnShown(object sender, EventArgs e)
        {
            if (!FileOperations.GirlFileExits)
            {
                FileOperations.CreateGirlFile();
            }
            
            _girlsNamesBindingList = new BindingList<GirlName>(FileOperations.ReadGirlNames());
            _girlNamesBindingSource.DataSource = _girlsNamesBindingList;
            GirlsNameListBox.DataSource = _girlNamesBindingSource;

        }
    }
}
