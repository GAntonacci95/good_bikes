using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    [Flags]
    public enum GiorniValidita
    {
        Sunday = 0x0001,
        Monday = Sunday << 1,
        Tuesday = Monday << 1,
        Wednesday = Tuesday << 1,
        Thursday = Wednesday << 1,
        Friday = Thursday << 1,
        Saturday = Friday << 1
    }
}
