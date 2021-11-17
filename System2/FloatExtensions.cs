using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace System2
{
    public static class FloatExtensions
    {
        public static string ToEuroString(this float val)
        {
            return string.Format("{0}{1}", val.ToString("0.00"), '€');
        }
    }
}
