using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.ViewComponents.UILayoutViewComponents
{
    public class _LoaderUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
