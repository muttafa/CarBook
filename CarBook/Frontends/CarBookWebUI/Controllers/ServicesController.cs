using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
