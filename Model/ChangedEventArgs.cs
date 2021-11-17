using Model.Elementi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Noleggi;
using Model.Persone;

namespace Model
{
    public class ChangedEventArgs : EventArgs
    {
        private readonly TipoEvento _tipoEvento;
        private readonly Elemento _elemento;
        private readonly TipoElemento _tipoElemento;
        private readonly Noleggio _noleggio;
        private readonly IDipendente _dipendente;

        private ChangedEventArgs(TipoEvento tipoEvento, Elemento elemento, TipoElemento tipo, Noleggio noleggio, IDipendente dipendente)
        {
            _tipoEvento = tipoEvento;
            _elemento = elemento;
            _tipoElemento = tipo;
            _noleggio = noleggio;
            _dipendente = dipendente;
        }

        public static ChangedEventArgs InserimentoNuovoElemento(Elemento daInserire)
        {
            if (daInserire == null)
                throw new ArgumentNullException("elemento");
            return new ChangedEventArgs(TipoEvento.InserimentoNuovoElemento, daInserire, null, null, null);
        }

        public static ChangedEventArgs RimozioneElemento(Elemento daRimuovere)
        {
            if (daRimuovere == null)
                throw new ArgumentNullException("elemento");
            return new ChangedEventArgs(TipoEvento.RimozioneElemento, daRimuovere, null, null, null);
        }

        public static ChangedEventArgs ModificaElemento(Elemento elemento)
        {
            if (elemento == null)
                throw new ArgumentNullException("elemento");
            return new ChangedEventArgs(TipoEvento.ModificaElemento, elemento, null, null, null);
        }

        public TipoEvento TipoEvento
        {
            get { return _tipoEvento; }
        }

        public Elemento Elemento
        {
            get { return _elemento; }
        }

        public IDipendente Dipendente
        {
            get { return _dipendente; }
        }

        internal static ChangedEventArgs InserimentoNuovoTipoElemento(TipoElemento tipo)
        {
            if (tipo == null)
                throw new ArgumentNullException("tipo_elemento");
            return new ChangedEventArgs(TipoEvento.InserimentoNuovoTipoElemento, null, tipo, null, null);
        }

        internal static ChangedEventArgs ModificaTipoElemento(TipoElemento tipo)
        {
            if (tipo == null)
                throw new ArgumentNullException("tipo_elemento");
            return new ChangedEventArgs(TipoEvento.ModificaTipoElemento, null, tipo, null, null);
        }

        internal static ChangedEventArgs DisattivazioneTipoElemento(TipoElemento tipo)
        {
            if (tipo == null)
                throw new ArgumentNullException("tipo_elemento");
            return new ChangedEventArgs(TipoEvento.DisattivazioneTipoElemento, null, tipo, null, null);
        }

        internal static ChangedEventArgs InserimentoNuovoNoleggio(Noleggio noleggio)
        {
            if (noleggio == null)
                throw new ArgumentNullException("noleggio");
            return new ChangedEventArgs(TipoEvento.InserimentoNuovoNoleggio, null, null, noleggio, null);
        }

        internal static ChangedEventArgs ConclusioneNoleggio(Noleggio noleggio)
        {
            if (noleggio == null)
                throw new ArgumentNullException("noleggio");
            return new ChangedEventArgs(TipoEvento.ConclusioneNoleggio, null, null, noleggio, null);
        }

        internal static ChangedEventArgs InserimentoNuovoDipendente(IDipendente nuovo)
        {
            if (nuovo == null)
                throw new ArgumentNullException("noleggio");
            return new ChangedEventArgs(TipoEvento.InserimentoNuovoDipendente, null, null, null, nuovo);
        }

        internal static ChangedEventArgs RimozioneDipendente(IDipendente daRimuovere)
        {
            if (daRimuovere == null)
                throw new ArgumentNullException("dipendente");
            return new ChangedEventArgs(TipoEvento.RimozioneDipendente,  null, null, null, daRimuovere);
        }

        public static ChangedEventArgs ModificaDipendente(IDipendente daModificare)
        {
            if (daModificare == null)
                throw new ArgumentNullException("dipendente");
            return new ChangedEventArgs(TipoEvento.ModificaElemento, null, null, null, daModificare);
        }

        public static ChangedEventArgs AggiornaFiltro()
        {
            return new ChangedEventArgs(TipoEvento.CambiamentoFiltro, null, null, null, null);
        }
    }
}
