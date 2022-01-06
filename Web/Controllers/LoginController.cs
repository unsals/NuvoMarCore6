using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();

        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(NuvoUser p)
        {
            Context c = new Context();
            var datavalue = c.NuvoUsers.FirstOrDefault(x => x.UsrUserName == p.UsrUserName && x.UsrPassword == x.UsrPassword);
            if(datavalue != null)
            {
                HttpContext.Session.SetString("username", p.UsrUserName);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
    }
}
