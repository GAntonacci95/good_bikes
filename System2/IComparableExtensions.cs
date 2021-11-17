using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2
{
    public static class IComparableExtensions
    {
        public static bool Between<T>(this T item, T start, T end) where T : IComparable<T>
        {
            return item.CompareTo(start) >= 0 && item.CompareTo(end) <= 0;
        }
    }
}
