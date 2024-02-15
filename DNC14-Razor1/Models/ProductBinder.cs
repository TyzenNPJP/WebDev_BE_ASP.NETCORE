namespace DNC14_Razor1.Models
{
    public class ProductBinder
    {
        public List<Product> list_product = new List<Product>() {
            new Product(){ Id = 1, Name = "Desktop Computer", Price = 1700},
            new Product() { Id = 2, Name = "Laptop", Price = 2200}
            };
    }
}
