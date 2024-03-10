/*
 * Module1
 * 
 * ABOUT - HTTP REQUEST / HTTP RESPONSE.
 * 
 * KEYWORDS - WebApplication, CreateBuilder(), Build(), Run(), HttpContext, async
 *              , Request, Method, GET, Path, Query, ContainsKey, WriteAsync("").
*/

var builder = WebApplication.CreateBuilder();
var app = builder.Build();


app.Run(async (HttpContext context) =>
{
    if (context.Request.Method == "GET" && context.Request.Path == "/")
    {
        if (context.Request.Query.ContainsKey("q"))
        {
            string q_str = context.Request.Query["q"][0];

            await context.Response.WriteAsync(q_str);
        }
    }
});

app.Run();
