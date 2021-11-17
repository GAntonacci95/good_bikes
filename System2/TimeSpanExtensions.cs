using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System2
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan Approssima(this TimeSpan durata, byte minutiTolleranza)
        {
            if (minutiTolleranza > 59)
                throw new ArgumentException("minutiTolleranza < 60");

            bool rientraTolleranza = durata.Minutes < minutiTolleranza;
            TimeSpan durataArrotondata = durata - TimeSpan.FromMinutes(durata.Minutes);
            return rientraTolleranza ? durataArrotondata : durataArrotondata + TimeSpan.FromHours(1);
        }
    }
}
