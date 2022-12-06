using Microsoft.AspNetCore.Mvc;

namespace WebAPItutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
