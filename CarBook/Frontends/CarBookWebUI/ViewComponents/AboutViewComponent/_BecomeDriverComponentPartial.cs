using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.ViewComponents.AboutViewComponent
{
    public class _BecomeDriverComponentPartial : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

