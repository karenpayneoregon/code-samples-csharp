using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAddMethod
{
    class MockedData
    {
        public static List<Person> GetPeople1()
        {
            var people = new List<Person>()
            {
                new Person() { Id = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Id = 2, FirstName = "Mike", LastName = "Adams" },
                new Person() { Id = 3, FirstName = "Karen", LastName = "Payne" }
            };

            return people;
        }
        public static List<Person> GetPeople2()
        {
            var people = new List<Person>();

            var person1 = new Person() { Id = 1, FirstName = "Karen", LastName = "Payne" };
            var person2 = new Person() { Id = 2, FirstName = "Mike", LastName = "Adams" };
            var person3 = new Person() { Id = 3, FirstName = "Karen", LastName = "Payne" };
            people.AddRange(new Person[] { person1, person2, person3 });


            return people;
        }
    }
}
