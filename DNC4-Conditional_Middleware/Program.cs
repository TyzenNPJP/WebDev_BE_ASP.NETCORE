/*
 * ABOUT -  CONDITIONAL MIDDLEWARE
 *          @ Allows HTTP response upon prior condition
 *          @ Allows branching of middleware to next middleware
*/

//  Creates an instance of WebApplicationBuilder class, which is a pre-configured composition to start the application
var builder = WebApplication.CreateBuilder();
//  Uses the only method in the builder instance, initializes the application
var app = builder.Build();

//  Adds a condition to the middleware and passes the line of execution to the next middleware
app.UseWhen(
    context => context.Request.Query.ContainsKey("username"),
    app => {
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Condition Met");
            await next();
        });
    });

//  The second middleware
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Main branch aciton");
});

app.Run();