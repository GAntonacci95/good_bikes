using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public class CategorieAdapter
    {
        Type _type;

        public CategorieAdapter(Type type)
        {
            _type = type;
        }
        public string Nome { get { return _type.Name; } }
        public override string ToString()
        {
            return Nome;
        }
    }
}
