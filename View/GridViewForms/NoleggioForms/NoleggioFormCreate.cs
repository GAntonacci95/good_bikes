using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;


namespace View
{
    public partial class NoleggioFormCreate : Form
    {
        private ElementiNoleggioChooseForm _chooseForm = new ElementiNoleggioChooseForm();

        public ElementiNoleggioChooseForm ChooseForm { get { return _chooseForm; } set { _chooseForm = value; } }
        public DataGridView ElementiNoleggioDataGridView { get { return _elementiNoleggioDataGridView; } }
        public EditingControl EditingControl { get { return _editingControl; } }
        public ComboBox ComboTipologieCliente { get { return _tipiClientiComboBox; } }
        public Button CercaClienteButton { get { return _buttonScegliCliente; } }
        public Button AggiungiElementoAlNoleggioButton { get { return _aggiungiElementoAlNoleggioButton; } }
        public Button AvviaNoleggioButton { get { return _avviaNoleggioButton; } }
        public Button ResetClienteButton { get { return _resetClienteButton; } }
        public DateTimePicker DatePicker { get { return _datePicker; } }
        public DateTimePicker TimePicker { get { return _timePicker; } }
        public TextBox PrezzoTotaleElementoTextBox { get { return _prezzoTotaleTextBox; } }
        public Label PrezzoSingoloElementoStatus { get { return _statusLabel; } }

        public Button RimuoviElementoDalNoleggioButton { get { return _removeButton; } }

        public NoleggioFormCreate()
        {
            InitializeComponent();
            ElementiNoleggioDataGridView.DataSource = typeof(BindingList<>);
        }
    }
}
