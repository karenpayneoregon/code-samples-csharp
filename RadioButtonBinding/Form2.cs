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
    public partial class Form2 : Form
    {
        private BindingSource _peopleBindingSource = new BindingSource();
        private BindingList<Person> _peopleBindingList;

        public Form2()
        {
            InitializeComponent();

            Shown += Form2_Shown;

            MrRadioButton.Tag = 1;
            MrsRadioButton.Tag = 2;
            MissRadioButton.Tag = 3;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            SuffixRadioGroupBox.SelectedChanged += SuffixRadioGroupBox_SelectedChanged;
            
            _peopleBindingList = new BindingList<Person>(Mocked.PeopleList);
            _peopleBindingSource.DataSource = _peopleBindingList;

            SuffixRadioGroupBox.DataBindings.Add("Selected", this._peopleBindingSource, "SuffixType");

            FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "LastName");

            PeopleNavigator.BindingSource = _peopleBindingSource;

        }
        /// <summary>
        /// Update current person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuffixRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
        {
            _peopleBindingList[_peopleBindingSource.Position].SuffixType = (SuffixType) e.Selected;
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var person in _peopleBindingList)
            {
                sb.AppendLine($"{person.SuffixType,4} {person.FullName}");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
