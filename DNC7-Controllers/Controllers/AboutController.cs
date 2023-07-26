using Microsoft.AspNetCore.Mvc;
using System;

namespace DNC7_Controllers.Controllers
{
    public class AboutController : Controller
    {
        // To return Json object type
        [Route("about")]
        public JsonResult about_method()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Zeus",
                number = 123587
            };

            return Json(person);
        }

        // IActionResult for general object that allows use of all return types
        [Route("about/person")]
        public IActionResult about_person_method()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Zeus",
                number = 123587
            };

            // For query of info and conditional on it returning Badrequest or Json
            if (Request.Query.ContainsKey("info"))
            {
                if (Convert.ToString(Request.Query["info"]) == "Zeus")
                {
                    return Json(person);
                }
                else
                {
                    //return Content("No endpoints connected to");
                    return BadRequest("Query out of accessible options");
                }
            }

            // For query download and return of file or content
            else if (Request.Query.ContainsKey("download"))
            {
                if (Convert.ToString(Request.Query["download"]) == "file2")
                {
                    return File("test.txt", "text/plain");
                }
                else
                {
                    return Content("No endpoints connected to");
                }
            }
            else
            {
                return Content("No endpoints connected to");
            }
        }
    }
}
