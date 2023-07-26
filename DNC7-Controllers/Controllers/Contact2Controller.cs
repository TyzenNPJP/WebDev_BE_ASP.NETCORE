using Microsoft.AspNetCore.Mvc;

namespace DNC7_Controllers.Controllers
{
    public class Contact2Controller : Controller
    {
        // Controler where it gets redirected from another controller
        [Route("contacts")]
        public IActionResult contact_reply_method2()
        {
            return Content("You have been redirected to a new web page!\n");
        }
    }
}
