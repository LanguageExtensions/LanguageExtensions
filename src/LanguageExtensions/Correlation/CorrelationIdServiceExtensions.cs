using LanguageExtensions.Correlation;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CorrelationIdServiceExtensions
    {
        public static IServiceCollection AddCorrelationContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<ICorrelationContextAccessor, CorrelationContextAccessor>();
            serviceCollection.AddTransient(s => s.GetService<ICorrelationContextAccessor>().CorrelationContext);
            return serviceCollection;
        }
    }
}
