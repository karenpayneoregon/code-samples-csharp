
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewCombo1.Classes;

namespace DataGridViewCombo1
{
    public partial class Form1 : Form
    {
        readonly Operations _operations = new Operations();

        readonly BindingSource _customerBindingSource = new BindingSource();
        readonly BindingSource _vendorBindingSource = new BindingSource(); 
        readonly BindingSource _colorBindingSource = new BindingSource(); 

        public Form1()
        {
            InitializeComponent();

            CustomersDataGridView.CurrentCellDirtyStateChanged += _CurrentCellDirtyStateChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();

            CustomersDataGridView.AllowUserToAddRows = false ;
            _customerBindingSource.PositionChanged += _customerBindingSource_PositionChanged;

            LoadData();
            CurrentValuesView();

            ActiveControl = CustomersDataGridView;

        }

        private void _customerBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CurrentValuesView();
        }

        private void Setup()
        {

            _operations.LoadColorsReferenceDataTable();
            _operations.LoadVendorsReferenceDataTable();
            _vendorBindingSource.DataSource = _operations.VendorDataTable;
            _colorBindingSource.DataSource = _operations.ColorDataTable;


            ColorComboBoxColumn.DisplayMember = "ColorText";
            ColorComboBoxColumn.ValueMember = "ColorId";
            ColorComboBoxColumn.DataPropertyName = "ColorId";
            ColorComboBoxColumn.DataSource = _colorBindingSource;
            ColorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            VendorComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;

            VendorComboBoxColumn.DisplayMember = "VendorName";
            VendorComboBoxColumn.ValueMember = "VendorId";
            VendorComboBoxColumn.DataPropertyName = "VendorId";
            VendorComboBoxColumn.DataSource = _vendorBindingSource;
            VendorComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            VendorComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;

            QtyNumericUpDownColumn.DataPropertyName = "qty";
            InCartCheckBoxColumn.DataPropertyName = "InCart";

        }
        private void LoadData()
        {

            _operations.LoadCustomerDataTable();

            CustomersDataGridView.AutoGenerateColumns = false;

            ItemTextBoxColumn.DataPropertyName = "Item";
            _customerBindingSource.DataSource = _operations.CustomerDataTable;

            CustomersDataGridView.DataSource = _customerBindingSource;

        }
        private void _CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            CustomersDataGridView.CurrentCellDirtyStateChanged -= _CurrentCellDirtyStateChanged;
            CustomersDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CustomersDataGridView.CurrentCellDirtyStateChanged += _CurrentCellDirtyStateChanged;
        }
       

        private void CurrentValuesView()
        {

            if (_customerBindingSource.Current == null)
            {
                return;
            }

            var customerRow = ((DataRowView) _customerBindingSource.Current).Row;
            var customerPrimaryKey = customerRow.Field<int>("Id");
            var colorKey = customerRow.Field<int>("ColorId");
            var vendorKey = customerRow.Field<int>("VendorId");

            var vendorName = ((DataTable) _vendorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("VendorId") == vendorKey)
                .Field<string>("VendorName");

            var colorName = ((DataTable) _colorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == colorKey)
                .Field<string>("ColorText");


            DisplayInformationTextBox.Text =
                $"PK: {customerPrimaryKey} Vendor key {vendorKey} vendor: {vendorName} color id: {colorKey} - {colorName}";
        }
    }
}

