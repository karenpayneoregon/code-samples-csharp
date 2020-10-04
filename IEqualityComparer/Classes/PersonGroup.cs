using System.Collections.Generic;

namespace IEqualityComparerApp.Classes
{
    public class PersonGroup
    {
        public int Id { get; set; }
        public int PersonCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Count { get; set; }
        public List<Person> PersonsList { get; set; }
    }
}