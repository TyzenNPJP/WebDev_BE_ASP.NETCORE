// import for Controller inheritance
using Microsoft.AspNetCore.Mvc;
using DNC10_RazorViews.Models;

namespace DNC10_RazorViews.Controllers
{
    public class TransactionController : Controller
    {
        // Creates an instance of Person and Books
        Person p1 = new Person { id = 1, name = "Lana" };
        Person p2 = new Person { id = 2, name = "Luna" };

        Book b1 = new Book { id=100, title = "The Alchemist"};
        Book b2 = new Book { id=101, title = "Gita"};

        // Takes in route arguments by placing route parameter
        [HttpGet("/transaction/{id}")]

        // Action method that accepts the route argument as id
        // Index has to be the same name as view page
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return null;
            }

            else if (id == 1)
            {
                // Creating a modelWrapper class to contain more than one variable to be passed on to the view pages
                TransactionModelWrapper tmw1 = new TransactionModelWrapper();
                tmw1.personData = p1;
                tmw1.bookData = b1;
                return View(tmw1);
            }

            else if (id == 2)
            {
                TransactionModelWrapper tmw2 = new TransactionModelWrapper();
                tmw2.personData = p2;
                tmw2.bookData = b2;
                return View(tmw2);
            }

            // Works for returning razor page name "Index.cshtml" (action method name) by default
            return View();
        }
    }
}
