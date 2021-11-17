using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ChooseForm : GridViewForm
    {
        
        public virtual List<object> SelectedObjectsList
        {
            get
            {
                List<object> ret = new List<object>();
                foreach(DataGridViewRow row in _dataGridView.SelectedRows)
                {
                    ret.Add(row.DataBoundItem);
                }
                Console.WriteLine("Righe selezionate: " + _dataGridView.SelectedRows.Count);
                return ret;
            }
        }

        public ChooseForm()
        {
            InitializeComponent();
        }

        public Button OkButton { get { return _okButton; } }

    }
}
