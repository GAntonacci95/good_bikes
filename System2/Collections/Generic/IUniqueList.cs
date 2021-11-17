using System;
using System.Collections.Generic;

namespace System2.Collections.Generic
{
    public interface IUniqueList<T> : IList<T> where T : IEquatable<T>
    {
        new void Add(T item);
        void AddRange(IEnumerable<T> collection);
    }
}
