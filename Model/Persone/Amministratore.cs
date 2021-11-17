using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Persone
{
    public class Amministratore : Dipendente
    {
        public Amministratore(string nomeUtente, string password)
            : base(nomeUtente, password) { }
    }
}
