using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public interface IAgevolazioneNormale : IValiditaAgevolazioneNormale
    {
        float CalcolaPrezzo(float prezzoBase, IFasciaOraria fascia);
    }
}
