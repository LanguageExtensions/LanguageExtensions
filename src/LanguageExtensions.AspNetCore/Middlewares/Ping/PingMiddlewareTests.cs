using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LanguageExtensions.AspNetCore.Middlewares.Ping
{
    public class PingMiddleware
    {
        private readonly RequestDelegate _next;

        public PingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/ping")
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("pong");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
