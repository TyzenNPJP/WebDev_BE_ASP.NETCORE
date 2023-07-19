using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DNC3_Custom_Middleware_Class
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Yolo\n");
            await next(context);
        }
    }
}
