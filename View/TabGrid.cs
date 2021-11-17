using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TabGrid : TabPage
    {
        public TabGrid(string name)
        {
            InitializeComponent();
            Text = name;
        }

        public TabGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public AutoDataGridView DataGridView { get { return _dataGridView; } }
    }
}
