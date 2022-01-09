using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Web.Controllers
{
    public class ShipController : Controller
    {
        ShipManager sm = new ShipManager(new EfShipRepository());

        public IActionResult Index()
        {
            return RedirectToAction("List", "Ship");
        }

        public IActionResult List(int page = 1)
        {
            var ship = sm.NGetAll().ToPagedList(page, 2);
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

        public IActionResult Delete(int id)
        {
            var deleteData = sm.NGetById(id);
            sm.RemoveShip(deleteData);
            return RedirectToAction("List", "Ship");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var shipData = sm.NGetById(id);
            return View(shipData);
        }


        [HttpPost]
        public IActionResult Edit(Ship p)
        {
            p.ShipUpdateDate = DateTime.Now;
            sm.NUpdate(p);
            return RedirectToAction("List", "Ship");
        }
    }
}
