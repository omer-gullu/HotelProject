using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
