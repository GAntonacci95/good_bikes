using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Persone
{
    public class ClientePersona : Cliente
    {
        private string _cognome;
        private string _tipoDocumento;
        private string _numeroDocumento;

        [Editable("Cognome")]
        public string Cognome {
            get { return _cognome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il cognome non può essere nullo o vuoto");
                _cognome = value;
            }
        }
        [Editable("Tipo documento")]
        public string TipoDocumento {
            get { return _tipoDocumento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il tipo documento non può essere nullo o vuoto");
                _tipoDocumento = value;
            }
        }
        [Editable("Numero documento")]
        public string NumeroDocumento {
            get { return _numeroDocumento; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Il numero documento non può essere nullo o vuoto");
                _numeroDocumento = value;
            }
        }

        public ClientePersona() { }
        public ClientePersona(string nome, string cognome, string recapito, string tipoDocumento, string numeroDocumento)
            : base(nome, recapito)
        {
            if (string.IsNullOrEmpty(cognome))
                throw new ArgumentException("cognome non può essere nullo o vuoto");
            if (string.IsNullOrEmpty(tipoDocumento))
                throw new ArgumentException("tipoDocumento non può essere nullo o vuoto");
            if (string.IsNullOrEmpty(numeroDocumento))
                throw new ArgumentException("numeroDocumento non può essere nullo o vuoto");
            _cognome = cognome;
            _tipoDocumento = tipoDocumento;
            _numeroDocumento = numeroDocumento;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome;
        }
    }
}
