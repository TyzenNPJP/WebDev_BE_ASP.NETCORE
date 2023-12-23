/*
 * ABOUT -  (CUSTOM & BUILT-INT) MODEL VALIDATION ATTRIBUTES
 *       -  Prompting for a form with personal details and validating it
 *       
 *          @ LINQ
 *          @ ValidationAttributes
 *          @ [Required]
 *          @ [Phone]
 *          @ [StringLength()]
 *          @ [Email]
 *          
 *          @ ValidationAttribute
 *          @ ValidationResult
 *          @ ValidationResult.Success
*/

var builder = WebApplication.CreateBuilder(args);

// configures controllers to kick in, which handles HTTP request and response
builder.Services.AddControllers();

var app = builder.Build();

// enables route from URL and to respond accordingly
app.UseRouting();
app.MapGet("/", () => "Hello World!");

// Initiates all the controllers at once
app.MapControllers();

app.Run();
