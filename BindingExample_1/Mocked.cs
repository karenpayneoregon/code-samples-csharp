using System.Collections.Generic;

namespace BindingExample_1
{
    /// <summary>
    /// Provides mocked data so no database is needed
    /// Note Gender and Suffix for a real app would be stored as int,
    /// thus we need to convert to enum which is much easier to read
    /// than an int.
    /// </summary>
    public class Mocked
    {
        /// <summary>
        /// Provides several Person objects in a list.
        /// </summary>
        public static List<Person> PeopleList => new List<Person>
        {
            new Person() {Id = 1, FirstName = "Karen", LastName = "Payne"},
            new Person() {Id = 2, FirstName = "Bill", LastName = "Smith"},
            new Person() {Id = 3, FirstName = "Mary", LastName = "Jones"},
            new Person() {Id = 4, FirstName = "Kim", LastName = "Adams"}
        };
    }
}
