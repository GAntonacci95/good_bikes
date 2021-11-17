using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public sealed class Percentuale
    {
        public const byte MAX = 100;
        private byte _valore; //50
        public float Valore { get { return (float)_valore / MAX; } } //0.5

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="valore">valore in [0, 100]</param>
        public Percentuale(byte valore)
        {
            if (valore > MAX)
                throw new ArgumentException(string.Format("valore non può essere > {0}", MAX));
            _valore = valore;
        }

        public override string ToString()
        {
            return string.Format("{0}%", _valore); //50%
        }
    }
}
