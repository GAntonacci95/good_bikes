using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace View

{
    public partial class EditingControl : UserControl
    {
        public EditingControl()
        {
            InitializeComponent();
        }
    
        public TableLayoutPanel TableLayoutPanel 
        {
            get { return _tableLayoutPanel; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
        }
    
    }
}
