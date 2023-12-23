// import to inherit from built-in Controller class
using Microsoft.AspNetCore.Mvc;

namespace DNC10_RazorViews.Controllers
{
    public class HomeController : Controller
    {
        // Default route attribute
        [Route("/")]

        // Action method
        public IActionResult Index()
        {
            // Storing variables in a dictionary to be able to access it from the view page
            ViewData["data1"] = "A dummy string!";
            return View();
        }
    }
}
