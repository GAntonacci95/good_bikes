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
    public partial class ElementoUpperPanel : UpperPanel
    {
        public event EventHandler FilterChange;
        public event EventHandler CategoriaChange;
      
        public ComboBox ComboStatoElemento { get { return _statoComboBox; } }
        public ComboBox ComboCategoriaElemento { get { return _categoriaComboBox; } }
        public ComboBox ComboTipoElemento{ get { return _tipoComboBox; } }


        #region ADD METHODS

        public void AddTipo (object tipo)
        {
            if (tipo == null)
                throw new ArgumentNullException();
            _categoriaComboBox.Items.Add(tipo);
        }

        public void AddStato(object stato)
        {
            if (stato== null)
                throw new ArgumentNullException();
            _tipoComboBox.Items.Add(stato);
        }

        public void AddCategoria(object categoria)
        {
            if (categoria == null)
                throw new ArgumentNullException();
            _categoriaComboBox.Items.Add(categoria);
        }

        #endregion

        #region SET METHODS

        public void SetTipi(IEnumerable<object> tipi)
        {
            if (tipi == null)
                throw new ArgumentNullException();
            //_categoriaComboBox.Items.Clear();
            _tipoComboBox.Items.Clear();
            foreach (object tipo in tipi)
                AddTipo(tipo);
        }

        public void SetStati(IEnumerable<object> stati)
        {
            if (stati == null)
                throw new ArgumentNullException();
            //_categoriaComboBox.Items.Clear();
            _statoComboBox.Items.Clear();
            foreach (object stato in stati)
                AddStato(stato);
        }

        public void SetCategorie(IEnumerable<object> categorie)
        {
            if (categorie == null)
                throw new ArgumentNullException();
            _categoriaComboBox.Items.Clear();
            foreach (object categoria in categorie)
                AddStato(categoria);
        }

        #endregion

        public ElementoUpperPanel()
        {
            InitializeComponent();

            _categoriaComboBox.SelectionChangeCommitted += CategoriaChange;

            _categoriaComboBox.SelectionChangeCommitted += FilterChange;
            _tipoComboBox.SelectionChangeCommitted += FilterChange;
            _statoComboBox.SelectionChangeCommitted += FilterChange;
            //_idTextBox.TextChanged += FilterChange;
        }
    }
}
