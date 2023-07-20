/*
 * ABOUT -  FILE HANDLING AS A HTTP RESPONSE
 *          @ WebApplicationOptions()
 *          @ UseStaticFiles()
 *          @ UseRouting()
 *          @ Combine()
*/

// For custom files folder create a different object of builder from a different constructor
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "Files"
});

var app = builder.Build();

// Allows use of files located at "wwwroot" folder from the URL
app.UseStaticFiles();

// Allows use of multiple folders for files to be accessed by URL
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Files2"))
});

// Enables HTTP request and response through URL
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("/Home", async (HttpContext context) => {
        await context.Response.WriteAsync("Yo!");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Nuthin..");
});

app.Run();