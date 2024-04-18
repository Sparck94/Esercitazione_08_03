using acc_task_gestione_impiegati.Models;
using acc_task_gestione_impiegati.Services;
using Microsoft.AspNetCore.Mvc;

namespace acc_task_gestione_impiegati.Controllers
{
    public class ImpiegatoController : Controller
    {
        private readonly ImpiegatoService _service;

        public ImpiegatoController(ImpiegatoService service)
        {
            _service = service;
        }
        public IActionResult Inserimento()
        {
            return View();
        }
        [HttpPost]
        public RedirectResult Salvataggio(Impiegato objImpiegato)
        {
            if (_service.InserisciImpiegato(objImpiegato))
                return Redirect("/Impiegato/Lista");
            else
                return Redirect("/Impiegato/Errore");
        }

        public IActionResult Lista()
        {
            List<Impiegato> elenco = _service.ElencoImpiegati();

            return View(elenco);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
