using System;
using System.Collections.Generic;

namespace IEqualityComparerApp.Classes
{
    public class NameSurnameEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return string.Equals(x.Name, y.Name, 
                       StringComparison.InvariantCultureIgnoreCase) && 
                   string.Equals(x.Surname, y.Surname, 
                       StringComparison.InvariantCultureIgnoreCase);
        }

        public int GetHashCode(Person person)
        {
            unchecked
            {
                return ((person.Name != null ? 
                    StringComparer.InvariantCultureIgnoreCase.GetHashCode(person.Name) : 0) * 397) ^ (person.Surname != null ? 
                    StringComparer.InvariantCultureIgnoreCase.GetHashCode(person.Surname) : 0);
            }
        }
    }
}