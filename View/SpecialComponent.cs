using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace View
{
    public class SpecialComponent : IShared
    {
        private readonly Component _component;
        private readonly Dictionary<string, MethodInfo[]> _propertyMap; //getter setter ordinati
        private readonly Dictionary<string, MethodInfo[]> _eventMap; //add remove ordinati

        public SpecialComponent(Component component)
        {
            if (component == null)
                throw new ArgumentNullException("component");
            _propertyMap = new Dictionary<string, MethodInfo[]>();
            foreach (PropertyInfo pi in typeof(IShared).GetProperties())
            {
                PropertyInfo pi2 = component.GetType().GetProperty(pi.Name);
                if (pi2 == null || pi2.PropertyType != pi.PropertyType)
                    throw new ArgumentException("Not a valid SpecialComponent");
                else
                    _propertyMap.Add(pi2.Name, new MethodInfo[] { pi2.GetMethod, pi2.SetMethod });
            }
            _eventMap = new Dictionary<string, MethodInfo[]>();
            foreach (EventInfo ei in typeof(IShared).GetEvents())
            {
                EventInfo ei2 = component.GetType().GetEvent(ei.Name);
                if (ei2 == null || ei2.EventHandlerType != ei.EventHandlerType)
                    throw new ArgumentException("Not a valid SpecialComponent");
                else
                    _eventMap.Add(ei2.Name, new MethodInfo[] { ei2.AddMethod, ei2.RemoveMethod });
            }

            _component = component;
        }

        private T Get<T>(string propertyName)
        {
            return (T)_propertyMap[propertyName][0].Invoke(_component, null);
        }
        private void Set<T>(string propertyName, T val)
        {
            _propertyMap[propertyName][1].Invoke(_component, new object[] { val });
        }

        private void Add(string eventName, EventHandler del)
        {
            _eventMap[eventName][0].Invoke(_component, new object[] { del });
        }
        private void Remove(string eventName, EventHandler del)
        {
            _eventMap[eventName][1].Invoke(_component, new object[] { del });
        }

        public object Tag
        {
            get { return Get<object>("Tag"); }
            set { Set<object>("Tag", value); }
        }

        public bool Enabled
        {
            get { return Get<bool>("Enabled"); }
            set { Set<bool>("Enabled", value); }
        }

        public event EventHandler Click
        {
            add { Add("Click", value); }
            remove { Remove("Click", value); }
        }
    }
}
