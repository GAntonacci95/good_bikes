using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System2;

namespace Model.Agevolazioni
{
    public abstract class AgevolazioneScontata : Agevolazione
    {
        private Percentuale _scontoPercentuale;

        public float ScontoPercentuale { get { return _scontoPercentuale.Valore; } }

        protected AgevolazioneScontata(string nome, string descrizione,
            Percentuale scontoPercentuale)
            : base(nome, descrizione)
        {
            if (scontoPercentuale == null)
                throw new ArgumentNullException("scontoPercentuale non può essere nullo");
            _scontoPercentuale = scontoPercentuale;
        }
    }
}
