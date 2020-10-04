using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEqualityComparerApp.Classes;

namespace IEqualityComparerApp
{
    public partial class Form1 : Form
    {
        private List<Person> _persons;
        public Form1()
        {
            InitializeComponent();

            PersonList();
        }

        private void PersonList()
        {
            _persons = MockedData.MockedPersons;
        }

        private void CustomerByNameCountryCityComparerButton_Click(object sender, EventArgs e)
        {

            var customers = MockedData.MockedCustomers()
                .Distinct(new CustomerByNameCountryCityComparer())
                .ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            } 
        }

        private void NameSurnameEqualityComparerButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("nameSurNameCompareResults results");
            var nameSurNameCompareResults = _persons.Distinct(new NameSurnameEqualityComparer()).ToList();

            foreach (var person in nameSurNameCompareResults)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            Console.WriteLine("groupResultsAnonymous results");
            var groupResultsAnonymous = _persons 
                .GroupBy((person) => new { person.Name, person.Surname })
                .Select((g) => new 
                {
                    PersonCount = g.Count(),
                    FirstName = g.Key.Name,
                    LastName = g.Key.Surname,
                    Id = g.FirstOrDefault().Id,
                    Count = g.Count(),
                    List = g.ToList()
                }).Where(personGroup => personGroup.PersonCount > 1).ToList();


            foreach (var personGroup in groupResultsAnonymous)
            {
                Console.WriteLine($"{personGroup.Id} {personGroup.FirstName} {personGroup.LastName} {personGroup.Count -1} => " + 
                                  $"{string.Join(",", personGroup.List.Select(personItem => personItem.Id).ToArray())}");
            }

            Console.WriteLine();

            Console.WriteLine("groupResults1 results");

            List<PersonGroup1> groupResults1 = _persons
                .GroupBy((person) => new { person.Name, person.Surname })
                .Select((g) => 
                    new PersonGroup1()
                    {
                        Count = g.Count(),
                        FirstName = g.Key.Name,
                        SurName = g.Key.Surname,
                        PersonsList = g.ToList()
                    })
                .Where(personGroup => personGroup.Count >1)
                .ToList();


            foreach (var personGroup in groupResults1)
            {
                Console.WriteLine($"{personGroup.FirstName} {personGroup.SurName} => " + 
                                  $"{string.Join(",",personGroup.PersonsList.Select(x => x.Id).ToArray())}");
            }

            Console.WriteLine();

            Console.WriteLine("groupResults2 results");

            List<PersonGroup> groupResults2 =  _persons
                .GroupBy((person) => new { person.Name, person.Surname })
                .Select((g) => new PersonGroup
                {
                    PersonCount = g.Count(),
                    FirstName = g.Key.Name,
                    LastName = g.Key.Surname,
                    Id = g.FirstOrDefault().Id,
                    Count = g.Count(),
                    PersonsList = g.ToList()
                }).Where(personGroup => personGroup.PersonCount > 1).ToList();


            foreach (var personGroup in groupResults2)
            {
                Console.WriteLine($"{personGroup.Id} {personGroup.FirstName} {personGroup.LastName} => " + 
                                  $"{string.Join(",", personGroup.PersonsList.Select(x => x.Id).ToArray())}");
            }

            foreach (var personGroup in groupResults2)
            {
                Console.WriteLine($"{personGroup.Id} {personGroup.FirstName} {personGroup.LastName} => ");
                foreach (var person in personGroup.PersonsList.Skip(1))
                {
                    Console.WriteLine($"{person.Id,3}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("groupResults3 results");
            List<PersonGroup2> groupResults3 = _persons
                .GroupBy((person) => new { person.Name, person.Surname })
                .Select((g) => new PersonGroup2
                {
                    PersonCount = g.Count(),
                    FirstName = g.Key.Name,
                    LastName = g.Key.Surname,
                    Id = g.FirstOrDefault().Id,
                    Count = g.Count(),
                    IdentifiersList = g.Select(x => x.Id).ToList()
                }).Where(personGroup => personGroup.PersonCount > 1).ToList();


            foreach (var personGroup in groupResults3)
            {
                Console.WriteLine($"{personGroup.Id} {personGroup.FirstName} {personGroup.LastName} => {string.Join(",", personGroup.IdentifiersList)}");
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }



}
