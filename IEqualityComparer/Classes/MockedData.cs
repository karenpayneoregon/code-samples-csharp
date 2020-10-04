using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparerApp.Classes
{
    public class MockedData
    {
        public static List<Person> MockedPersons => new List<Person>()
        {
            new Person(1, "Ricardo", "Figueiredo"), //fist Duplicate to the example
            new Person(2, "Ana", "Figueiredo"),
            new Person(3, "Ricardo", "Figueiredo"), //second Duplicate to the example
            new Person(4, "Margarida", "Figueiredo"),
            new Person(5, "Ricardo", "Figueiredo") //third Duplicate to the example
        };
        public static IEnumerable<Customer> MockedCustomers() => new List<Customer>()
            {
                new Customer()
                {
                    CustomerIdentifier = 1, CompanyName = "Around the Horn", Street = "120 Hanover Sq.",
                    City = "London", PostalCode = "WA1 1DP", CountryIdentfier = 19,
                    Joined = new DateTime(2020,8,1)
                },
                new Customer()
                {
                    CustomerIdentifier = 2, CompanyName = "La maison d'Asie", Street = "1 rue Alsace-Lorraine",
                    City = "Toulouse", PostalCode = "31000", CountryIdentfier = 8, Joined = new DateTime(2020,8,11)
                },
                new Customer()
                {
                    CustomerIdentifier = 3, CompanyName = "La maison d'Asie", Street = "1 rue Alsace-Lorraine",
                    City = "Toulouse", PostalCode = "31000", CountryIdentfier = 9,
                    Joined = new DateTime(2020,8,1)
                },
                new Customer()
                {
                    CustomerIdentifier = 4, CompanyName = "La maison d'Asie", Street = "1 rue Alsace-Lorraine",
                    City = "Toulouse", PostalCode = "31000", CountryIdentfier = 8,
                    Joined = new DateTime(2020,8,1)
                },
                new Customer()
                {
                    CustomerIdentifier = 5, CompanyName = "Around the Horn", Street = "120 Hanover Sq.",
                    City = "London", PostalCode = "WA1 1DP", CountryIdentfier = 19,
                    Joined = new DateTime(2020,8,1)
                }
            };
    }
}

