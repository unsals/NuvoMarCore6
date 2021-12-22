using BusinessLayer.Concrete;
using DataAccessLayer.EF;
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

    }
}
