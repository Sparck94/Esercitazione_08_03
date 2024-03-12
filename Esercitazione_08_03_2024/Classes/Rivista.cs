using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_08_03_2024.Classes
{
    internal class Rivista : Pubblicazione
    {

        public Rivista() 
        {

        }

        public Rivista(string codice, string titolo, string data, string categoria, float prezzo, int quantita)
        {
            Codice = codice;
            Titolo = titolo;
            DataDiPubblicazione = data;
            Categoria = categoria;
            Prezzo = prezzo;
            Quantita = quantita;
        }

        public override void stampaDettagli()
        {
            Console.WriteLine($"[RIVISTA]{Codice} {Titolo} {DataDiPubblicazione} {Categoria} {Prezzo}$ {Quantita}"); 
        }
    }
}
