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
    public partial class ListForm : GridViewForm
    {


        public ListForm()
        {
            InitializeComponent();
        }

        public Button EditButton { get { return _editButton; } }
        public Button AddButton { get { return _addButton; } }
        public Button DeleteButton { get { return _deleteButton; } }
        public Button OkButton { get { return _OKbutton;  } }
   
    }
}
