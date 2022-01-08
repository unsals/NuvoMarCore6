using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            //List<SelectListItem> shipList = (from x in sm.NGetAll()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = x.ShipName,
            //                                     Value = x.ShipId.ToString()
            //                                 }).ToList();
            //ViewBag.ShipList = shipList;

            ShipManager sm = new ShipManager(new EfShipRepository());
            List<SelectListItem> shipList = new List<SelectListItem>();
            shipList.Add(new SelectListItem { Text = "", Value = "" });

            foreach (var item in sm.NGetAll())
            {
                shipList.Add(
                    new SelectListItem
                    {
                        Text = item.ShipName,
                        Value = item.ShipId.ToString()
                    });
            }
            ViewBag.ShipList = shipList;
            return View();
        }

        [HttpPost]
        public IActionResult CallCreate(Voyage p)
        {
            VoyageValidator vv = new VoyageValidator();
            ValidationResult validationResult = vv.Validate(p);

            if (validationResult.IsValid)
            {
                p.VoyageCreateDate = DateTime.Now;
                vm.NAdd(p);
                return RedirectToAction("CallList", "Voyage");
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
