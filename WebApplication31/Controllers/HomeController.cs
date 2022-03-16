using Microsoft.AspNetCore.Mvc;

namespace WebApplication31.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
