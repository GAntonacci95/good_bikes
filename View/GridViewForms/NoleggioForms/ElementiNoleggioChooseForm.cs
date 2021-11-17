using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class ElementiNoleggioChooseForm : ChooseForm
    {
        private ElementoNoleggioUpperPanel _upperPanel;

        public ElementiNoleggioChooseForm() : base() { }

        public ElementiNoleggioChooseForm(ElementoNoleggioUpperPanel panel)
        {
            _upperPanel = panel;
            SetFilter(_upperPanel);
        }

        public ElementoNoleggioUpperPanel UpperPanel { get { return _upperPanel; } set { _upperPanel = value; SetFilter(_upperPanel); } }
    }
}
