using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ElementoNoleggioUpperPanel : UpperPanel
    {
        public event EventHandler UpperPanelChange;

        public ElementoNoleggioUpperPanel()
        {
            InitializeComponent();
        }

        public ComboBox TipoElemento { get { return _elementoUpperPanel.ComboTipoElemento; } }
        public ComboBox StatoElemento { get { return _elementoUpperPanel.ComboStatoElemento; } }
        public ComboBox CategoriaElemento { get { return _elementoUpperPanel.ComboCategoriaElemento; } }

        public ComboBox AgevolazioneBox { get { return _agevolazioniNormaliComboBox; } }

        public object AgevolazioneNormale {  get { return _agevolazioniNormaliComboBox.SelectedItem; } }

        public void AddAgevolazioneNormale(object agevolazioneNormale)
        {
            if (agevolazioneNormale == null)
                throw new ArgumentNullException();
            _agevolazioniNormaliComboBox.Items.Add(agevolazioneNormale);
        }

        public void SetAgevolazioniNormali(IEnumerable<object> agevolazioniNormali)
        {
            if (agevolazioniNormali == null)
                throw new ArgumentNullException();
            foreach (object agevoalzioneNormale in agevolazioniNormali)
                AddAgevolazioneNormale(agevoalzioneNormale);
            _agevolazioniNormaliComboBox.SelectedIndex = 0;
        }

    

        public void OnControlChange(object source, EventArgs e)
        {
            if(UpperPanelChange !=null)
                UpperPanelChange(this, e);
        }

    }
}
