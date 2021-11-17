using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2.Collections.Generic
{
    public class OrderedList<T> : List<T> where T : class, IComparable<T>
    {
        public OrderedList() : base() { }

        new public void Add(T item)
        {
            base.Add(item);
            base.Sort();
        }
    }
}
