using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeadPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
