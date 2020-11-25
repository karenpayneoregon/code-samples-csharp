using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssemblyExtensions;
using ClassesWhichImplementInterface.Classes;
using ClassesWhichImplementInterface.Interfaces;

namespace ClassesWhichImplementInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Get all types implementing IBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var types = typeof(IBase).GetImplementingTypesGeneral().Select(type => type.Name).ToList();
            var types1 = typeof(IBase).GetImplementingTypesWithConstructor().Select(type => type.Name).ToList();
        }
        /// <summary>
        /// Does class instance implement IBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var product = new Product() {ProductId = 1};
            if (product is IBase prod)
            {
                
                Console.WriteLine(prod.Id);
            }
            else
            {
                Console.WriteLine("Product does not implement interface");
            }

            var customer = new Customer();

            if (customer is IBase cust)
            {
                Console.WriteLine(@"Yes customer implements interface");
            }
            else
            {
                Console.WriteLine("Customer does not implement interface");
            }
        }
    }
}
