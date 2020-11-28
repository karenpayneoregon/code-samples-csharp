using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageHelpers.Classes.Containers
{
    public static class CollectionExtension
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector) 
        {
            HashSet<TResult> set = new HashSet<TResult>();

            foreach (var item in source)
            {
                var selectedValue = selector(item);

                if (set.Add(selectedValue))
                {
                    yield return item;
                }
            }
        }
        public static void AddUniqueItem<T>(this List<T> list, T item, bool throwException)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
            else if (throwException)
            {
                throw new InvalidOperationException("Item already exists in the list");
            }
        }
        public static bool IsUnique<T>(this List<T> list, IEqualityComparer<T> comparer)
        {
            return list.Count == list.Distinct(comparer).Count();
        }
        public static bool IsUnique<T>(this List<T> list)
        {
            return list.Count == list.Distinct().Count();
        }
    }
}
