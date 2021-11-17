using System;
using Model.Persone;
using Model.Elementi;

namespace Model.Noleggi
{
    public abstract class Sostituzione
    {
        private DateTime _dataOra;
        private IDipendente _dipendente;
        //private Elemento _elementoSostituito;
        private Elemento _elementoSostituente;

        public DateTime DataOra { get { return _dataOra; } }
        public IDipendente Dipendente { get { return _dipendente; } }
        //public Elemento ElementoSostituito { get { return _elementoSostituito; } }
        public Elemento ElementoSostituente { get { return _elementoSostituente; } }

        //In base al diagramma di progettazione
        protected Sostituzione(DateTime dataOra, IDipendente dipendente,  Elemento elementoSostituente)
        {
            if (dipendente == null)
                throw new ArgumentNullException("dipendente non può essere nullo");
            if (elementoSostituente == null)
                throw new ArgumentNullException("elementoSostituente non può essere nullo");
            _dataOra = dataOra;
            _dipendente = dipendente;
            _elementoSostituente = elementoSostituente;
        }
        //Si potrebbe aggiungere ridondanza con l'ElementoSostituito - sarebbe necessaria l'alterazione della cardinalità nel diagramma
    }
}
