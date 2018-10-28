using System.Linq;
using Komis.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochod samochod;

        public HomeController(ISamochod samochodRepository)
        {
            samochod = samochodRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.tytul = "Przeglad samochodów";

            var samochody = samochod.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            return View(samochody);  
        }
    }
}
