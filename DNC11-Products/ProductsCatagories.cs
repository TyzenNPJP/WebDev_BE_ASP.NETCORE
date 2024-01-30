using DNC11_Products;
using DNC11_IProducts;

namespace DNC11_Products
{
    // Must inherit from the clone interface
    public class ProductCatagories : IProductCatagories
    {
        private List<string> product_catagories = new List<string>();
        private int num_products;

        public ProductCatagories()
        {
            product_catagories = new List<string> {
                "Electronics",
                "Clothing",
                "Furnitures",
                "Tools"
            };

            num_products = 50;
        }

        // To use vars, use it as a getter method
        public List<string> get_product_types()
        {
            return product_catagories;
        }

        public int get_num_products()
        {
            return num_products;
        }
    }
}
