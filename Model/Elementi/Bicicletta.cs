using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public class Bicicletta : Elemento
    {
        public Bicicletta() { }
        public Bicicletta(string id, string descrizione, StatoElemento stato, TipoElemento tipo)
            : base(id, descrizione, stato, tipo) { }


        [Editable("TipoBicicletta", "Combo", NotEditableAfterFirstTime = true)]
        public override TipoElemento Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
               if (value == null)
                    throw new ArgumentNullException("tipo non può essere nullo");
               if (!value.GetType().Equals(typeof(TipoBicicletta)))
                    throw new ArgumentNullException("il tipo di una bicicletta deve essere un tipo di bicicletta");
                _tipo = value;
             }
        }
    }
}
