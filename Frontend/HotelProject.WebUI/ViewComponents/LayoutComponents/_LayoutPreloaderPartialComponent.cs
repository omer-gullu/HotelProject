using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutPreloaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
