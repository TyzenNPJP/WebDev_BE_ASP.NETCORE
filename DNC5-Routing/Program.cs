var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enables use and succession of endpoints that deal with the Http request accordingly
app.UseRouting();

// Normal middleware with connection to the next endpoint
app.Use(async (context, next) => {
    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();

    if (endpoint != null)
        await context.Response.WriteAsync($"Endpoint: {endpoint.DisplayName}\n {endpoint.RequestDelegate}\n");

    await next(context);
});

// Configuration of route parameters as expected and responding to it accordingly
app.UseEndpoints(endpoints =>
{
    // Endpoint with extension
    endpoints.Map("/Upload/{fileName}.{extension}", async (context) => {
        string? fileName = Convert.ToString(context.Request.RouteValues["fileName"]);
        string? extName = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"File called {fileName} with extension {extName} was uploaded\n");
    });

    // Simple endpoint
    endpoints.Map("/Home", async (HttpContext context) => {
        await context.Response.WriteAsync("This is the Homepage\n");
    });

    endpoints.Map("/About", async (context) => {
        await context.Response.WriteAsync("This is the About page\n");
    });

    // Endpoint with datetime route paramter constraint
    endpoints.Map("/Home/{Date:datetime}", async (context) => {
        DateTime date = Convert.ToDateTime(context.Request.RouteValues["Date"]);
        await context.Response.WriteAsync($"Current date is {date.ToShortDateString()}\n");
    });

    // Endpoint with guid parameter constraint
    endpoints.Map("/Home/{cityid:guid}", async context => {
        Guid guid = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"The city address and time stamp is: {guid}\n");
    });
});

// Response at the main branch
app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();