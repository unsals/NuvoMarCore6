using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Header
{
    public class HeaderNotificationTasks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
