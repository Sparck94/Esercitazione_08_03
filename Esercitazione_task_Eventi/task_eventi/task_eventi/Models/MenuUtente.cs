using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_eventi.Models
{
    internal class MenuUtente
    {
        private static MenuUtente? istanza;

        public static MenuUtente getIstanza()
        {
            if (istanza == null)
                istanza = new MenuUtente();
            return istanza;
        }
        private MenuUtente()
        {   
        
        }
        #region Menu Opzioni
        public void Opzioni()
        {
            bool uscita = true;
            while (uscita)
            {
                Console.WriteLine("Benvenuto, quale azione vuoi svolgere?\n" +
                "1. Per aggiungere.\n" +
                "2. Per controllare.\n" +
                "3. Per aggiornare.\n" +
                "4. Per cancellare.\n" +
                "Q. Per uscire dal menù.");
                string? inputUtente = Console.ReadLine().ToUpper();
                
                switch (inputUtente)
                {
                    case ("1"):
                        
                        bool uscita2 = true;
                        while (uscita2) 
                        {
                            Console.WriteLine("Che cosa vuoi aggiungere?\n" +
                            "1. Per aggiungere un evento.\n" +
                            "2. Per aggiungere un partecipante.\n" +
                            "3. Per aggiungere una risorsa.\n" +
                            "Q. Per uscire dal menù.");
                            string? inputUtente2 = Console.ReadLine().ToUpper();
                            switch (inputUtente2)
                            {
                                case ("1"):
                                    AddEvento();
                                    break;
                                case ("2"):
                                    AddPartecipante();
                                    break;
                                case ("3"):
                                    AddRisorsa();
                                    break;
                                case ("Q"):
                                    uscita2 = false;
                                    break;
                            }
                        }
                        
                        break;

                    case ("2"):
                        bool uscita3 = true;
                        while (uscita3)
                        {
                            Console.WriteLine("Che cosa vuoi controllare?\n" +
                            "1. Per controllare la lista degli eventi.\n" +
                            "2. Per controllare la lista dei partecipanti ad un evento.\n" +
                            "3. Per controllare le risorse di un evento.\n" +
                            "Q. Per uscire dal menù.");
                            string? inputUtente2 = Console.ReadLine().ToUpper();
                            switch (inputUtente2)
                            {
                                case ("1"):
                                    LeggiEventi();
                                    break;
                                case ("2"):
                                    LeggiPartecipanti();
                                    break;
                                case ("3"):
                                    LeggiRisorse();
                                    break;
                                case ("Q"):
                                    uscita3 = false;
                                    break;
                            }
                        }

                        break;
                    case ("3"):

                        break;
                    case ("4"):

                        break;
                    case ("Q"):
                        uscita2 = false;
                        break;
                }
                uscita = false;
            }
            

        }
        #endregion

        #region Aggiungi Evento
        public void AddEvento()
        {
            using (var ctx = new TaskEventiContext())
            {
                try
                {
                    Console.WriteLine("Inserisci il nome dell'evento: ");
                    string? inputNome = Console.ReadLine();
                    Console.WriteLine("Inserisci la descrizione dell'evento: ");
                    string? inputDescrizione = Console.ReadLine();
                    Console.WriteLine("Inserisci la capacità del tuo evento: ");
                    int inputCapacita = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci la data: ");
                    DateTime inputData = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il luogo: ");
                    string? inputLuogo = Console.ReadLine();
                    Evento e = new Evento()
                    {
                        Nome = inputNome,
                        Descrizione = inputDescrizione,
                        Capacita = inputCapacita,
                        DataOra = inputData,
                        Luogo = inputLuogo
                    };
                    ctx.Eventos.Add(e);
                    ctx.SaveChanges();
                    Console.WriteLine($"L'evento con ID: {e.EventoId} è stato inserito correttamente.");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
               
            }

        }
        #endregion

        #region Aggiungi Partecipante
        public void AddPartecipante()
        {
            using (var ctx = new TaskEventiContext())
            {
                try
                {
                    Console.WriteLine("Inserisci il tuo nome: ");
                    string? inputNome = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo contatto: ");
                    string? inputContatto = Console.ReadLine();
                    Console.WriteLine("Inserisci il tuo biglietto: ");
                    string? inputBiglietto = Console.ReadLine();
                    Console.WriteLine("Inserisci l'ID dell'evento a cui vuoi partecipare");
                    int inputEvento = int.Parse(Console.ReadLine());

                    Partecipante p = new Partecipante()
                    {
                        Nome = inputNome,
                        Contatto = inputContatto,
                        Biglietto = inputBiglietto,
                        EventoRif = inputEvento
                    };
                    ctx.Partecipantes.Add(p);
                    ctx.SaveChanges();
                    Console.WriteLine($"Il partecipante {p.Nome} è stato inserito correttamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        #endregion

        #region Aggiungi Risorsa
        public void AddRisorsa()
        {
            using (var ctx = new TaskEventiContext())
            {
                try
                {
                    Console.WriteLine("Inserisci il tipo della risorsa: ");
                    string? inputTipo = Console.ReadLine();
                    Console.WriteLine("Inserisci il costo della risorsa: ");
                    decimal inputCosto = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci la quantità della risorsa: ");
                    int inputQuantita = int.Parse(Console.ReadLine());                   
                    Console.WriteLine("Inserisci il nome del fornitore: ");
                    string? inputFornitore = Console.ReadLine();
                    Console.WriteLine("Inserisci l'ID dell'evento di riferimento");
                    int inputEvento = int.Parse(Console.ReadLine());
                    Risorsa r = new Risorsa()
                    {
                        Tipo = inputTipo,
                        Costo = inputCosto,
                        Quantita = inputQuantita,
                        Fornitore = inputFornitore,
                        EventoRif = inputEvento

                    };
                    ctx.Risorsas.Add(r);
                    ctx.SaveChanges();
                    Console.WriteLine($"La risorsa {r.Tipo} è stata inserita correttamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        #endregion

        #region Leggi Eventi
        public void LeggiEventi()
        {
            
            using (var ctx = new TaskEventiContext())
            {
                try
                {
                    foreach(Evento e in ctx.Eventos.ToList())
                    {
                        Console.WriteLine(e.Nome); 

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            
        }
        #endregion

        #region Leggi Partecipante
        public void LeggiPartecipanti()
        {
            using (var ctx = new TaskEventiContext())
            {
                Console.WriteLine("Di quale evento vuoi sapere tutti i partecipanti?");
                int inputEvento = int.Parse(Console.ReadLine());

                try
                {
                    var partecipantiEvento = ctx.Partecipantes
                                                .Where(p => p.EventoRif == inputEvento)
                                                .ToList();
                    if (partecipantiEvento.Any())
                    {
                        Console.WriteLine("Partecipanti all'evento: ");
                        foreach (Partecipante p in ctx.Partecipantes.ToList())
                        {
                            Console.WriteLine(p.Nome);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun partecipante risulta a questo evento.");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        #endregion

        #region Leggi Risorse

        public void LeggiRisorse()
        {
            using (var ctx = new TaskEventiContext())
            {
                Console.WriteLine("Di quale evento vuoi sapere tutte le risorse?");
                int inputEvento = int.Parse(Console.ReadLine());

                try
                {
                    var risorseEvento = ctx.Risorsas
                                                .Where(p => p.EventoRif == inputEvento)
                                                .ToList();
                    if (risorseEvento.Any())
                    {
                        Console.WriteLine("Risorse contenute in questo evento: ");
                        foreach (Risorsa r in ctx.Risorsas.ToList())
                        {
                            Console.WriteLine($"N: {r.Quantita} {r.Tipo} ");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessuna risorsa contenuta in questo evento.");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        #endregion
    }
}
