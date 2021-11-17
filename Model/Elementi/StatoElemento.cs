using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public abstract class StatoElemento : IEquatable<StatoElemento>
    {
        //public abstract string Nome { get; }
        public string Nome { get { return GetType().Name; } }
        public abstract string Descrizione { get; }

        protected StatoElemento() { }

        public abstract bool IsLibero(Elemento e);

        public sealed override string ToString()
        {
            return Nome;
        }

        #region IEquatable<StatoElemento>
        public sealed override bool Equals(object obj)
        {
            if (obj == null || !(obj is StatoElemento))
                return false;
            return GetType() == obj.GetType();
        }
        public sealed override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(StatoElemento other)
        {
            return Equals((object)other);
        }
        #endregion
    }
}
