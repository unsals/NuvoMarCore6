using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<IActionResult> Index(NuvoUser p)
        {
            Context c = new Context();
            var datavalue = c.NuvoUsers.FirstOrDefault(x=>x.UsrUserName == p.UsrUserName && x.UsrPassword == p.UsrPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.UsrUserName)
                };

                var userIdentity = new ClaimsIdentity(claims, "a");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
    }
}


//Context c = new Context();
//var datavalue = c.NuvoUsers.FirstOrDefault(x => x.UsrUserName == p.UsrUserName && x.UsrPassword == p.UsrPassword);
//if (datavalue != null)
//{
//    HttpContext.Session.SetString("username", p.UsrUserName);
//    return RedirectToAction("Index", "Home");
//}
//else
//{
//    return View();
//}