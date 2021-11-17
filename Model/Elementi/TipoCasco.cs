using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Elementi
{
    public class TipoCasco : TipoElemento
    {
        public TipoCasco() : base() { }
        public TipoCasco(string nome, string descrizione, float tariffaBase, StatoTipoElemento statoTipo)
            : base(nome, descrizione, tariffaBase, statoTipo) { }
    }
}
