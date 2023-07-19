/*
 * ABOUT -  MIDDLEWARE
 *          @ ORDERING HTTP RESPONSE
*/

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use method to be able to branch the main method on next middleware
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hey");
    await next(context);
});

// Run method allows operation of single middle
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Howdy");
});

// This method allows initiation of the main program
app.Run();
