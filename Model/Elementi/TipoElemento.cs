using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Model.Elementi
{
    public abstract class TipoElemento : IEquatable<TipoElemento>, IComparable<TipoElemento>
    {
        private string _nome;
        private string _descrizione;
        private float _tariffaBase;
        private StatoTipoElemento _stato;

        #region Proprietà
        
        [Editable("Nome", true)]
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("nome non può essere nullo o vuoto");
                _nome = value;
            }
        }

        [Editable("Descrizione")]
        public string Descrizione
        {
            get { return _descrizione; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("descrizione non può essere nullo o vuoto");
                _descrizione = value;
            }
        }

        [Editable("Tariffa base")]
        public float TariffaBase
        {
            get { return _tariffaBase; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("tariffaBase non può essere <= 0");
               _tariffaBase = value;
            }
        }

        public StatoTipoElemento Stato
        {
            get { return _stato; }
            set { _stato = value; }
        }
        #endregion

        protected TipoElemento()
        {
            _stato = StatoTipoElemento.Attivo;
        }
        protected TipoElemento(string nome, string descrizione, float tariffaBase, StatoTipoElemento statoTipo)
        {
            Nome = nome;
            Descrizione = descrizione;
            TariffaBase = tariffaBase;
            Stato = statoTipo;
        }

        public override string ToString()
        {
            return Nome;
        }

        #region IEquatable<TipoElemento>Members
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TipoElemento))
                return false;
            return Nome == (obj as TipoElemento).Nome;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(TipoElemento other)
        {
            return Equals((object)other);
        }
        public static bool operator ==(TipoElemento e1, TipoElemento e2)
        {
            return e1.Equals(e2);
        }
        public static bool operator !=(TipoElemento e1, TipoElemento e2)
        {
            return !e1.Equals(e2);
        }
        #endregion

        #region IComparable<TipoElemento>Members
        public int CompareTo(TipoElemento other)
        {
            if (other == null)
                throw new ArgumentNullException("other non può essere nullo");
            return Math.Sign(this.TariffaBase-other.TariffaBase);
        }

        public static bool operator >(TipoElemento e1, TipoElemento e2)
        {
            return e1.CompareTo(e2) > 0;
        }
        public static bool operator >=(TipoElemento e1, TipoElemento e2)
        {
            return e1.CompareTo(e2) >= 0;
        }
        public static bool operator <(TipoElemento e1, TipoElemento e2)
        {
            return e1.CompareTo(e2) < 0;
        }
        public static bool operator <=(TipoElemento e1, TipoElemento e2)
        {
            return e1.CompareTo(e2) <= 0;
        }
        #endregion
    }
}
