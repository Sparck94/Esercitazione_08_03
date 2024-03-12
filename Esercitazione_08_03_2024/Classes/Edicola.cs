using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_08_03_2024.Classes
{
    internal class Edicola
    {
        public string? Nome { get; set; }
        public string? Indirizzo { get; set; }
        public List<Pubblicazione> inventario { get; set; } = new List<Pubblicazione>();

        public Edicola(string? nome, string? indirizzo) 
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }
        public void aggiungiPub(Pubblicazione pub)
        {
            inventario.Add(pub);
            
        }

        public void stampaElenco()
        {
            foreach(Pubblicazione pub in inventario)
            {
                pub.stampaDettagli();
            }
        }
        public void rimuoviPub(Pubblicazione pub)
        {
            inventario.Remove(pub);
        }

        public void aggiornaQuantita(string? codice, int quantita)
        {
            foreach (Pubblicazione pub in inventario)
            {
                if (pub.Codice == codice)
                {
                    pub.Quantita = quantita;
                    break;
                }

            }
        }
        
    }
}
