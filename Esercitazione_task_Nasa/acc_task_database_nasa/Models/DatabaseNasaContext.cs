using Microsoft.EntityFrameworkCore;

namespace acc_task_database_nasa.Models
{
    public class DatabaseNasaContext : DbContext
    {
        public DatabaseNasaContext(DbContextOptions<DatabaseNasaContext> options) : base(options) {

        }

        public DbSet<OggettoCeleste> OggettiCelesti { get; set; }

        public DbSet<Sistema> Sistemi { get; set; }
    }
}
