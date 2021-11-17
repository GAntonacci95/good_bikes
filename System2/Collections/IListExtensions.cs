using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace System2.Collections
{
    public static class IListExtensions
    {
        public static T Before<T>(this IList<T> list, T one) where T : class, IEquatable<T>
        {
            int index = list.IndexOf(one);
            if (index > 0)
                return list[index - 1];

            return default(T);
        }

        public static T After<T>(this IList<T> list, T one) where T : class, IEquatable<T>
        {
            int index = list.IndexOf(one);
            if (index < list.Count - 1)
                return list[index + 1];

            return default(T);
        }
    }
}
