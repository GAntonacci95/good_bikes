using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2.Collections.Generic
{
    public interface IEventedList<T> : IList<T>
    {
        event EventHandler<EventedListAddedEventArgs<T>> Added;
        event EventHandler<EventedListRemovedEventArgs<T>> Removed;

        new void Add(T item);
        new bool Remove(T item);
        new void RemoveAt(int index);
    }
}
