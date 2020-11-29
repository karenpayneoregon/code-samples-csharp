using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerInsertList;

namespace SqlDelimited
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Operations.OnExceptionEvent += Operations_OnExceptionEvent;
        }

        private void Operations_OnExceptionEvent(Exception exception)
        {
            MessageBox.Show($"Oooops\n{exception.Message}");
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var companyNames = Operations.CompanyNamesDelimited();
            ResultsTextBox.Text = companyNames;
        }
    }
}
