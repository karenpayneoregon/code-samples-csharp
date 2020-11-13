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
using TempFilesOperations.Classes;

namespace TempFilesOperations
{
    public partial class Form1 : Form
    {
        private BindingList<Customer> _bindingList;
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FileOperations.WriteXml();

            dataGridView1.AutoGenerateColumns = false;

            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{Guid.NewGuid()}.kp");
            FileOperations.InitializeFileStream(fileName);
            var customers = FileOperations.ReadCustomersFromXml();

            _bindingList = new BindingList<Customer>(customers);
            _bindingSource.DataSource = _bindingList;
            dataGridView1.DataSource = _bindingSource;

        }

        private void WriteChangesButton_Click(object sender, EventArgs e)
        {
            FileOperations.WriteXml(_bindingList.ToList());
        }
    }
}
;