using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Persone
{
    public class Dipendente : IDipendente
    {
        private string _nomeUtente;
        private string _password;
        private bool _attivo;

        [Editable("Nome utente", true)]
        public string NomeUtente {
            get { return _nomeUtente; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il nome utente non può essere vuoto");
                _nomeUtente = value;
            }
        }
        [Editable("Password")]
        public string Password {
            get { return _password; }
            set
            {
               if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il nome utente non può essere vuoto");
                _password = value;
            }
        }

        public bool Attivo
        {
            get
            {
                return _attivo;
            }

            set
            {
                _attivo = value;
            }
        }

        public Dipendente()
        {
            _attivo = true;
        }

        public Dipendente(string nomeUtente, string password) 
            : this()
        {
            if (string.IsNullOrEmpty(nomeUtente))
                throw new ArgumentException("nomeUtente non può essere nullo o vuoto");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("password non può essere nullo o vuoto");
            _nomeUtente = nomeUtente;
            _password = password;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is IDipendente))
                return false;
            return NomeUtente == (obj as IDipendente).NomeUtente;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(IDipendente other)
        {
            return Equals((object)other);
        }
        public static bool operator ==(Dipendente d1, IDipendente d2)
        {
            return d1.Equals(d2);
        }
        public static bool operator !=(Dipendente d1, IDipendente d2)
        {
            return !d1.Equals(d2);
        }
    }
}
