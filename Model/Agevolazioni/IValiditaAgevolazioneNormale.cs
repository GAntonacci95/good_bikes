using System;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public interface IValiditaAgevolazioneNormale
    {
        DateTime DataInizio { get; set; }
        DateTime DataFine { get; set; }
        GiorniValidita GiorniValidita { get; set; }

        bool ValidaNeiGiorni(GiorniValidita giorniValidita);
        void AggiungiGiorniValidita(GiorniValidita giorniValidita);
        void RimuoviGiorniValidita(GiorniValidita giorniValidita);

        bool IsValidaOggi { get; }
    }
}
