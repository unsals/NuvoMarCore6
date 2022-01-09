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
            return RedirectToAction("List", "Voyage");
        }

        public IActionResult List()
        {
            var values = vm.GetAllWithPortAndShip();
            return View(values);
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
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


            PortManager pm = new PortManager(new EfPortRepository());
            List<SelectListItem> portList = new List<SelectListItem>();
            foreach (var item in pm.NGetAll())
            {
                portList.Add(
                    new SelectListItem
                    {
                        Text = item.PortName,
                        Value = item.PortId.ToString()
                    });
            }
            ViewBag.portList = portList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Voyage p)
        {

            ShipManager sm = new ShipManager(new EfShipRepository());
            List<SelectListItem> shipList = new List<SelectListItem>();
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


            PortManager pm = new PortManager(new EfPortRepository());
            List<SelectListItem> portList = new List<SelectListItem>();
            foreach (var item in pm.NGetAll())
            {
                portList.Add(
                    new SelectListItem
                    {
                        Text = item.PortName,
                        Value = item.PortId.ToString()
                    });
            }
            ViewBag.portList = portList;



            VoyageValidator vv = new VoyageValidator();
            ValidationResult validationResult = vv.Validate(p);

            if (validationResult.IsValid)
            {
                p.VoyageCreateDate = DateTime.Now;
                vm.NAdd(p);
                return RedirectToAction("List", "Voyage");
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
            var deleteData = vm.NGetById(id);
            vm.NRemove(deleteData);
            return RedirectToAction("List", "Voyage");
        }

    }
}
