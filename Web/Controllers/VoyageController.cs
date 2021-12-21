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
            var values = vm.GetAllWithPortAndShip();
            return View(values);
        }
    }
}
