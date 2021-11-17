using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System2.Reflection
{
    public static class ReflectionInformer
    {
        private static readonly string debugHost;
        private static readonly Assembly[] runningAssemblies;

        public static IEnumerable<Assembly> RunningAssemblies { get { return runningAssemblies; } }

        static ReflectionInformer()
        {
            debugHost = "vshost32";
            runningAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly => !assembly.GlobalAssemblyCache && assembly.GetName().Name != debugHost).ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyName">Project name</param>
        /// <returns></returns>
        public static Assembly GetAssembly(string assemblyName)
        {
            Assembly[] tmp = RunningAssemblies.Where(assembly => assembly.GetName().Name == assemblyName).ToArray();
            if (tmp.Length == 1)
                return tmp.First();
            else throw new Exception(string.Format("{0} assembly is not running: wrong name requested? not loaded yet?", assemblyName));
        }
        public static IEnumerable<Type> GetSubnamespaceTypes(this Assembly assembly, string subSpace)
        {
            return assembly.GetTypes().Where(t => t.Namespace == string.Format("{0}.{1}", assembly.GetName().Name, subSpace)).ToArray();
        }
        public static IEnumerable<Type> GetSubtypes(this Type T)
        {
            List<Type> list = new List<Type>();
            foreach (Assembly a in RunningAssemblies)
                list.AddRange(a.GetTypes().Where(t => t.IsSubclassOf(T)));
            return list;
        }
    }
}
