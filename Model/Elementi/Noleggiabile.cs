using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public static partial class FactoryStatiElemento
    {
        private class Noleggiabile : StatoElemento
        {
            public Noleggiabile() : base() { }

            public override bool IsLibero(Elemento e)
            {
                //per ogni noleggio correntemente in corso
                foreach (Noleggi.Noleggio n in Negozio.GetInstance().Noleggi.Where(n => !n.IsChiuso))
                    //per ogni elemento noleggio
                    foreach (Noleggi.ElementoNoleggio el in n.ElementiNoleggio)
                        //se uno degli elementi correnti -quindi non sostituiti- è e
                        if (el.Corrente == e)
                            return false;//-->e non è libero.
                return true;
            }
            //public override string Nome { get { return "Noleggiabile"; } }
            public override string Descrizione { get { return "Elemento utilizzabile per il noleggio"; } }
        }
    }
}
