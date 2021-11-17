using System;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    public class AgevolazioneScontataNormale : AgevolazioneScontata, IAgevolazioneNormale
    {
        private IValiditaAgevolazioneNormale _validita;
        private Dictionary<IFasciaOraria, Percentuale> _tariffario;

        public Dictionary<IFasciaOraria, Percentuale> Tariffario { get { return _tariffario; } }

        private AgevolazioneScontataNormale(string nome, string descrizione, Percentuale scontoPercentuale,
            IValiditaAgevolazioneNormale validita, Dictionary<IFasciaOraria, Percentuale> tariffario)
            : base(nome, descrizione, scontoPercentuale)
        {
            if (validita == null)
                throw new ArgumentNullException("validita non può essere nullo");
            if (tariffario == null)
                throw new ArgumentNullException("tariffario non può essere nullo");
            _validita = validita;
            _tariffario = tariffario;
        }
        public AgevolazioneScontataNormale(string nome, string descrizione, Percentuale scontoPercentuale,
            DateTime dataInizio, DateTime dataFine, GiorniValidita giorniValidita,
            Dictionary<IFasciaOraria, Percentuale> tariffario)
            : this(nome, descrizione, scontoPercentuale,
            new ValiditaAgevolazioneNormale(dataInizio, dataFine, giorniValidita),
            tariffario) { }

        public float CalcolaPrezzo(float prezzoBase, IFasciaOraria fascia)
        {
            prezzoBase *= (1 - ScontoPercentuale);
            return prezzoBase * (1 - Tariffario[fascia].Valore);
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
