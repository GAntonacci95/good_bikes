using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Persone;
using Model.Elementi;

namespace Model.Noleggi
{
    public class SostituzioneConcreta : Sostituzione
    {
        public SostituzioneConcreta(DateTime dataOra, IDipendente dipendente, Elemento elementoSostituente)
            : base(dataOra, dipendente, elementoSostituente) { }
    }
}
