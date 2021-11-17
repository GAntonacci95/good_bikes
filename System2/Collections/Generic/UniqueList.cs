using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2.Collections.Generic
{
    public class UniqueList<T> : List<T>, IUniqueList<T> where T : IEquatable<T>
    {
        public UniqueList() : base() { }

        new public void Add(T item)
        {
            if (this.Contains(item))
                throw new InvalidOperationException("UniqueList - already contains this item");
            base.Add(item);
        }
        new public void AddRange(IEnumerable<T> collection)
        {
            foreach (T item in collection)
                this.Add(item);
        }
    }
}
