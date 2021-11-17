using System;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public class AgevolazioneFissaNormale : AgevolazioneFissa, IAgevolazioneNormale
    {
        private IValiditaAgevolazioneNormale _validita;

        private AgevolazioneFissaNormale(string nome, string descrizione, float prezzoFisso,
            IValiditaAgevolazioneNormale validita)
            : base(nome, descrizione, prezzoFisso)
        {
            if (validita == null)
                throw new ArgumentNullException("validita non può essere nullo");
            _validita = validita;
        }
        public AgevolazioneFissaNormale(string nome, string descrizione, float prezzoFisso,
            DateTime dataInizio, DateTime dataFine, GiorniValidita giorniValidita)
            : this(nome, descrizione, prezzoFisso, new ValiditaAgevolazioneNormale(dataInizio, dataFine, giorniValidita)) { }

        public float CalcolaPrezzo(float prezzoBase, IFasciaOraria fascia)
        {
            return PrezzoFisso;
        }

        #region InterfaceMembers
        public DateTime DataInizio
        {
            get { return _validita.DataInizio; }
            set { _validita.DataInizio = value; }
        }

        public DateTime DataFine
        {
            get { return _validita.DataFine; }
            set { _validita.DataFine = value; }
        }

        public GiorniValidita GiorniValidita
        {
            get { return _validita.GiorniValidita; }
            set { _validita.GiorniValidita = value; }
        }

        public bool IsValidaOggi { get { return _validita.IsValidaOggi; } }

        public bool ValidaNeiGiorni(GiorniValidita giorniValidita)
        {
            return _validita.ValidaNeiGiorni(giorniValidita);
        }

        public void AggiungiGiorniValidita(GiorniValidita giorniValidita)
        {
            _validita.AggiungiGiorniValidita(giorniValidita);
        }

        public void RimuoviGiorniValidita(GiorniValidita giorniValidita)
        {
            _validita.RimuoviGiorniValidita(giorniValidita);
        }
        #endregion
    }
}
