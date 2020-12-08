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
    public partial class MainForm : Form
    {
        private BindingSource _peopleBindingSource = new BindingSource();
        private BindingList<Person> _peopleBindingList;

        public MainForm()
        {
            InitializeComponent();

            Shown += MainForm_Shown;

            MrRadioButton.Tag = 1;
            MrsRadioButton.Tag = 2;
            MissRadioButton.Tag = 3;

            FemaleRadioButton.Tag = 1;
            MaleRadioButton.Tag = 2;
            OtherRadioButton.Tag = 3;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SuffixRadioGroupBox.SelectedChanged += SuffixRadioGroupBox_SelectedChanged;
            GenderRadioGroupBox.SelectedChanged += GenderRadioGroupBox_SelectedChanged;
            
            _peopleBindingList = new BindingList<Person>(Mocked.PeopleList);
            _peopleBindingSource.DataSource = _peopleBindingList;

            SuffixRadioGroupBox.DataBindings.Add("Selected", _peopleBindingSource, "Suffix");
            GenderRadioGroupBox.DataBindings.Add("Selected", _peopleBindingSource, "Gender");

            FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "LastName");

            PeopleNavigator.BindingSource = _peopleBindingSource;

        }

        private void GenderRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
        {
            _peopleBindingList[_peopleBindingSource.Position].Gender = (GenderType)e.Selected;
        }

        /// <summary>
        /// Update current person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuffixRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
        {
            _peopleBindingList[_peopleBindingSource.Position].Suffix = (SuffixType) e.Selected;
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var person in _peopleBindingList)
            {
                sb.AppendLine($"{person.Suffix,4} {person.FullName} {person.Gender}");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
