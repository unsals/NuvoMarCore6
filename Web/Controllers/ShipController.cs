using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShipController : Controller
    {
        ShipManager sm = new ShipManager(new EfShipRepository());

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult List()
        {
            var ship = sm.GetAll();
            return View(ship);
        }
    }
}
