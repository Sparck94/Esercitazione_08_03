using acc_task_database_nasa.Models;
using acc_task_database_nasa.Repos;

namespace acc_task_database_nasa.Services
{
    public class OggettoCelesteService : IService<OggettoCeleste>
    {
        private readonly IRepo<OggettoCeleste> _repository;

        public OggettoCelesteService(IRepo<OggettoCeleste> repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<OggettoCeleste> PrendiliTutti()
        {
            return _repository.GetAll();
        }

        public List<OggettoCeleste> Restituiscilitutti()
        {
            List<OggettoCeleste> elenco = this.PrendiliTutti().Select(o => new OggettoCeleste()
            {
                Nome = o.Nome,
                Codice = o.Codice,
                DataScoperta = o.DataScoperta,
                Scopritore = o.Scopritore,
                Tipologia = o.Tipologia,
                Distanza = o.Distanza,
                CoordinataRadiale = o.CoordinataRadiale,
                CoordinataAngolare = o.CoordinataAngolare
            }).ToList();

            return elenco;
        }
    }
}
