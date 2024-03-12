using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_08_03_2024.Classes
{
    internal abstract class Pubblicazione
    {
        public string? Codice { get; set; }
        public string? Titolo { get; set; }
        public string? DataDiPubblicazione { get; set; }
        public string? Categoria { get; set; }
        public float Prezzo { get; set; }
        public int Quantita { get; set; }

        public abstract void stampaDettagli();

        




    }

    
}
