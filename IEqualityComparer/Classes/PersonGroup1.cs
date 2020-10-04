using System.Collections.Generic;

namespace IEqualityComparerApp.Classes
{
    public class PersonGroup1
    {
        public int Count { get; internal set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public List<Person> PersonsList { get; set; }
    }
}