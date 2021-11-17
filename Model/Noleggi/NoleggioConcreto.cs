using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Persone;

namespace Model.Noleggi
{
    public class NoleggioConcreto : Noleggio
    {
        public NoleggioConcreto() : base() { }

        public NoleggioConcreto(DateTime dataOraInizio, DateTime dataOraFineStimata,
            Cliente cliente, IDipendente dipendenteInizio,
            IList<ElementoNoleggio> elementiNoleggio)
            : base(dataOraInizio, dataOraFineStimata, cliente, dipendenteInizio, elementiNoleggio) { }
    }
}
