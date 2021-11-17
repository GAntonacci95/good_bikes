using System;
using System.Text;
using System.Collections.Generic;

namespace System2.Collections.Generic
{
    public static class DictionaryExtensions
    {
        public static string Tab<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            if (dict == null)
                throw new ArgumentException();

            string format = "{0}{1}{2}", div = "\t|\t";
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format(format, typeof(TKey).Name, div, typeof(TValue).Name));

            foreach (TKey k in dict.Keys)
                builder.AppendLine(string.Format(format, k, div, dict[k]));
            return builder.ToString();
        }
    }
}
