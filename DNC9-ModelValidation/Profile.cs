using DNC9_ModelValidation.Models;
using System.ComponentModel.DataAnnotations;

namespace DNC9_ModelValidation
{
    // Profile class with all the input fields
    public class Profile
    {
        [Required]
        // !!!! RegularExpression does not seem to work, it only throws the error message no matter what the input
        //[RegularExpression("^[A-Za-z 0-9]&", ErrorMessage = "Name must be alphabets and numbers only.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be alphabets and numbers only.")]
        public string? name { get; set; }

        // Custom Validation of age
        [Required]
        [RegValidation(20, 100)]
        public int? age { get; set; }

        // Takes in numbers and a plus sign and nothing else
        [Phone]
        public string? phone { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Address must be a minimum of 10 characters and a maximum of 100 characters.")]
        public string? address { get; set; }

        // !!!! Takes in any string with a @ in the middle. All email service providers are not included in the .NET CORE Framework
        [Required]
        [EmailAddress]
        public string? email { get; set; }
    }
}
