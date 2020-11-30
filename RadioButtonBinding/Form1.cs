using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.Classes;

namespace RadioButtonBinding
{
    public partial class Form1 : Form
    {
        private BindingSource _peopleBindingSource = new BindingSource();
        private BindingList<Person> _peopleBindingList;

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            _peopleBindingList = new BindingList<Person>(Mocked.PeopleList);
            _peopleBindingSource.DataSource = _peopleBindingList;

            FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "LastName");

            var maleBinding = new Binding("Checked", _peopleBindingSource, "Sex");
            maleBinding.Format += MaleBinding_Format;
            maleBinding.Parse += MaleBinding_Parse;

            maleRadioButton.CheckedChanged += Male_CheckedChanged;
            maleRadioButton.DataBindings.Add(maleBinding);

            PeopleNavigator.BindingSource = _peopleBindingSource;
        }

        private void Male_CheckedChanged(object sender, EventArgs args)
        {
            femaleRadioButton.Checked = !maleRadioButton.Checked;
        }

        private void MaleBinding_Parse(object sender, ConvertEventArgs args)
        {
            args.Value = (bool)args.Value ? "M" : "F";
        }

        private void MaleBinding_Format(object sender, ConvertEventArgs args)
        {
            args.Value = ((string)args.Value) == "M";
        }
    }
}
