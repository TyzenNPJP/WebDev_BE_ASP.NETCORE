using Microsoft.AspNetCore.Mvc;

namespace DNC12_Configuration.Controllers
{
    public class HomeController : Controller
    {
        // Inject the configuration file to the controller
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/")]
        public IActionResult Index()
        {
            // Making the api key value accessible anywhere
            ViewBag.api_key = _configuration.GetValue<int>("Weather_API_key");

            return View();
        }
    }
}
