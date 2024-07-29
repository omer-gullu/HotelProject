using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
