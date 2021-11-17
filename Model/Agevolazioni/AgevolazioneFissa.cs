using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public abstract class AgevolazioneFissa : Agevolazione
    {
        private float _prezzoFisso;

        public float PrezzoFisso { get { return _prezzoFisso; } }

        protected AgevolazioneFissa(string nome, string descrizione,
            float prezzoFisso)
            : base(nome, descrizione)
        {
            if (prezzoFisso < 0)
                throw new ArgumentException("prezzoFisso > 0");
            _prezzoFisso = prezzoFisso;
        }
    }
}
