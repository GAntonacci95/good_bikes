using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public static partial class FactoryStatiElemento
    {
        private class InRiparazione : StatoElemento
        {
            public InRiparazione() : base() { }

            public sealed override bool IsLibero(Elemento e)
            {
                return false;
            }
            //public override string Nome { get { return this.GetType().Name; } }
            public override string Descrizione { get { return "Elemento non correntemente disponibile causa riparazione"; } }
        }
    }
}
