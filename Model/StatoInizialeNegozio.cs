using Model.Agevolazioni;
using Model.Elementi;
using Model.Noleggi;
using Model.Persone;
using System;
using System.Collections.Generic;
using System2.Collections.Generic;

namespace Model
{
    public partial class Negozio
    {
        private static class StatoInizialeNegozio
        {
            #region Fasce Orarie
            public static class FasceOrarie
            {
                public static IUniqueList<IFasciaOraria> Tabella;

                static FasceOrarie()
                {
                    Tabella = new UniqueList<IFasciaOraria>();
                    for (uint i = 0; i < 24; i += 2)
                        Tabella.Add(FactoryFasceOrarie.GetFasciaOraria(i, i + 2));
                }
            }
            #endregion

            #region Dipendenti
            public static class Dipendenti
            {
                public static readonly IUniqueList<IDipendente> Tabella;

                private static readonly string[] _nomiUtenti = { "dipendente0", "dipendente1", "dipendente2", "dipendente3" };
                private static readonly string[] _passwords = { "password0", "password1", "password2", "password3" };

                static Dipendenti()
                {
                    Tabella = new UniqueList<IDipendente>();
                    for (int i = 0; i < _nomiUtenti.Length; i++)
                        Tabella.Add(new Dipendente(_nomiUtenti[i], _passwords[i]));
                }
            }
            public static class Amministratori
            {
                public static readonly IUniqueList<IDipendente> Tabella;

                private static readonly string[] _nomiUtenti = { "admin", "amministratore0", "amministratore1", "amministratore2", "amministratore3" };
                private static readonly string[] _passwords = { "admin", "password0", "password1", "password2", "password3" };

                static Amministratori()
                {
                    Tabella = new UniqueList<IDipendente>();
                    for (int i = 0; i < _nomiUtenti.Length; i++)
                        Tabella.Add(new Amministratore(_nomiUtenti[i], _passwords[i]));
                }
            }
            #endregion

            #region Clienti
            public static class ClientiPersone
            {
                public static readonly IUniqueList<Cliente> Tabella;

                private static readonly string[] _nomi = { "Mario", "Pietro", "Filippo", "Ugo" };
                private static readonly string[] _cognomi = { "Rossi", "Verdi", "Neri", "Fantozzi" };
                private static readonly string[] _recapiti = { "0123456789", "0123456788", "0123456787", "0123456786" };
                private static readonly string[] _tipiDocumenti = { "Carta d'Identità", "Patente", "Patente", "Passaporto" };
                private static readonly string[] _numeriDocumenti = { "AS1234567", "BO1234567L", "MI7654321K", "AA1234567" };

                static ClientiPersone()
                {
                    Tabella = new UniqueList<Cliente>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new ClientePersona(_nomi[i], _cognomi[i], _recapiti[i], _tipiDocumenti[i], _numeriDocumenti[i]));
                }
            }
            #endregion

            #region Agevolazioni
            public static class AgevolazioniFisseNormali
            {
                public static readonly IUniqueList<Agevolazione> Tabella;

                private static readonly string[] _nomi = { "Bike day (4€)", "Evento speciale (7€)" };
                private static readonly string[] _descrizioni = { "Prezzo fisso orario di 4€", "Prezzo fisso orario di 7€" };
                private static readonly float[] _prezzi = { 4, 7 };
                private static readonly DateTime[] _dateInizi = { DateTime.Now - TimeSpan.FromDays(365), DateTime.Now - TimeSpan.FromDays(365) };
                private static readonly DateTime[] _dateFini = { DateTime.Now + TimeSpan.FromDays(365), DateTime.Now + TimeSpan.FromDays(365) };
                private static readonly GiorniValidita[] _giorniValidita = { (GiorniValidita)_rnd.Next(0, 0x80), (GiorniValidita)_rnd.Next(0, 0x80) };

                static AgevolazioniFisseNormali()
                {
                    Tabella = new UniqueList<Agevolazione>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new AgevolazioneFissaNormale(_nomi[i], _descrizioni[i], _prezzi[i], _dateInizi[i], _dateFini[i], _giorniValidita[i]));
                }
            }
            public static class AgevolazioniScontateNormali
            {
                public static readonly IUniqueList<Agevolazione> Tabella;

                private static readonly string[] _nomi = { "Nessuna agevolazione", "Over65 5%", "Studenti 10%" };
                private static readonly string[] _descrizioni = { "Agevolazione di default", "Prezzo scontato del 5%", "Prezzo scontato del 10%" };
                private static readonly Percentuale[] _percentuali = { new Percentuale(0), new Percentuale(5), new Percentuale(10) };
                private static readonly DateTime[] _dateInizi = { DateTime.Now - TimeSpan.FromDays(365), DateTime.Now - TimeSpan.FromDays(365), DateTime.Now - TimeSpan.FromDays(365) };
                private static readonly DateTime[] _dateFini = { DateTime.Now + TimeSpan.FromDays(365), DateTime.Now + TimeSpan.FromDays(365), DateTime.Now + TimeSpan.FromDays(365) };
                private static readonly GiorniValidita[] _giorniValidita = { (GiorniValidita)0x7F, (GiorniValidita)_rnd.Next(0, 0x80), (GiorniValidita)_rnd.Next(0, 0x80) };
                private static readonly Dictionary<IFasciaOraria, Percentuale>[] _tariffari = { new Dictionary<IFasciaOraria, Percentuale>(), new Dictionary<IFasciaOraria, Percentuale>(), new Dictionary<IFasciaOraria, Percentuale>() };

                static AgevolazioniScontateNormali()
                {
                    Tabella = new UniqueList<Agevolazione>();
                    for (int i = 0; i < _nomi.Length; i++)
                    {
                        foreach (IFasciaOraria fascia in FasceOrarie.Tabella)
                            //se i è 0 ASN è Default, il tariffario impone sconto a 0
                            _tariffari[i].Add(fascia, new Percentuale((byte)(i == 0 ? 0 : i * 4 + 2)));

                        Tabella.Add(new AgevolazioneScontataNormale(_nomi[i], _descrizioni[i], _percentuali[i], _dateInizi[i], _dateFini[i], _giorniValidita[i], _tariffari[i]));
                    }
                }
            }
            public static class AgevolazioniFisseEccezionali
            {
                public static readonly IUniqueList<Agevolazione> Tabella;

                private static readonly string[] _nomi = { "Annulla", "FE3€/h", "FE5€/h" };
                private static readonly string[] _descrizioni = { "Annullamento noleggio", "Prezzo fisso orario di 3€", "Prezzo fisso orario di 5€" };
                private static readonly float[] _prezzi = { 0, 3, 5 };

                static AgevolazioniFisseEccezionali()
                {
                    Tabella = new UniqueList<Agevolazione>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new AgevolazioneFissaEccezionale(_nomi[i], _descrizioni[i], _prezzi[i]));
                }
            }
            public static class AgevolazioniScontateEccezionali
            {
                public static readonly IUniqueList<Agevolazione> Tabella;

                private static readonly string[] _nomi = { "SE10%", "SE25%" };
                private static readonly string[] _descrizioni = { "Prezzo scontato del 10%", "Prezzo scontato del 25%" };
                private static readonly Percentuale[] _percentuali = { new Percentuale(10), new Percentuale(25) };

                static AgevolazioniScontateEccezionali()
                {
                    Tabella = new UniqueList<Agevolazione>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new AgevolazioneScontataEccezionale(_nomi[i], _descrizioni[i], _percentuali[i]));
                }
            }
            #endregion

            #region TipiElementi
            public static class TipiElementiBiciclette
            {
                public static readonly IUniqueList<TipoElemento> Tabella;

                private static readonly string[] _nomi = { "Bicicletta da città", "Bicicletta da corsa", "Mountain bike" };
                private static readonly string[] _descrizioni = { "Bicicletta da città", "Bicicletta da corsa", "Bicicletta da montagna" };
                private static readonly float[] _tariffeBase = { 5, 10, 7 };
                private static readonly StatoTipoElemento[] _statiTipiElementi = { StatoTipoElemento.Attivo, StatoTipoElemento.Attivo, StatoTipoElemento.Attivo };

                static TipiElementiBiciclette()
                {
                    Tabella = new UniqueList<TipoElemento>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new TipoBicicletta(_nomi[i], _descrizioni[i], _tariffeBase[i], _statiTipiElementi[i]));
                }
            }
            public static class TipiElementiCaschi
            {
                public static readonly IUniqueList<TipoElemento> Tabella;

                private static readonly string[] _nomi = { "Casco da città", "Casco da corsa" }; //che caschi esistono? Rose migliora il tutto con le tue conoscenze!
                private static readonly string[] _descrizioni = { "Casco da città", "Casco da corsa" };
                private static readonly float[] _tariffeBase = { 3, 7 };
                private static readonly StatoTipoElemento[] _statiTipiElementi = { StatoTipoElemento.Attivo, StatoTipoElemento.Attivo };

                static TipiElementiCaschi()
                {
                    Tabella = new UniqueList<TipoElemento>();
                    for (int i = 0; i < _nomi.Length; i++)
                        Tabella.Add(new TipoCasco(_nomi[i], _descrizioni[i], _tariffeBase[i], _statiTipiElementi[i]));
                }
            }
            #endregion

            #region Elementi
            public static class ElementiBiciclette
            {
                public static readonly IUniqueList<Elemento> Tabella;

                private static readonly string[] _ids = { "0123456", "1234567",
                                                   "2345678", "3456789",
                                                   "4567890", "5678901",
                                                   "6789012", "7890123",
                                                   "8901234", "9012345" };
                private static readonly string[] _descrizioni = { "Città 0123456", "Città 1234567",
                                                           "Corsa 2345678", "Corsa 3456789",
                                                           "Montagna 4567890", "Montagna 5678901",
                                                           "Città 6789012", "Città 7890123",
                                                           "Corsa 8901234", "Corsa 9012345" };
                private static readonly StatoElemento[] _statiElementi = { FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("Noleggiabile"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("Noleggiabile"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("Noleggiabile"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("InRiparazione"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("InRiparazione") };
                private static readonly TipoElemento[] _tipiElementi = { TipiElementiBiciclette.Tabella[0], TipiElementiBiciclette.Tabella[0],
                                                              TipiElementiBiciclette.Tabella[1], TipiElementiBiciclette.Tabella[1],
                                                              TipiElementiBiciclette.Tabella[2], TipiElementiBiciclette.Tabella[2],
                                                              TipiElementiBiciclette.Tabella[0], TipiElementiBiciclette.Tabella[0],
                                                              TipiElementiBiciclette.Tabella[1], TipiElementiBiciclette.Tabella[1] };

                static ElementiBiciclette()
                {
                    Tabella = new UniqueList<Elemento>();
                    for (int i = 0; i < _ids.Length; i++)
                        Tabella.Add(new Bicicletta(_ids[i], _descrizioni[i], _statiElementi[i], _tipiElementi[i]));
                }
            }
            public static class ElementiCaschi
            {
                public static readonly IUniqueList<Elemento> Tabella;

                private static readonly string[] _ids = { "0121456", "1231567",
                                                   "2341678", "3451789",
                                                   "4561890", "5671901" };
                private static readonly string[] _descrizioni = { "Città 0123456", "Città 1234567",
                                                           "Corsa 2345678", "Corsa 3456789",
                                                           "Città 4567890", "Corsa 5678901" };
                private static readonly StatoElemento[] _statiElementi = { FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("Noleggiabile"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("Noleggiabile"),
                                                                FactoryStatiElemento.GetStato("Noleggiabile"), FactoryStatiElemento.GetStato("InRiparazione") };
                private static readonly TipoElemento[] _tipiElementi = { TipiElementiCaschi.Tabella[0], TipiElementiCaschi.Tabella[0],
                                                              TipiElementiCaschi.Tabella[1], TipiElementiCaschi.Tabella[1],
                                                              TipiElementiCaschi.Tabella[0], TipiElementiCaschi.Tabella[1] };

                static ElementiCaschi()
                {
                    Tabella = new UniqueList<Elemento>();
                    for (int i = 0; i < _ids.Length; i++)
                        Tabella.Add(new Casco(_ids[i], _descrizioni[i], _statiElementi[i], _tipiElementi[i]));
                }
            }
            #endregion

            #region Noleggi
            public static class NoleggiConcreti
            {
                public static readonly IUniqueList<Noleggio> Tabella;

                private static readonly DateTime[] _dateInizi = { DateTime.Now - TimeSpan.FromHours(5) };
                private static readonly DateTime[] _dateFini = { DateTime.Now + TimeSpan.FromHours(5) };
                private static readonly Cliente[] _clienti = { ClientiPersone.Tabella[0] };
                private static readonly IDipendente[] _dipendenti = { Dipendenti.Tabella[0] };
                private static readonly IList<ElementoNoleggio>[] _elementiNoleggi = { new List<ElementoNoleggio>() };

                static NoleggiConcreti()
                {
                    Tabella = new UniqueList<Noleggio>();

                    _elementiNoleggi[0].Add(new ElementoNoleggioConcreto(ElementiBiciclette.Tabella[0],
                        (IAgevolazioneNormale)AgevolazioniScontateNormali.Tabella[0]));
                    _elementiNoleggi[0].Add(new ElementoNoleggioConcreto(ElementiCaschi.Tabella[0],
                        (IAgevolazioneNormale)AgevolazioniScontateNormali.Tabella[0]));

                    for (int i = 0; i < _clienti.Length; i++)
                        Tabella.Add(new NoleggioConcreto(_dateInizi[i], _dateFini[i], _clienti[i], _dipendenti[i], _elementiNoleggi[i]));
                }
            }
            #endregion
        }
    }
}
