using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonBinding.Classes
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
            new Person()
            {
                Id = 1,
                FirstName = "Karen",
                LastName = "Payne",
                Suffix = EnumConverter<SuffixType>.Convert(3),
                Gender = EnumConverter<GenderType>.Convert(1)
            },
            new Person()
            {
                Id = 2,
                FirstName = "Bill",
                LastName = "Smith",
                Suffix = EnumConverter<SuffixType>.Convert(1),
                Gender =  EnumConverter<GenderType>.Convert(2)
            },
            new Person()
            {
                Id = 3,
                FirstName = "Mary",
                LastName = "Jones",
                Suffix = EnumConverter<SuffixType>.Convert(2),
                Gender = EnumConverter<GenderType>.Convert(3)
            },
            new Person()
            {
                Id = 4,
                FirstName = "Kim",
                LastName = "Adams",
                Suffix = EnumConverter<SuffixType>.Convert(3),
                Gender = EnumConverter<GenderType>.Convert(1)
            }
        };
    }
}
