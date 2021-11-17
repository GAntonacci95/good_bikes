using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public abstract class Agevolazione : IEquatable<Agevolazione>
    {
        private string _nome;
        private string _descrizione;

        public string Nome { get { return _nome; } }
        public string Descrizione { get { return _descrizione; } }

        protected Agevolazione(string nome, string descrizione)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome non può essere nullo o vuoto");
            if (string.IsNullOrEmpty(descrizione))
                throw new ArgumentException("descrizione non può essere nullo o vuoto");
            _nome = nome;
            _descrizione = descrizione;
        }

        #region IEquatable<Agevolazione>Members
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Agevolazione))
                return false;
            return Nome == (obj as Agevolazione).Nome;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Agevolazione other)
        {
            return Equals((object)other);
        }
        public static bool operator ==(Agevolazione a1, Agevolazione a2)
        {
            return a1.Equals(a2);
        }
        public static bool operator !=(Agevolazione a1, Agevolazione a2)
        {
            return !a1.Equals(a2);
        }
        #endregion

        public override string ToString()
        {
            return _nome;
        }
    }
}
