using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class PortList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
