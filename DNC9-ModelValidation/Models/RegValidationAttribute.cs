using System.ComponentModel.DataAnnotations;

namespace DNC9_ModelValidation.Models
{
    public class RegValidationAttribute : ValidationAttribute
    {
        // For setting up age validation limits upon instantiation
        public int? ageNum1 { get; set; }
        public int? ageNum2 { get; set; }

        public RegValidationAttribute() { }

        public RegValidationAttribute(int num1, int num2)
        {
            ageNum1 = num1;
            ageNum2 = num2;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value != null && value.GetType() == typeof(int))
            {
                int num = (int)value;
                if (num >= ageNum1 && num <= ageNum2)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
