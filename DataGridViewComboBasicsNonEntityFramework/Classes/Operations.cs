using System.Data;
using System.Data.SqlClient;

namespace DataGridViewCombo1.Classes
{
    public class Operations
    {
        /*
         * Make sure the databasescript file is executed and that the
         * Data Source points to the correct server if not SQL-Server Express.
         */
        private string ConnectionString = "Data Source=.\\sqlexpress;Initial " +
            "Catalog=DataGridViewCodeSample;Integrated Security=True";

        public DataTable ColorDataTable { get; set; }
        public DataTable VendorDataTable { get; set; }

        private DataTable _customerTable = new DataTable();
        public DataTable CustomerDataTable
        {
            get => _customerTable;
            set => _customerTable = value;
        }

        /// <summary>
        /// Load main table for DataGridView
        /// </summary>
        public void LoadCustomerDataTable()
        {
            CustomerDataTable = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();
                    cmd.CommandText = "SELECT id,Item,ColorId,CustomerId, qty, InCart, VendorId  FROM Product";
                    CustomerDataTable.Load(cmd.ExecuteReader());
                }
            }
        }

        /// <summary>
        /// Load color reference table
        /// </summary>
        public void LoadColorsReferenceDataTable()
        {
            ColorDataTable = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();
                    cmd.CommandText = "SELECT ColorId,ColorText FROM Colors";
                    ColorDataTable.Load(cmd.ExecuteReader());
                }
            }
        }

        /// <summary>
        /// Load vendor reference table
        /// </summary>
        public void LoadVendorsReferenceDataTable()
        {
            VendorDataTable = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();
                    cmd.CommandText = "SELECT VendorId,VendorName FROM dbo.Vendors";
                    VendorDataTable.Load(cmd.ExecuteReader());
                }
            }
        }
    }
}
