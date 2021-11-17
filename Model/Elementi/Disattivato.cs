using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    class Disattivato : StatoElemento
    {
        public Disattivato() : base() { }

        public sealed override bool IsLibero(Elemento e)
        {
            return false;
        }
        //public override string Nome { get { return "Disattivato"; } }
        public override string Descrizione { get { return "Elemento non piu' disponibile al noleggio"; } }

    }
}
