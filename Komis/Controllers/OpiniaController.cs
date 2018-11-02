using Komis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRpository opiniaRpository;

        public OpiniaController(IOpiniaRpository opiniaRpository)
        {
            this.opiniaRpository = opiniaRpository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                opiniaRpository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }

            return View(opinia);
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}