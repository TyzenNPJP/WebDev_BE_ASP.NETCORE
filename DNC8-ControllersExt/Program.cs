/*
 * ABOUT -  CONTROLLERS WITH ROUTE PARAMETERS AND VALUES
 *          
 *          @ [FromRoute]
 *          @ [FromQuery]
 *          @ IActionResult
 *          @ Content()
 *          @ BadRequest()
 *          @ [HttpGet("/")]
*/

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();