using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public class AgevolazioneFissaEccezionale : AgevolazioneFissa, IAgevolazioneEccezionale
    {
        public AgevolazioneFissaEccezionale(string nome, string descrizione, float prezzoFisso)
            : base(nome, descrizione, prezzoFisso) { }

        public float CalcolaPrezzo(float prezzoBase)
        {
            return PrezzoFisso;
        }
    }
}
