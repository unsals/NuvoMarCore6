using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Web.Controllers
{
    public class PortController : Controller
    {
        PortManager pm = new PortManager(new EfPortRepository());
        public IActionResult Index()
        {
            return RedirectToAction("List", "Port");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Port p)
        {
            PortValidator vr = new PortValidator();
            ValidationResult validationResult = vr.Validate(p);

            if (validationResult.IsValid)
            {
                p.PortStatus = true;
                p.PortCreateDate = DateTime.Now;
                pm.NAdd(p);
                return RedirectToAction("List", "Port");
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

        public IActionResult List()
        {
            var portList = pm.NGetAll();
            return View(portList);
        }

        public IActionResult Delete(int id)
        {
            var valueData = pm.NGetById(id);
            pm.NAdd(valueData);
            return RedirectToAction("List", "Port");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var portData = pm.NGetById(id); 
            return View(portData);
        }

        [HttpPost]
        public IActionResult Edit(Port p)
        {
            p.PortUpdateDate = DateTime.Now;
            pm.NUpdate(p);
            return RedirectToAction("List", "Port");
        }
    }
}
