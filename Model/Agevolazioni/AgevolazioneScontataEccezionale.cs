using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public class AgevolazioneScontataEccezionale : AgevolazioneScontata, IAgevolazioneEccezionale
    {
        public AgevolazioneScontataEccezionale(string nome, string descrizione, Percentuale scontoPercentuale)
            : base(nome, descrizione, scontoPercentuale) { }

        public float CalcolaPrezzo(float prezzoBase)
        {
            return prezzoBase * (1 - ScontoPercentuale);
        }
    }
}
