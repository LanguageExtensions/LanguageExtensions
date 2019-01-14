using LanguageExtensions.Correlation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Threading.Tasks;

namespace LanguageExtensions.AspNetCore.Middlewares.CorrelationId
{
    public class CorrelationIdMiddleware
    {
        private readonly string _header = "X-Correlation-ID";
        private readonly RequestDelegate _next;

        /// <summary>
        /// Creates a new instance of the CorrelationIdMiddleware.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline.</param>
        /// <param name="options">The configuration options.</param>
        public CorrelationIdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Processes a request to synchronise TraceIdentifier and Correlation ID headers. Also creates a 
        /// <see cref="CorrelationContext"/> for the current request and disposes of it when the request is completing.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> for the current request.</param>
        /// <param name="correlationContextFactory">The <see cref="ICorrelationContextFactory"/> which can create a <see cref="CorrelationContext"/>.</param>
        public async Task Invoke(HttpContext context, ICorrelationContextAccessor correlationContextAccessor)
        {
            StringValues correlationId = GetCorrelationId(context);

            context.TraceIdentifier = correlationId;
            correlationContextAccessor.CorrelationContext = (CorrelationContext)correlationId;

            // apply the correlation ID to the response header for client side tracking
            context.Response.OnStarting(() =>
            {
                if (!context.Response.Headers.ContainsKey(_header))
                {
                    context.Response.Headers.Add(_header, correlationId);
                }

                return Task.CompletedTask;
            });

            await _next(context);
        }

        private StringValues GetCorrelationId(HttpContext context)
        {
            var correlationIdFoundInRequestHeader = context.Request.Headers.TryGetValue(_header, out var correlationId);

            if (RequiresGenerationOfCorrelationId(correlationIdFoundInRequestHeader, correlationId))
                correlationId = GenerateCorrelationId(context.TraceIdentifier);

            return correlationId;
        }

        private static bool RequiresGenerationOfCorrelationId(bool idInHeader, StringValues idFromHeader) =>
            !idInHeader || string.IsNullOrWhiteSpace(idFromHeader);

        private StringValues GenerateCorrelationId(string traceIdentifier) => Guid.NewGuid().ToString();
    }
}
