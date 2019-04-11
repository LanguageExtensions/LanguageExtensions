using LanguageExtensions.AspNetCore.Middlewares.Ping;

namespace Microsoft.AspNetCore.Builder
{
    public static class PingMiddlewareExtensions
    {
        public static IApplicationBuilder AddPingEndpoint(this IApplicationBuilder app)
        {
            return app.UseMiddleware<PingMiddleware>();
        }
    }
}
