using LanguageExtensions.AspNetCore.Middlewares.CorrelationId;
using LanguageExtensions.Correlation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Microsoft.AspNetCore.Builder
{
    public static class CorrelationIdServiceExtensions
    {
        public static IServiceCollection AddCorrelationContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<ICorrelationContextAccessor, CorrelationContextAccessor>();
            serviceCollection.AddTransient(s => s.GetService<ICorrelationContextAccessor>().CorrelationContext);
            return serviceCollection;
        }

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
