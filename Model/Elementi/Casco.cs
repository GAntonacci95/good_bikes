using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public class Casco : Elemento
    {
        public Casco() : base() { }

        public Casco(string id, string descrizione, StatoElemento stato, TipoElemento tipo)
            : base(id, descrizione, stato, tipo) { }

        [Editable("TipoCasco", "Combo", NotEditableAfterFirstTime = true)]
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
                if (!value.GetType().Equals(typeof(TipoCasco)))
                    throw new ArgumentNullException("il tipo di un casco deve essere un tipo di casco");
                _tipo = value;
            }
        }
    }
}
