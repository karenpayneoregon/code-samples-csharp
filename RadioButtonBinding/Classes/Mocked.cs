using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonBinding.Classes
{
    /// <summary>
    /// Provides mocked data so no database is needed
    /// </summary>
    public class Mocked
    {
        /// <summary>
        /// Provides several Person objects in a list.
        /// </summary>
        public static List<Person> PeopleList => new List<Person>
        {
            new Person() {FirstName = "Karen", LastName = "Payne", Sex = "F", SuffixType = SuffixType.Miss},
            new Person() {FirstName = "Bill", LastName = "Smith", Sex = "M", SuffixType = SuffixType.Mr},
            new Person() {FirstName = "Mary", LastName = "Jones", Sex = "F", SuffixType = SuffixType.Mrs},
            new Person() {FirstName = "Kim", LastName = "Adams", Sex = "F", SuffixType = SuffixType.Miss}
        };
    }
}
