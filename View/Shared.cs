using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class SharedButton : Button, IShared
    {
        public SharedButton() : base() { }
    }
    public class SharedToolStripItem : ToolStripItem, IShared
    {
        public SharedToolStripItem() : base() { }
    }
    public class SharedToolStripDropDownItem : ToolStripDropDownItem { }
    public class SharedToolStripMenuItem : ToolStripMenuItem { }
}
