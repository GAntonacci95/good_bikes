using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System2
{
    public static class ObjectExtensions
    {
        public static PropertyInfo GetPropertyInfo(this object o, string propertyName)
        {
            return o.GetType().GetProperty(propertyName);
        }
        public static EventInfo GetEventInfo(this object o, string eventName)
        {
            return o.GetType().GetEvent(eventName);
        }
        internal static object DoInvoke(object on, MethodInfo method, object param)
        {
            return method.Invoke(on, param == null ? null : new object[] { param });
        }
    }

    public static class ObjectPropertyExtensions
    {
        public static T GetPropertyValue<T>(this object o, string propertyName)
        {
            PropertyInfo pi = o.GetPropertyInfo(propertyName);
            return (T)ObjectExtensions.DoInvoke(o, pi.GetMethod, null);
        }
        public static object GetPropertyValue(this object o, PropertyInfo pi)
        {
            return ObjectExtensions.DoInvoke(o, pi.GetMethod, null);
        }

        public static void SetPropertyValue<T>(this object o, string propertyName, T val)
        {
            PropertyInfo pi = o.GetPropertyInfo(propertyName);
            ObjectExtensions.DoInvoke(o, pi.SetMethod, val);
        }
        public static void SetPropertyValue(this object o, PropertyInfo pi, object val)
        {
            ObjectExtensions.DoInvoke(o, pi.SetMethod, val);
        }
    }

    public static class ObjectEventExtensions
    {
        public static void AddEventHandler<T>(this object o, string eventName, T handler)
        {
            EventInfo ei = o.GetEventInfo(eventName);
            ObjectExtensions.DoInvoke(o, ei.AddMethod, handler);
        }
        public static void AddEventHandler(this object o, EventInfo ei, object handler)
        {
            ObjectExtensions.DoInvoke(o, ei.AddMethod, handler);
        }

        public static void RemoveEventHandler<T>(this object o, string eventName, T handler)
        {
            EventInfo ei = o.GetEventInfo(eventName);
            ObjectExtensions.DoInvoke(o, ei.RemoveMethod, handler);
        }
        public static void RemoveEventHandler(this object o, EventInfo ei, object handler)
        {
            ObjectExtensions.DoInvoke(o, ei.RemoveMethod, handler);
        }
    }
}
