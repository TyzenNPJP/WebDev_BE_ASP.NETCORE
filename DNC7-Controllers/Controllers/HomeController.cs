using Microsoft.AspNetCore.Mvc;

namespace DNC7_Controllers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome!");
        }
    }
}
