using System;
using System.Collections.Generic;

namespace IEqualityComparerApp.Classes
{
    public class CustomerByNameCountryCityComparer : IEqualityComparer<Customer>
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
                StringComparison.InvariantCultureIgnoreCase) && string.Equals(x.City, y.City,
                StringComparison.InvariantCultureIgnoreCase) && x.CountryIdentfier == y.CountryIdentfier;
        }

        public int GetHashCode(Customer obj)
        {
            unchecked
            {
                var hashCode = (obj.CompanyName != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(obj.CompanyName) : 0);
                hashCode = (hashCode * 397) ^ (obj.City != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(obj.City) : 0);
                hashCode = (hashCode * 397) ^ obj.CountryIdentfier.GetHashCode();
                return hashCode;
            }
        }

    }
}