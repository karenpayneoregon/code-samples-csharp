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

namespace BindingExample_1
{
    public partial class Form1 : Form
    {
        private SortableBindingList<Person> peopleBindingList;
        private BindingSource peopleBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            peopleBindingList = new SortableBindingList<Person>(Mocked.PeopleList);
            peopleBindingSource.DataSource = Mocked.PeopleList;

            dataGridView1.DataSource = peopleBindingList;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void CurrentPersonButton_Click(object sender, EventArgs e)
        {
            if (peopleBindingSource.Current == null)
            {
                return;
            }

            var currentCustomer = peopleBindingList[peopleBindingSource.Position];
            MessageBox.Show($"{currentCustomer.Id}, {currentCustomer.FirstName}, {currentCustomer.LastName}");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileName = "TextFile1.txt";

            if (!File.Exists(fileName))
            {
                return;
            }

            var counter = 0;

            string line;

            using (var file = new StreamReader("TextFile1.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {

                    counter++;

                    if (!line.Contains("\"")) continue;
                    var result = line
                        .Select((value, index) => new { item = value, position = index })
                        .Where(item => item.item == '\"')
                        .ToList();

                    if (result.Count <= 0) continue;
                    {
                        Console.WriteLine($"{line}");
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.position);
                        }
                    }
                }
               
            }
        }
    }
}
