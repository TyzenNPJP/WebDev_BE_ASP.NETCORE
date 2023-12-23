using Microsoft.AspNetCore.Mvc;

namespace DNC9_ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        // Route in the URL matched to specified
        [Route("/Registration")]
        // Action method
        public IActionResult reg(Profile profile)
        {
            if (!ModelState.IsValid)
            {
                // LINQ statements which is like return from x, the x.Errors
                // LINQ are different from lambda exp in way that it uses SQL queries unlike lamda exp which uses plain logic
                string errors = string.Join("\n", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(errors);
            }

            return Content("Registration Complete!\n" +
                $"Name: {profile.name}\n" +
                $"Age: {profile.age}\n" +
                $"Phone: {profile.phone}\n" +
                $"Address: {profile.address}\n" +
                $"Email: {profile.email}");
        }
    }
}
