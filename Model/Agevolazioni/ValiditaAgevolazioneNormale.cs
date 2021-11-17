using System;
using System2;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Agevolazioni
{
    //Osservazione importante
    //In realtà si dovrebbe nascondere - vedi costruttore Agevolazion{Fissa||Scontata}Normale
    //Ma Negozio dovrebbe risiedere in un meta-livello Modello-Presentazione
    internal struct ValiditaAgevolazioneNormale : IValiditaAgevolazioneNormale
    {
        private DateTime _dataInizio;
        private DateTime _dataFine;
        private GiorniValidita _giorniValidita;

        #region InterfaceMembers
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }
        public DateTime DataFine
        {
            get { return _dataFine; }
            set
            {
                if (value <= DataInizio)
                    throw new ArgumentException("DataFine non può antecedere DataInizio");
                _dataFine = value;
            }
        }
        public GiorniValidita GiorniValidita
        {
            get { return _giorniValidita; }
            set { _giorniValidita = value; }
        }

        public bool IsValidaOggi
        {
            get
            {
                return DateTime.Now.Between(DataInizio, DataFine) &&
                    ValidaNeiGiorni((GiorniValidita)Math.Pow(2, (int)DateTime.Now.DayOfWeek));
            }
        }
        #endregion

        internal ValiditaAgevolazioneNormale(DateTime dataInizio, DateTime dataFine, GiorniValidita giorniValidita)
        {
            _dataInizio = default(DateTime);
            _dataFine = default(DateTime);
            _giorniValidita = GiorniValidita.Monday;
            DataInizio = dataInizio;
            DataFine = dataFine;
            GiorniValidita = giorniValidita;
        }

        #region InterfaceMembers
        public bool ValidaNeiGiorni(GiorniValidita giorniValidita)
        {
            return (GiorniValidita & giorniValidita) == giorniValidita;
        }

        public void AggiungiGiorniValidita(GiorniValidita giorniValidita)
        {
            GiorniValidita |= giorniValidita;
        }

        public void RimuoviGiorniValidita(GiorniValidita giorniValidita)
        {
            GiorniValidita ^= (GiorniValidita & giorniValidita);
        }
        #endregion
    }
}
