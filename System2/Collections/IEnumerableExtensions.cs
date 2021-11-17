using System;
using System.Collections;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Text;

namespace System2.Collections
{
    public static class IEnumerableExtensions
    {
        public static IEventedList<T> ToEventedList<T>(this IEnumerable<T> collection)
        {
            return new EventedList<T>(collection);
        }
    }
}
