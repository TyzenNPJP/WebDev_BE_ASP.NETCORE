using Microsoft.AspNetCore.Mvc;

namespace DNC7_Controllers.Controllers
{
    public class ContactController : Controller
    {
        // Redirection to another controller
        [Route("contact")]
        public IActionResult contact_reply_method()
        {
            return new RedirectResult("/contacts", permanent: true);
        }
    }
}
