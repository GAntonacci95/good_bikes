using System;
using System2.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public static partial class FactoryStatiElemento
    {
        private static Dictionary<string, StatoElemento> _registro;

        static FactoryStatiElemento()
        {
            _registro = new Dictionary<string, StatoElemento>();

            foreach (Type t in typeof(StatoElemento).GetSubtypes())
                _registro.Add(t.Name, (StatoElemento)Activator.CreateInstance(t));
        }

        public static StatoElemento GetStato(string chiave)
        {
            return _registro[chiave];
        }

        public static IEnumerable<string> NomeStatiElemento
        {
            get { return _registro.Keys; }
        }
        public static IEnumerable<StatoElemento> StatiElemento
        {
            get { return _registro.Values; }
        }
    }
}
