using acc_task_gestione_impiegati.Models;
using Microsoft.EntityFrameworkCore;

namespace acc_task_gestione_impiegati.Repositories
{
  
    public class ImpiegatoRepo : IRepo<Impiegato>
    {
        private readonly AccTaskGestioneImpiegatiContext _context;

        public ImpiegatoRepo(AccTaskGestioneImpiegatiContext ctx)
        {
            _context = ctx;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Impiegato> GetAll()
        {
            return _context.Impiegatos.ToList();
        }

        public Impiegato? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Impiegato t)
        {
            try
            {
                _context.Impiegatos.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Update(Impiegato t)
        {
            throw new NotImplementedException();
        }
    }
}
