/*
 *  ABOUT -     CONTROLLERS WITH CONTENT, FILE AND REDIRECTION
 *              
 *              @ JsonResult
 *              @ Json()
 *              @ IActionResult
 *              @ Content()
 *              @ File()
 *              @ BadResult()
 *              @ RedirectResult()
*/

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
