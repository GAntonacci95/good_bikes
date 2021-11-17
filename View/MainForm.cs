using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        private ListForm _listForm = new ListForm();

        private void Method(object source, EventArgs e)
        {
            Console.WriteLine("Add Clicked!!");            
        }

        public MainForm()
        {
            InitializeComponent();

            ElementoUpperPanel panel = new ElementoUpperPanel();
            _listForm.SetFilter(panel);
            
            
        }
      
        #region PROPRIETA'
        public TabControl ElenchiTab { get { return _elenchiTabControl; } }
        public TabControl ElenchiTabControl { get { return _elenchiTabControl; } }
        public Button RestituisciElementiButton { get { return _restituisciElementiButton; } }
        public Button SostituisciElementiButton { get { return _sostituisciElementiButton; } }
        public Button CreaNoleggioButton { get { return _nuovoNoleggioButton; } }
        public MenuStrip MenuStrip { get { return _menuStrip; } }
        #endregion

        private void _vediTariffarioButton_Click(object sender, EventArgs e)
        {

        }
    }
}
