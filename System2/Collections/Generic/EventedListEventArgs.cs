using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2.Collections.Generic
{
    public abstract class EventedListEventArgs<T> : EventArgs
    {
        private T _item;
        public EventedListEventArgs(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item non può essere nullo");
            _item = item;
        }
        public T Item { get { return _item; } }
    }
    public class EventedListAddedEventArgs<T> : EventedListEventArgs<T>
    {
        public EventedListAddedEventArgs(T item) : base(item) { }
    }
    public class EventedListRemovedEventArgs<T> : EventedListEventArgs<T>
    {
        public EventedListRemovedEventArgs(T item) : base(item) { }
    }
}
