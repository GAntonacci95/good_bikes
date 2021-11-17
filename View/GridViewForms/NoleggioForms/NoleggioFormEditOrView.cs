using System;
using System.Windows.Forms;


namespace View
{
    public partial class NoleggioFormEditOrView : Form
    {

        public Button AggiungiAgevolazioneEccezionale { get { return _aggiungiAgevolazioneEccezionaleButton; } set { _aggiungiAgevolazioneEccezionaleButton = value; } }
        public DataGridView ElementiNoleggioDataGridView { get { return _elementiNoleggioDataGridView; } set { _elementiNoleggioDataGridView = value; } }
        public Label DurataLabel { get { return _durataLabel; } }
        public Label PrezzoTotaleLabel { get { return _prezzoTotaleLabel; } }
        public Label PrezzoSingoloElementoStatus { get { return _prezzoSingoloElementoStatus; } }
        public TableLayoutPanel DatiClientePanel { get { return _datiClienteLayoutPanel; } }
        public Button ConcludiButton { get { return _concludiNoleggioButton; } }


        public NoleggioFormEditOrView()
        {
            InitializeComponent();
        }
    }
}
