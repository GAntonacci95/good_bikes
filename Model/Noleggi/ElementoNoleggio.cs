using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System2;
using Model.Agevolazioni;
using Model.Persone;
using Model.Elementi;

namespace Model.Noleggi
{
    //questa classe potrebbe wrappare originario in delega
    public abstract class ElementoNoleggio
    {
        private Elemento _originario;
        private IList<Sostituzione> _sostituzioni;
        private readonly IAgevolazioneNormale _agevolazioneNormale;
        private IAgevolazioneEccezionale _agevolazioneEccezionale;

        #region InterfaceMembers
        public Elemento Corrente
        {
            get
            {
                return Sostituzioni.Count() != 0 ? Sostituzioni.Last().ElementoSostituente : Originario;
            }
        }
        public IEnumerable<Sostituzione> Sostituzioni { get { return _sostituzioni; } }
        public Elemento Originario { get { return _originario; } }
        public IAgevolazioneNormale AgevolazioneNormale { get { return _agevolazioneNormale; } }
        public IAgevolazioneEccezionale AgevolazioneEccezionale { get { return _agevolazioneEccezionale; } set { _agevolazioneEccezionale = value; } }
        #endregion

        protected ElementoNoleggio(Elemento elementoIniziale, IAgevolazioneNormale agevolazioneNormale, IAgevolazioneEccezionale agevolazioneEccezionale)
        {
            if (elementoIniziale == null)
                throw new ArgumentNullException("elementoIniziale non può essere nullo");
            if (agevolazioneNormale == null)
                throw new ArgumentNullException("agevolazioneNormale non può essere nullo");
            _originario = elementoIniziale;
            _sostituzioni = new List<Sostituzione>();
            _agevolazioneNormale = agevolazioneNormale;
            _agevolazioneEccezionale = agevolazioneEccezionale; //can be null
        }
        protected ElementoNoleggio(Elemento elementoIniziale, IAgevolazioneNormale agevolazioneNormale) : this(elementoIniziale, agevolazioneNormale, null) { }

        public virtual void SostituisciCon(Elemento altro, DateTime dataOra, IDipendente dipendente)
        {
            if (altro == null)
                throw new ArgumentNullException("altro non può essere nullo");
            if (dipendente == null)
                throw new ArgumentNullException("dipendente non può essere nullo");

            _sostituzioni.Add(new SostituzioneConcreta(dataOra, dipendente, altro));
        }

        
        public virtual float CalcolaPrezzo(TimeSpan durata, byte minutiTolleranza)
        {
            Agevolazioni.IFasciaOraria fascia = Agevolazioni.FactoryFasceOrarie.Ricava(durata, minutiTolleranza);
            return CalcolaPrezzo(fascia) * (int)durata.Approssima(minutiTolleranza).TotalHours;
        }
        protected virtual float CalcolaPrezzo(IFasciaOraria fascia)
        {
            //Prezzo orario in base al tipo
            float prezzoBase = Originario.Tipo.TariffaBase;
            if (Sostituzioni.Count() > 0)
            {
                float minSost = Sostituzioni.Select(s => s.ElementoSostituente.Tipo.TariffaBase).Min();
                if (minSost < prezzoBase)
                    prezzoBase = minSost;
            }
            //Rivalutazione del prezzo orario - AgevolazioneNormale:
            //      se AgevolazioneNormale è Fissa, prezzoBase è
            //          - sostituito con un prezzo fisso (NB, non sconto fisso)
            //      se altrimenti AgevolazioneNormale è Scontata, prezzoBase è ricalcolato con lo sconto
            //          - di base
            //          - del tariffario in funzione della fascia
            prezzoBase = AgevolazioneNormale.CalcolaPrezzo(prezzoBase, fascia);
            //Rivalutazione del prezzo orario - AgevolazioneEccezionale:
            //      se AgevolazioneEccezionale è Fissa, prezzoBase è
            //          - sostituito con un prezzo fisso (NB, non sconto fisso)
            //      se altrimenti AgevolazioneEccezionale è Scontata, prezzoBase è ricalcolato con lo sconto
            //          - di base
            if (AgevolazioneEccezionale != null)
                prezzoBase = AgevolazioneEccezionale.CalcolaPrezzo(prezzoBase);
            return prezzoBase;
        }
    }
}
