using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_eventi.Models
{
    internal class MenuUtente
    {
        private static MenuUtente istanza;

        public static MenuUtente getIstanza()
        {
            if (istanza == null)
                istanza = new MenuUtente();
            return istanza;
        }
        private MenuUtente()
        {   
        
        }
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
                    Console.WriteLine($"L'evento {e.Nome} è stato inserito correttamente.");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
               
            }

        }


    }
}
