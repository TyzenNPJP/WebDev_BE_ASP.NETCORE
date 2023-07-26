using Microsoft.AspNetCore.Mvc;

namespace DNC7_Controllers.Controllers
{
    public class UploadController : Controller
    {
        // Route attribute
        // Return declaration of VirtualFileResult for returning file types to be specific than IActionResult
        [Route("upload")]
        public VirtualFileResult upload_method()
        {
            return File("test.txt", "text/plain");
        }
    }
}
