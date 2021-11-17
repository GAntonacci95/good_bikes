using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Agevolazioni;
using Model.Persone;
using Model.Elementi;

namespace Model.Noleggi
{
    public class ElementoNoleggioConcreto : ElementoNoleggio
    {
        public ElementoNoleggioConcreto(Elemento elementoIniziale, IAgevolazioneNormale agevolazioneNormale)
            : base(elementoIniziale, agevolazioneNormale) { }
    }
}
