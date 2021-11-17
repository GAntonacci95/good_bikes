using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class UpperPanel : UserControl
    {
        private object _dataSource;
        public object DataSource { get { return _dataSource; } set { _dataSource = value; } }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Name = "UpperPanel";
            this.Size = new System.Drawing.Size(940, 594);
            this.ResumeLayout(false);

        }

        

    }
}
