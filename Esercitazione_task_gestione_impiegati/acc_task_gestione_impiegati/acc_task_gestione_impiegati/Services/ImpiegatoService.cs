using acc_task_gestione_impiegati.Models;
using acc_task_gestione_impiegati.Repositories;

namespace acc_task_gestione_impiegati.Services
{
    

    public class ImpiegatoService
    {
        private readonly ImpiegatoRepo _repository;
        public ImpiegatoService(ImpiegatoRepo repo) 
        {
            _repository = repo;
        }
        public bool InserisciImpiegato(Impiegato imp)
        {
            return _repository.Insert(imp);
        }
        public List<Impiegato> ElencoImpiegati()
        {
            return _repository.GetAll();
        }
    }
}
