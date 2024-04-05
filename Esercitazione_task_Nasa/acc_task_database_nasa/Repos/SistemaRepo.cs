using acc_task_database_nasa.Models;

namespace acc_task_database_nasa.Repos
{
    public class SistemaRepo : IRepo<Sistema>
    {
        private readonly DatabaseNasaContext _context;
        public SistemaRepo(DatabaseNasaContext context)
        {
            _context = context;
        }
        public bool Create(Sistema entity)
        {
            try
            {
                _context.Sistemi.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(Sistema entity)
        {
            throw new NotImplementedException();
        }

        public Sistema Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sistema> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Sistema entity)
        {
            throw new NotImplementedException();
        }
    }
}
