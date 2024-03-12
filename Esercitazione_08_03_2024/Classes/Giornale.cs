using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_08_03_2024.Classes
{
    internal class Giornale : Pubblicazione
    {
        public string? Redazione { get; set; }
        public Giornale() 
        {

        }

        public Giornale(string? codice, string? titolo, string? data, string? categoria, string? redazione, float prezzo, int quantita)
        {
            Codice = codice;
            Titolo = titolo;
            DataDiPubblicazione = data;
            Categoria = categoria;
            Redazione = redazione;
            Prezzo = prezzo;
            Quantita = quantita;


        }

        public override void stampaDettagli()
        {
            Console.WriteLine($"[GIORNALE]{Codice} {Titolo} {DataDiPubblicazione} {Categoria} {Redazione} {Prezzo}$ {Quantita}"); ;
        }
    }
}
