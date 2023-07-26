using Microsoft.AspNetCore.Mvc;

namespace DNC8_ControllersExt.Controllers
{
    public class BookInfoController : Controller
    {
        // Connects the URL with GET request with route parameters
        [HttpGet("/bookinfo/{id}/{name}/{price}")]

        // Takes route arguments to fill the vars and objects
        public IActionResult bookinfo([FromRoute] int? id, [FromRoute] Book book)
        {
            if (id >= 0 && id <= 100)
            {
                StatusCode(200);
                return Content($"The book id {id} is valid.\nBook Info:\nId: {book.id}\nName: {book.name}\nPrice: {book.price}");
            }
            else
            {
                return BadRequest($"The book id {id} is invalid.");
            }
        }
    }
}
