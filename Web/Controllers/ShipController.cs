using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            var ship = sm.NGetAll();
            return View(ship);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ship s)
        {
            ShipValidator sr = new ShipValidator();
            ValidationResult validationResult = sr.Validate(s);

            if (validationResult.IsValid)
            {
                s.ShipStatus = true;
                s.ShipCreateDate = DateTime.Now;
                sm.NAdd(s);
                return RedirectToAction("List", "Ship");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
            
        }
    }
}
