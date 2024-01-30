using DNC11_IProducts;
using Microsoft.AspNetCore.Mvc;
using DNC11_Products;

namespace DNC11_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        // Creating a reference object of the interface
        private readonly IProductCatagories productCatagories;
        
        // Constructor
        public HomeController(IProductCatagories prod)
        {
            productCatagories = prod;
        }
        [Route("/")]
        public IActionResult Index()
        {
            List<string> products = productCatagories.get_product_types();
            ViewBag.num_products = productCatagories.get_num_products();
            return View(products);
        }
    }
}
