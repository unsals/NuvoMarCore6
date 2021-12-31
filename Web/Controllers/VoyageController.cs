using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class VoyageController : Controller
    {

        VoyageManager vm = new VoyageManager(new EfVoyageRepository());

        public IActionResult Index()
        {
            return RedirectToAction("CallList");
        }

        public IActionResult CallList()
        {
            var values = vm.GetAllWithPortAndShip();
            return View(values);
        }

        public IActionResult CallDetails(int id)
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult CallCreate()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CallCreate(Voyage v)
        {
            return View();
        }

    }
}
