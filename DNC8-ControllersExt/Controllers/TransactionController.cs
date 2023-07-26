using Microsoft.AspNetCore.Mvc;

namespace DNC8_ControllersExt.Controllers
{
    public class TransactionController : Controller
    {
        // Connects the following URL
        [HttpGet("/transaction")]

        // Collects tid from query URL
        public IActionResult transaction([FromQuery] int tid)
        {
            if (tid == 135)
            {
                StatusCode(200);
                return Content("The book has been purchased at a price of 4.99$");
            }
            else
            {
                return BadRequest("The purchase transaction cannot be found");
            }
        }
    }
}
