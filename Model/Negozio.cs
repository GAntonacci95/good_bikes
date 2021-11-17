using Model.Agevolazioni;
using Model.Elementi;
using Model.Noleggi;
using Model.Persone;
using System;
using System.Collections.Generic;
using System2.Collections.Generic;
using System.Linq;
using System2.Reflection;

namespace Model
{
    public partial class Negozio
    {
        private static Random _rnd;
        private static Negozio _instance;

        //IUniqueList<T> where T : class, IEquatable<T>
        //Liste a chiave UNIQUE
        //Tutte le liste direttamente correlate al modello devono essere dichiarate IEventedList<T>
        //dove T è il tipo base implementante IEquatable<T>

        //Eventuali distinzioni d'interesse che debbano essere esposte dal Negozio sono
        //accessi di proprietà get ai campi privati con l'uso di eventuali filtri Linq tipo .OfType<T>
        //ne sono esempio AgevolazioniNormali ed AgevolazioniEccezionali su _agevolazioni
        private readonly IUniqueList<IFasciaOraria> _fasce;
        private readonly IUniqueList<IDipendente> _dipendenti;
        private readonly IUniqueList<Cliente> _clienti;
        private readonly IUniqueList<Agevolazione> _agevolazioni;
        private readonly IUniqueList<Elemento> _elementi;
        private readonly IUniqueList<Noleggio> _noleggi;

        private readonly IList<Type> _tipiCliente;
        private readonly Dictionary<Type, IUniqueList<TipoElemento>> _tipiElementoPerCategoria;
        private readonly IEnumerable<StatoElemento> _statiElementi;
        private readonly IList<CategorieAdapter> _categorie;

        public event EventHandler<ChangedEventArgs> Changed;

        //Informazione di default, dovrebbe essere resa configurabile, ma ce ne disinteressiamo
        public static readonly byte MINUTI_TOLLERANZA = 0;

        private Negozio()
        {
            _tipiCliente = new List<Type>();
            foreach (Type t in typeof(Cliente).GetSubtypes())
                _tipiCliente.Add(t);
            _statiElementi = FactoryStatiElemento.StatiElemento;

            _categorie = new List<CategorieAdapter>();
            _tipiElementoPerCategoria = new Dictionary<Type, IUniqueList<TipoElemento>>();
            foreach (Type t in typeof(Elemento).GetSubtypes())
            {
                _categorie.Add(new CategorieAdapter(t));
                _tipiElementoPerCategoria.Add(t, new UniqueList<TipoElemento>());
            }

            _fasce = new UniqueList<IFasciaOraria>();
            _fasce.AddRange(StatoInizialeNegozio.FasceOrarie.Tabella);

            _dipendenti = new UniqueList<IDipendente>();
            _dipendenti.AddRange(StatoInizialeNegozio.Amministratori.Tabella);
            _dipendenti.AddRange(StatoInizialeNegozio.Dipendenti.Tabella);

            _clienti = new UniqueList<Cliente>();
            _clienti.AddRange(StatoInizialeNegozio.ClientiPersone.Tabella);

            _agevolazioni = new UniqueList<Agevolazione>();
            _agevolazioni.AddRange(StatoInizialeNegozio.AgevolazioniFisseNormali.Tabella);
            _agevolazioni.AddRange(StatoInizialeNegozio.AgevolazioniScontateNormali.Tabella);
            _agevolazioni.AddRange(StatoInizialeNegozio.AgevolazioniFisseEccezionali.Tabella);
            _agevolazioni.AddRange(StatoInizialeNegozio.AgevolazioniScontateEccezionali.Tabella);

            foreach (Type t in _tipiElementoPerCategoria.Keys)
            {
                if (t == typeof(Bicicletta))
                    _tipiElementoPerCategoria[t].AddRange(StatoInizialeNegozio.TipiElementiBiciclette.Tabella);
                else if (t == typeof(Casco))
                    _tipiElementoPerCategoria[t].AddRange(StatoInizialeNegozio.TipiElementiCaschi.Tabella);
            }

            _elementi = new UniqueList<Elemento>();
            _elementi.AddRange(StatoInizialeNegozio.ElementiBiciclette.Tabella);
            _elementi.AddRange(StatoInizialeNegozio.ElementiCaschi.Tabella);

            _noleggi = new UniqueList<Noleggio>();
            _noleggi.AddRange(StatoInizialeNegozio.NoleggiConcreti.Tabella);
        }

        public static Negozio GetInstance()
        {
            if (_rnd == null && _instance == null)
            {
                //non invertire ordine, il random serve per l'inizializzazione del negozio
                _rnd = new Random();
                _instance = new Negozio();
            }

            return _instance;
        }

        private void OnChanged(ChangedEventArgs args)
        {
            if (Changed != null)
                Changed(this, args);
        }


        #region Proprietà
        public IEnumerable<IDipendente> Dipendenti { get { return _dipendenti; } }
        public IEnumerable<Cliente> Clienti { get { return _clienti; } }
        public IEnumerable<IFasciaOraria> FasceOrarie { get { return _fasce; } }
        public IEnumerable<IAgevolazioneNormale> AgevolazioniNormali { get { return _agevolazioni.OfType<IAgevolazioneNormale>(); } }
        public IEnumerable<IAgevolazioneEccezionale> AgevolazioniEccezionali { get { return _agevolazioni.OfType<IAgevolazioneEccezionale>(); } }
        public IEnumerable<Elemento> Elementi { get { return _elementi; } }
        public IEnumerable<Noleggio> Noleggi { get { return _noleggi; } }
        public IEnumerable<StatoElemento> StatiElemento { get { return _statiElementi; } }
        public IEnumerable<CategorieAdapter> Categorie { get { return _categorie; } }
        public IEnumerable<Type> TipiCliente { get { return _tipiCliente; } }
        #endregion

        #region Servizi del negozio
        #region Gestione Noleggio
        /* Gestione del noleggio
         * 
         * Creazione nuovo noleggio, 
         * inserimento e conclusione di un noleggio.
         */
        public Noleggio NuovoNoleggio()
        {
            return new NoleggioConcreto();
        }

        public void InserisciNuovoNoleggio(Noleggio noleggio)
        {
            // Solo qui istanzio il noleggio concreto. Restituisco un Noleggio (astratto): DIP!
            _instance._noleggi.Add(noleggio);
            OnChanged(ChangedEventArgs.InserimentoNuovoNoleggio(noleggio));
        }

        public void ConcludiNoleggio(Noleggio noleggio, IDipendente dipendente_corrente)
        {
            noleggio.EffettuaPagamento(dipendente_corrente, 5);
            OnChanged(ChangedEventArgs.ConclusioneNoleggio(noleggio));

        }
        #endregion
        #region Gestione Elemento
        /* Gestione Elemento
         * 
         * Creazione nuovo elemento, 
         * inserimento, modifica, eliminazione/disattivazione
         * di un elemento.
         */
        public Elemento NuovoElemento(string nome)
        {
            foreach (Type t in typeof(Elemento).GetSubtypes())
                if (t.Name.ToUpper() == nome.ToUpper())
                    return (Elemento)Activator.CreateInstance(t);
            return null;
        }

        public void InserisciNuovoElemento(Elemento elemento)
        {
            if (elemento != null)
                _elementi.Add(elemento);
            OnChanged(ChangedEventArgs.InserimentoNuovoElemento(elemento));
        }

        public void ModificaElemento(Elemento daModificare)
        {
            OnChanged(ChangedEventArgs.ModificaElemento(daModificare));
        }

        public void RimuoviElemento(Elemento daRimuovere)
        {
            if (daRimuovere != null && _elementi.Any(e => e == daRimuovere))
            {
                /*
                 * Se l'elemento è già stato utilizzato in un nolegio, deve rimanere
                 * come dato storico nel sistema. Altrimenti, può essere eliminato.
                 */
                if (daRimuovere.HasBeenUsed())
                    daRimuovere.Stato = FactoryStatiElemento.GetStato("Disattivato");
                else
                {
                    _elementi.Remove(daRimuovere);
                }
            }

            OnChanged(ChangedEventArgs.RimozioneElemento(daRimuovere));
        }

        #endregion
        #region Gestione TipoElemento
        /* Gestione Tipo Elemento
        * 
        * Creazione nuovo tipo elemento, 
        * inserimento, modifica, eliminazione/disattivazione
        * di un tipo di elemento.
        */
        public TipoElemento NuovoTipoElemento(Type categoria)
        {
            if (categoria == null)
                throw new ArgumentException("categoria must be not null");
            string nomeTipo = "Tipo" + categoria.Name;
            Type tipoCategoria = typeof(TipoElemento).GetSubtypes().Where(t => t.Name == nomeTipo).First();
            TipoElemento tipo = (TipoElemento)Activator.CreateInstance(tipoCategoria);
            return tipo;
        }

        public TipoElemento NuovoTipoElemento(string categoria)
        {
            if (categoria == null)
                throw new ArgumentException("categoria must be not null");
            string nomeTipo = "Tipo" + categoria;
            Type tipoCategoria = typeof(Elemento).GetSubtypes().Where(t => t.Name == categoria).First();
            return NuovoTipoElemento(tipoCategoria);
        }

        public IEnumerable<TipoElemento> GetTipiPerCategoria(Type categoria)
        {
            return _tipiElementoPerCategoria[categoria];
        }

        public IEnumerable<TipoElemento> GetTipiPerCategoria(string categoria)
        {
            if (ReflectionInformer.GetSubtypes(typeof(Elemento)).Any())
            {
                Type tipoCategoria = ReflectionInformer.GetSubtypes(typeof(Elemento)).Where(type => type.Name == categoria).First();
                return GetTipiPerCategoria(tipoCategoria);
            }
            else throw new ArgumentException("Categoria inesistente");
        }

        //protected TipoElemento InserisciNuovoTipoElemento(Type categoriaElemento, string nome, string descrizione, float tariffaBase, StatoTipoElemento statoTipo)
        //{
        //    TipoElemento tipo = NuovoTipoElemento(categoriaElemento);
        //    if (tipo == null)
        //        throw new ArgumentException("tipo must be not null");
        //    tipo.Nome = nome;
        //    tipo.Descrizione = descrizione;
        //    tipo.TariffaBase = tariffaBase;
        //    tipo.Stato = statoTipo;
        //    InserisciNuovoTipoElemento(tipo);
        //    return tipo;
        //}

        public void InserisciNuovoTipoElemento(TipoElemento daAggiungere)
        {
            if (daAggiungere == null)
                throw new ArgumentException("TipoElemento da aggiungere == null");
            Type categoria = GetCategoriaPerTipo(daAggiungere);
            if (_tipiElementoPerCategoria.ContainsKey(categoria))
                _tipiElementoPerCategoria[categoria].Add(daAggiungere);
            else
            {
                IUniqueList<TipoElemento> lista = new UniqueList<TipoElemento>();
                lista.Add(daAggiungere);
                _tipiElementoPerCategoria.Add(categoria, lista);
            }
            OnChanged(ChangedEventArgs.InserimentoNuovoTipoElemento(daAggiungere));
        }

        private Type GetCategoriaPerTipo(TipoElemento tipoElemento)
        {
            //Assumo i nomi dei tipi siano Tipo<NomeCategoria>
            return ReflectionInformer.GetSubtypes(typeof(Elemento)).Where(type => type.Name == tipoElemento.GetType().Name.Substring(4)).First();
        }

        public void ModificaTipoElemento(TipoElemento tipoElemento)
        {
            OnChanged(ChangedEventArgs.ModificaTipoElemento(tipoElemento));
        }

        public bool IsTipoInclusoInUnNoleggio(TipoElemento tipoEl)
        {
            foreach (Elemento e in Elementi.Where(el => el.Tipo == tipoEl))
                if (e.Stato == FactoryStatiElemento.GetStato("Noleggiabile") && !e.IsLibero)
                    return false;
            return true;

        }

        public void DisattivaTipoElemento(TipoElemento daDisattivare)
        {
            // cf. glossario: se un tipo è disattivato, lo sono anche tutti gli elementi di quel tipo
            if (daDisattivare != null && GetTipiPerCategoria(GetCategoriaPerTipo(daDisattivare)).Any())
            {
                foreach (Elemento e in _elementi)
                    if (e.Tipo == daDisattivare)
                        if (e.Stato == FactoryStatiElemento.GetStato("Noleggiabile") && !e.IsLibero)
                            throw new Exception("Impossibile disattivare questo tipo. Ci sono elementi di questo tipo con un noleggio in corso. Riprovare più tardi");
                        else
                            e.Stato = FactoryStatiElemento.GetStato("Disattivato");
                daDisattivare.Stato = StatoTipoElemento.Disattivo;
            }
            OnChanged(ChangedEventArgs.DisattivazioneTipoElemento(daDisattivare));
        }

        #endregion
        #region Gestione Dipendente
        /* Gestione Dipendente
         * 
         * Creazione nuovo dipendente, 
         * inserimento, modifica, eliminazione/disattivazione
         * di un dipendente.
         * Altre funzioni utili.
         */
        public IDipendente NuovoDipendente()
        {
            return new Dipendente();
        }

        public bool InserisciNuovoDipendente(IDipendente nuovo)
        {
            if (nuovo == null || String.IsNullOrEmpty(nuovo.NomeUtente) || String.IsNullOrEmpty(nuovo.Password))
                return false;
            if (_dipendenti.Any(dip => dip.NomeUtente == nuovo.NomeUtente))
                return false;
            _dipendenti.Add(nuovo);
            OnChanged(ChangedEventArgs.InserimentoNuovoDipendente(nuovo));
            return true;
        }

        public void ModificaDipendente(IDipendente daModificare)
        {
            OnChanged(ChangedEventArgs.ModificaDipendente(daModificare));
        }

        public void RimuoviDipendente(IDipendente daRimuovere)
        {
            if (daRimuovere != null && _dipendenti.Any(d => d == daRimuovere))
                daRimuovere.Attivo = false;
            OnChanged(ChangedEventArgs.RimozioneDipendente(daRimuovere));
        }

        public IDipendente DipendenteDaCredenziali(string uname, string pass)
        {
            foreach (IDipendente d in Dipendenti)
                if (d.NomeUtente == uname && d.Password == pass && d.Attivo)
                    return d;
            return null;
        }

        #endregion
        #region Gestione Cliente
        /* Gestione Cliente
         * Creazione di un nuovo cliente.
         * Inserimento di un cliente.
         * Funzioni di utilità.
         */
        public Cliente NuovoCliente(string tipo_cliente)
        {
            if (string.IsNullOrEmpty(tipo_cliente))
                throw new ArgumentNullException("nome tipo non valido");
            Type tipoCliente = GetTipoCliente(tipo_cliente);
            return (Cliente)Activator.CreateInstance(tipoCliente);
        }

        public void InserisciCliente(Cliente cliente)
        {
            if (!_clienti.Contains(cliente))
                _clienti.Add(cliente);
        }

        public IEnumerable<string> GetNomiTipiClienti()
        {
            IList<string> result = new List<string>();
            foreach (Type t in _tipiCliente)
                result.Add(t.Name);
            return result;
        }

        public Type GetTipoCliente(string nometipo)
        {
            if (string.IsNullOrEmpty(nometipo))
                throw new ArgumentNullException("nome tipo non valido");
            Type tipo = _tipiCliente.Where(t => t.Name == nometipo).ElementAt(0);
            if (tipo == null)
                throw new ArgumentException("tipo_cliente");
            else return tipo;
        }


        #endregion
        #region GestioneAgevolazioni
        /* TO DO  cf. GestioneAgevolazioniPresenter */
        #endregion
        #endregion
    }
}
