
using System;
using System.Data;
using System.Drawing;
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

            //see comments in event code.
            //CustomersDataGridView.CellFormatting += CustomersDataGridView_CellFormatting;

        }
        /// <summary>
        /// To be moved out of here, placed here to reply to a forum question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == CustomersDataGridView.Columns["ColorComboBoxColumn"].Index && CustomersDataGridView.Rows[e.RowIndex].DataBoundItem != null)
            {
                var colorKeyValue = ((DataRowView)CustomersDataGridView.Rows[e.RowIndex].DataBoundItem).Row.Field<int>("ColorId");
                if (colorKeyValue == 2)
                {
                    //CustomersDataGridView.Rows[e.RowIndex].Cells[CustomersDataGridView.Columns["ColorComboBoxColumn"].Index].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Tomato };

                    CustomersDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    //CustomersDataGridView.Rows[e.RowIndex].Cells[CustomersDataGridView.Columns["ColorComboBoxColumn"].Index].Style = null;
                    CustomersDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                }
            }
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

            #region Get primary table information

            var customerRow = ((DataRowView)_customerBindingSource.Current).Row;
            var customerPrimaryKey = customerRow.Field<int>("Id");
            var colorKey = customerRow.Field<int>("ColorId");
            var vendorKey = customerRow.Field<int>("VendorId");

            #endregion

            #region Get child table information

            var vendorName = ((DataTable)_vendorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("VendorId") == vendorKey)
                .Field<string>("VendorName");

            var colorName = ((DataTable)_colorBindingSource.DataSource)
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<int>("ColorId") == colorKey)
                .Field<string>("ColorText");

            #endregion


            DisplayInformationTextBox.Text =
                $"PK: {customerPrimaryKey} Vendor key {vendorKey} vendor: {vendorName} color id: {colorKey} - {colorName}";
        }
    }
}

