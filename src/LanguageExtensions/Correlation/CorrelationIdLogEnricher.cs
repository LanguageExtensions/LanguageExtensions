using Serilog.Core;
using Serilog.Events;
using System;

namespace LanguageExtensions.Correlation
{
    public class CorrelationIdLogEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (logEvent == null) throw new ArgumentNullException("logEvent");
            var correlationId = new CorrelationContextAccessor().CorrelationContext?.CorrelationId;
            if (!string.IsNullOrWhiteSpace(correlationId))
            {
                var correlationIdProperty = new LogEventProperty("CorrelationId", new ScalarValue(correlationId));
                logEvent.AddPropertyIfAbsent(correlationIdProperty);
            }
        }
    }
}
