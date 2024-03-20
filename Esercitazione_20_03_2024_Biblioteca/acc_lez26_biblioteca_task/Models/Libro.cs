using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace acc_lez26_biblioteca_task.Models
{
    internal class Libro
    {
        public int LibroID { get; set; }
        public string? Titolo { get; set; }
        public Date AnnoPubblicazione { get; set; }
        public bool isDisponibile { get; set; }

        public Libro() 
        {

        }
        public Libro(int libroID, string? titolo, Date annoPubblicazione, bool isDisp) 
        {
            LibroID = libroID;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            isDisponibile = isDisp;
        }

    }

    
}
