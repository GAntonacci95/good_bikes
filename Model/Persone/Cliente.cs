using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Persone
{
    public abstract class Cliente : IEquatable<Cliente>
    {
        private string _nome;
        private string _recapito;

        [Editable("Nome")]
        public string Nome {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il nome non può essere vuoto");
                _nome = value;
            }
        }

        [Editable("Recapito")]
        public string Recapito {
            get { return _recapito; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il recapito non può essere vuoto");
                _recapito = value;
            }
        }
        protected Cliente() { }
        protected Cliente(string nome, string recapito)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("nome non può essere nullo o vuoto");
            if (string.IsNullOrEmpty(recapito))
                throw new ArgumentException("recapito non può essere nullo o vuoto");
            _nome = nome;
            _recapito = recapito;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Cliente))
                return false;
            return Nome == (obj as Cliente).Nome;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Cliente other)
        {
            return Equals((object)other);
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !c1.Equals(c1);
        }
    }
}
