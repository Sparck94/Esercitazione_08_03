using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace acc_lez26_biblioteca_task.Models
{
    internal class Prestito
    {
        public int PrestitoID { get; set; }
        public Date? DataPrestito { get; set; }
        public Date? DataRitorno { get; set; }
        public int UtenteRIF { get; set; }
        public int LibroRIF { get; set; }
        public Prestito() { }
        public Prestito(int prestitoID, Date dataPrestito, Date? dataRitorno, int utenteRIF, int libroRIF) 
        {
            PrestitoID = prestitoID;
            DataPrestito = dataPrestito;
            DataRitorno = dataRitorno;
            UtenteRIF = utenteRIF;
            LibroRIF = libroRIF;
        }
        

    }
}
