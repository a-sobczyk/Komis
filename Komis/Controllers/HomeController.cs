using System.Linq;
using Komis.Models;
using Komis.ViewModels;
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

            var samochody = samochod.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            HomeVM homeVM = new HomeVM()
            {
                Tytul = "Przeglad samochodow",
                Samochody = samochody.ToList()
            };

            return View(homeVM);  
        }

        public IActionResult Szczegoly(int id)
        {
            var samochod = this.samochod.PobierzSamochodOId(id);

            if (id == null)
                return NotFound();

            return View(samochod);
        }
    }
}
