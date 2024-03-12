using Esercitazione_08_03_2024.Classes;

namespace Esercitazione_08_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Che operazione vuoi effettuare?\n1.Aggiungi pubblicazione.\n2.Rimuovi pubblicazione.\n3.Aggiorna quantità pubblicazioni.\nQ. per uscire.");
            string? sceltaUtenteMenu = Console.ReadLine();

            //switch (sceltaUtenteMenu)
            //{
            //    case "1":
            //        Console.WriteLine("Premi 1 per aggiungere una rivista\nPremi 2 per aggiungere un giornale");
            //        string? sceltaTipologiaPubblicazione = Console.ReadLine();
            //        if (sceltaTipologiaPubblicazione !="1" && sceltaTipologiaPubblicazione != "2")
            //        {
            //            Console.WriteLine("Errore di digitazione");
            //            break;
            //        }
            //        Console.WriteLine("sadasdd");


            //        break;
            //    case "2":
            //        Console.WriteLine("It is 2");
            //        break;
            //    default:
            //        break;
            //}


            Pubblicazione gioUno = new Giornale("2","Corriere Della sera", "25/02/1994", "Sportivo", "ABDSHU", 1.20f, 1);
            Pubblicazione gioTre = new Giornale("1","Corriere Dello Sport", "24/06/2021", "Sportivo", "ABDSHi", 2.40f, 10);
            Pubblicazione gioDue = new Giornale("3","Corriere Della sera", "26/05/2023", "Attualita", "ABDSHt", 0.95f,15);

            Pubblicazione rivUno = new Rivista("4","Chi", "09/03/2021", "Attualita", 2.50f, 6);
            Pubblicazione rivDue = new Rivista("5","Bo", "10/04/2021", "Gossip", 3.40f, 8);
            Pubblicazione rivTre = new Rivista("6","Shazam", "11/05/2021", "Tecnologia", 1.65f, 10);


            Edicola edi = new Edicola("Er Giornalaro", "Via del Coatto, 22");
            edi.aggiungiPub(gioUno);
            edi.aggiungiPub(gioDue);
            edi.aggiungiPub(gioTre);
            edi.aggiungiPub(rivUno);
            edi.aggiungiPub(rivDue);
            edi.aggiungiPub(rivTre);



            edi.stampaElenco();

            edi.aggiornaQuantita("6",8);

            edi.stampaElenco();

            
            
            
            



        }
    }
}
