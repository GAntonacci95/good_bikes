using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System2;
using System2.Collections;

namespace Model.Agevolazioni
{
    public static partial class FactoryFasceOrarie
    {
        private static IList<IFasciaOraria> _fasceOrarie;

        public static IList<IFasciaOraria> FasceOrarie { get { return _fasceOrarie; } }

        static FactoryFasceOrarie()
        {
            _fasceOrarie = new List<IFasciaOraria>();
        }


        public static IFasciaOraria GetFasciaOraria(uint estremoInferiore, uint estremoSuperiore)
        {
            IFasciaOraria ret = new FasciaOraria(estremoInferiore, estremoSuperiore);

            if (FasceOrarie.Count == 0 || //se vuoto o
                FasceOrarie.Last().EstremoSuperiore.TotalHours == estremoInferiore) //se FasceOrarie.Last.EstremoSuperiore = estremoInferiore
                FasceOrarie.Add(ret);
            else if (FasceOrarie.Count != 0 && FasceOrarie.Contains(ret))
                return FasceOrarie.Where(fascia => fascia.Equals(ret)).ToArray()[0]; //Iface==Iface is ReferenceEquals
            else
                throw new InvalidOperationException("FasceOrarie.Last.EstremoSuperiore deve coincidere con estremoInferiore");
            return ret;
        }

        public static bool Rimuovi()
        {
            return FasceOrarie.Remove(FasceOrarie.Last());
        }

        //metodo di solo retrieve, l'istanza IFasciaOraria dev'essere già presente
        public static IFasciaOraria Ricava(TimeSpan durata, byte minutiTolleranza)
        {
            IFasciaOraria[] tmp = FasceOrarie.Where(fascia => fascia.Include(durata.Approssima(minutiTolleranza))).ToArray();
            if (tmp.Length == 1)
                return tmp[0];
            else
                throw new InvalidOperationException("Non esiste una fascia adeguata per questa durata");
        }
    }
}
