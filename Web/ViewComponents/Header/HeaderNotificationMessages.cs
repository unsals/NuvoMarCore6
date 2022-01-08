using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Header
{
    public class HeaderNotificationMessages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
