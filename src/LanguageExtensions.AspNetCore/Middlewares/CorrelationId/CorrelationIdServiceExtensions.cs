using LanguageExtensions.AspNetCore.Middlewares.CorrelationId;
using LanguageExtensions.Correlation;
using System;

namespace Microsoft.AspNetCore.Builder
{
    public static class CorrelationIdServiceExtensions
    {
        public static IApplicationBuilder UseCorrelationId(this IApplicationBuilder app)
        {
            if (app.ApplicationServices.GetService(typeof(ICorrelationContextAccessor)) == null)
            {
                throw new InvalidOperationException("Unable to find the required services. You must call the AddCorrelationId method in ConfigureServices in the application startup code.");
            }

            return app.UseMiddleware<CorrelationIdMiddleware>();
        }
    }
}
