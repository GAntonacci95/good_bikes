using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Persone;

namespace Model.Noleggi
{
    public abstract class Noleggio : IEquatable<Noleggio>
    {
        private DateTime _dataOraInizio;
        private DateTime _dataOraFineStimata;
        private DateTime _dataOraFine;
        private float _prezzoPagato;
        private Cliente _cliente;
        private IDipendente _dipendenteInizio;
        private IDipendente _dipendenteFine;
        private IList<ElementoNoleggio> _elementiNoleggio;

        #region Proprietà
        public DateTime DataOraInizio
        {
            get { return _dataOraInizio; }
            set { _dataOraInizio = value; }
        }

        public DateTime DataOraFineStimata
        {
            get { return _dataOraFineStimata; }
            set
            {
                if (value <= DataOraInizio)
                    throw new ArgumentException("DataOraFineStimata non può antecedere DataOraInizio");
                _dataOraFineStimata = value;
            }
        }

        public DateTime DataOraFine
        {
            get { return _dataOraFine; }
            set
            {
                if (value <= DataOraInizio)
                    throw new ArgumentException("DataOraFine non può antecedere DataOraInizio");
                _dataOraFine = value;
            }
        }

        public float PrezzoPagato { get { return _prezzoPagato; } }
        public Cliente Cliente
        {
            get { return _cliente; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Cliente non può essere nullo");
                _cliente = value;
            }
        }
        public IDipendente DipendenteInizio
        {
            get { return _dipendenteInizio; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("DipendenteInizio non può essere nullo");
                _dipendenteInizio = value;
            }
        }
        public IDipendente DipendenteFine
        {
            get { return _dipendenteFine; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("DipendenteFine non può essere nullo");
                _dipendenteFine = value;
            }
        }
        public IList<ElementoNoleggio> ElementiNoleggio
        {
            get { return _elementiNoleggio; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("ElementiNoleggio non può essere nullo");
                _elementiNoleggio = value;
            }
        }
        public TimeSpan Durata { get { return DataOraFine - DataOraInizio; } }
        public bool IsChiuso { get { return DataOraFine != default(DateTime); } }
        #endregion

        // Necessario per permettere l'azione congiunta di NoleggioServices e CommandManager
        protected Noleggio()
        {
            _elementiNoleggio = new List<ElementoNoleggio>();
            _prezzoPagato = -1;
            _dataOraInizio = default(DateTime);
            _dataOraFine = default(DateTime);
            _dataOraFineStimata = default(DateTime);
            _dipendenteFine = null;
        }

        protected Noleggio(DateTime dataOraInizio, DateTime dataOraFineStimata,
            Cliente cliente, IDipendente dipendenteInizio,
            IList<ElementoNoleggio> elementiNoleggio) : this()
        {
            DataOraInizio = dataOraInizio;
            DataOraFineStimata = dataOraFineStimata;
            Cliente = cliente;
            DipendenteInizio = dipendenteInizio;
            _elementiNoleggio = elementiNoleggio;
        }

        public virtual float CalcolaPrezzo(TimeSpan durata, byte minutiTolleranza)
        {
            float ret = 0;
            foreach (ElementoNoleggio elemento in ElementiNoleggio)
                ret += elemento.CalcolaPrezzo(durata, minutiTolleranza);
            return ret;
        }
        protected virtual float CalcolaPrezzo(byte minutiTolleranza)
        {
            //le biciclette rientrano tutte insieme
            TimeSpan durata = DataOraFine != default(DateTime) ? DataOraFine - DataOraInizio : DataOraFineStimata - DataOraInizio;
            return CalcolaPrezzo(durata, minutiTolleranza);
        }
        protected virtual void EffettuaPagamento(DateTime dataOraFine, IDipendente dipendenteFine, byte minutiTolleranza)
        {
            DataOraFine = dataOraFine;
            DipendenteFine = dipendenteFine;
            _prezzoPagato = CalcolaPrezzo(minutiTolleranza);
        }
        public virtual void EffettuaPagamento(IDipendente dipendenteFine, byte minutiTolleranza)
        {
            EffettuaPagamento(DateTime.Now, dipendenteFine, minutiTolleranza);
        }
        
        #region IEquatable<Noleggio>Members
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Noleggio))
                return false;
            return DataOraInizio == (obj as Noleggio).DataOraInizio && Cliente == (obj as Noleggio).Cliente;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Noleggio other)
        {
            return Equals((object)other);
        }
        public static bool operator ==(Noleggio f1, Noleggio f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Noleggio f1, Noleggio f2)
        {
            return !f1.Equals(f2);
        }
        #endregion
    }
}
