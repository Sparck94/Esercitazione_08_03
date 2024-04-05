namespace acc_task_database_nasa.Models
{
    public class OggettoCeleste
    {
        public string Nome { get; set; } = null!;
        public string Codice { get; set; } = null!;
        public DateOnly DataScoperta { get; set; }
        public string Scopritore { get; set; } = null!;
        public string Tipologia { get; set; } = null!;
        public decimal Distanza { get; set; } 
        public decimal CoordinataRadiale { get; set; } 
        public decimal CoordinataAngolare { get; set; }
    }
}
