using acc_task_database_nasa.Repos;
using Microsoft.AspNetCore.Mvc;

namespace acc_task_database_nasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OggettoCelesteController : Controller
    {
        private readonly OggettoCelesteController _service;

        public OggettoCelesteController(OggettoCelesteController service)
        {
            _service = service;
        }
        //[HttpPost("inserisci")]
        //public IActionResult InserisciOggettoCeleste(OggettoCelesteRepo)

        [HttpGet("elenco")]
        public ActionResult<List<OggettoCelesteRepo>> ElencoOggettiCelesti()
        {
            return _service.Restituiscitutti();
        }
    }
}
