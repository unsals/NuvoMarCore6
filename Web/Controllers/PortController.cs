using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PortController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
