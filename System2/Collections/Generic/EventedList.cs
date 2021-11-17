using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2.Collections.Generic
{
    public class EventedList<T> : List<T>, IEventedList<T>
    {
        public event EventHandler<EventedListAddedEventArgs<T>> Added;
        public event EventHandler<EventedListRemovedEventArgs<T>> Removed;

        public EventedList() : base() { }
        public EventedList(IEnumerable<T> collection) : base(collection) { }

        private void OnAdded(T item)
        {
            if (Added != null)
                Added(this, new EventedListAddedEventArgs<T>(item));
        }
        private void OnRemoved(T item)
        {
            if (Removed != null)
                Removed(this, new EventedListRemovedEventArgs<T>(item));
        }

        new public void Add(T item)
        {
            base.Add(item);
            OnAdded(item);
        }
        new public bool Remove(T item)
        {
            if (base.Remove(item))
            {
                OnRemoved(item);
                return true;
            }
            return false;
        }
        new public void RemoveAt(int index)
        {
            T tmp=default(T);
            if (index < base.Count)
                tmp = base[index];
            base.RemoveAt(index);
            //se non esplodo prima
            OnRemoved(tmp);
        }
    }
}
