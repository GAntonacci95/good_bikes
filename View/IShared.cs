using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View
{
    public interface IShared
    {
        object Tag { get; set; }
        bool Enabled { get; set; }
        event EventHandler Click;
    }
}
