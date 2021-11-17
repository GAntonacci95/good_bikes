using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace System2.ComponentModel
{
    //Utilizzabile solo per Component non aggiunti RT
    static class ComponentExtensions
    {
        //Ringraziamenti StackExchange
        public static IEnumerable<Component> GetComponents(this Component st)
        {
            return from field in st.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                   where typeof(Component).IsAssignableFrom(field.FieldType)
                   let component = (Component)field.GetValue(st)
                   where component != null
                   select component;
        }
        public static IEnumerable<T> GetComponents<T>(this Component st)
        {
            return st.GetComponents().Where(comp => comp.GetType() == typeof(T)).Cast<T>();
        }

        public static IEnumerable<Component> GetStringTaggedComponents(this Component st)
        {
            return st.GetComponents().Where(comp =>
            {
                object tag = comp.GetPropertyValue<object>("Tag");
                return tag != null && tag.GetType() == typeof(string) && !string.IsNullOrEmpty(comp.GetPropertyValue<string>("Tag"));
            });
        }

        public static Component GetComponentByTagName(this Component st, string tag)
        {
            foreach (Component c in st.GetStringTaggedComponents())
                if (tag == c.GetPropertyValue<string>("Tag"))
                    return c;
            return null;
        }
        public static Component GetComponentByName(this Component st, string name)
        {
            foreach (Component c in st.GetComponents())
                if (name == c.GetPropertyValue<string>("Name"))
                    return c;
            return null;
        }
    }
}
