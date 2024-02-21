using Microsoft.AspNetCore.Mvc;

namespace ASP21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
