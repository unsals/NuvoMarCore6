using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PortController : Controller
    {
        PortManager pm = new PortManager(new EfPortRepository());
        public IActionResult Index()
        {
            return RedirectToAction("List", "Port");
        }

        public IActionResult List()
        {
            var portList = pm.NGetAll();
            return View(portList);
        }
    }
}
