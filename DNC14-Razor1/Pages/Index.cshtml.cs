using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DNC14_Razor1.Models;

namespace DNC14_Razor1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int productIndex;
        
        public Product currentProduct;
        public bool prod_submitted = false;
        public ProductBinder pb;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        { 
            
        }

        public void OnPost(int productIndex)
        {
            //productIndex = proudctIndex2;
            prod_submitted = true;
            pb = new ProductBinder();
            currentProduct = pb.list_product[productIndex];
        }

    }
}
