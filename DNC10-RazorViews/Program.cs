/*
 *  ABOUT -     RAZOR VIEWS PAGES / TRANSFER DATA FROM CONTROLLER TO VIEWS
 *  
 *              @ @{}
 *              @ @varName
 *              @ ViewData[""]
 *              @ ViewBag.
 *              @ return View()
 *              @ return View(var/obj)
 *              @ return View("pageName", var/obj)
 *              @ Shared folder
 *              @ _ViewImports folder
*/

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
