using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public static partial class FactoryFasceOrarie
    {
        private class FasciaOraria : IFasciaOraria
        {
            private TimeSpan _estremoInferiore;
            private TimeSpan _estremoSuperiore;

            public TimeSpan EstremoInferiore { get { return _estremoInferiore; } }
            public TimeSpan EstremoSuperiore { get { return _estremoSuperiore; } }

            /// <summary>
            /// ctor
            /// usato normalmente con ore, semplificato verso l'esterno
            /// </summary>
            /// <param name="oraInizio"></param>
            /// <param name="oraFine"></param>
            public FasciaOraria(uint estremoInferiore, uint estremoSuperiore)
            {
                if (estremoSuperiore <= estremoInferiore)
                    throw new ArgumentException("estremoInferiore < estremoSuperiore");
                _estremoInferiore = TimeSpan.FromHours(estremoInferiore);
                _estremoSuperiore = TimeSpan.FromHours(estremoSuperiore);
            }

            #region InterfaceMembers
            /// <summary>
            /// usato normalmente con due date del noleggio - d2.Subtract(d1)
            /// </summary>
            /// <param name="durata"></param>
            /// <returns></returns>
            public bool Include(TimeSpan durata)
            {
                return EstremoInferiore <= durata && durata < EstremoSuperiore;
            }

            #region IEquatable<IFasciaOraria>Members
            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is IFasciaOraria))
                    return false;
                return EstremoInferiore == (obj as IFasciaOraria).EstremoInferiore && EstremoSuperiore == (obj as IFasciaOraria).EstremoSuperiore;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public bool Equals(IFasciaOraria other)
            {
                return Equals((object)other);
            }
            public static bool operator ==(FasciaOraria f1, IFasciaOraria f2)
            {
                return f1.Equals(f2);
            }
            public static bool operator !=(FasciaOraria f1, IFasciaOraria f2)
            {
                return !f1.Equals(f2);
            }
            #endregion
            #endregion
        }
    }
}
