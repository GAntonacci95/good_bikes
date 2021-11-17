using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public abstract class Elemento : IEquatable<Elemento>
    {
        private string _id;
        private string _descrizione;
        private StatoElemento _stato;
        private bool _utilizzato;
        protected TipoElemento _tipo;

        #region Proprietà
        [Editable("Id", true) ]
        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Value can not be null or empty");
                _id = value;
            }
        }
        [Editable("Descrizione")]
        public string Descrizione
        {
            get { return _descrizione; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("value can not be null or empty");
                _descrizione = value;
            }
        }
        [Editable("Stato", "Combo")]
        public StatoElemento Stato
        {
            get { return _stato; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("stato non può essere nullo");
                _stato = value;
            }
        }
        
    
        public abstract TipoElemento Tipo { get; set; }
        
        
        public string Categoria { get { return GetType().Name; } }
        #endregion

        protected Elemento()
        {
            _utilizzato = false;
        }
        protected Elemento(string id, string descrizione, StatoElemento stato, TipoElemento tipo) 
            : base()
        {
            Id = id;
            Descrizione = descrizione;
            Stato = stato;
            Tipo = tipo;
        }

        #region IEquatable<Elemento>Members
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Elemento))
                return false;
            return Id == (obj as Elemento).Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Elemento other)
        {
            return Equals((object)other);
        }

        public static bool operator ==(Elemento e1, Elemento e2)
        {
            return e1.Equals(e2);
        }
        public static bool operator !=(Elemento e1, Elemento e2)
        {
            return !e1.Equals(e2);
        }
        #endregion

        public bool IsLibero
        {
            get
            {
                return Tipo.Stato == StatoTipoElemento.Attivo && Stato.IsLibero(this);
            }
        }

        public bool HasBeenUsed()
        {
            return _utilizzato;
        }
        public void setUsed(bool used)
        {
            if (!HasBeenUsed() && used)
                _utilizzato = used;
        }
    }
}
