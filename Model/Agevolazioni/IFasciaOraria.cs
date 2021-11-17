using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public interface IFasciaOraria : IEquatable<IFasciaOraria>
    {
        TimeSpan EstremoInferiore { get; }
        TimeSpan EstremoSuperiore { get; }
        bool Include(TimeSpan durata);
    }
}
