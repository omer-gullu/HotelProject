using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
