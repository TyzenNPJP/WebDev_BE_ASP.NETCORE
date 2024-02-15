using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DNC14_Razor1.Pages
{
    public class AboutModel : PageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double YearsOfService { get; set; }
        public List<AboutModel> Employees { get; set; }

        public void OnGet()
        {
            AboutModel ab = new AboutModel()
            {
                Id = 0,
                Name = "Kristina",
                YearsOfService = 1.5
            };

            Employees = new List<AboutModel>() {
                ab, 
                new AboutModel { Id=1, Name="Dylan", YearsOfService = 2} 
            };
        }
    }
}
