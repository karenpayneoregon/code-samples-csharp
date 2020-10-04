using System;
using System.Collections.Generic;

namespace IEqualityComparerApp.Classes
{
    public class CustomerByNameJoinedComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return string.Equals(
                x.CompanyName,
                y.CompanyName,
                StringComparison.InvariantCultureIgnoreCase) && x.Joined.Equals(y.Joined);
        }

        public int GetHashCode(Customer obj)
        {
            unchecked
            {
                return ((obj.CompanyName != null ?
                    StringComparer.InvariantCultureIgnoreCase.GetHashCode(obj.CompanyName) 
                    : 0) * 397) ^ obj.Joined.GetHashCode();
            }
        }

    }
}