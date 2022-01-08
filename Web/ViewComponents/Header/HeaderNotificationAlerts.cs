using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Header
{
    public class HeaderNotificationAlerts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
