using Microsoft.Extensions.Primitives;
using System;

namespace LanguageExtensions.Correlation
{
    public class CorrelationContext
    {
        private CorrelationContext(string correlationId)
        {
            CorrelationId = !string.IsNullOrWhiteSpace(correlationId) ? correlationId : Guid.NewGuid().ToString();
        }

        public string CorrelationId { get; }

        public static implicit operator CorrelationContext(string correlationId) => new CorrelationContext(correlationId);
        public static implicit operator CorrelationContext(StringValues correlationId) => new CorrelationContext(correlationId);
        public static implicit operator CorrelationContext(Guid correlationId) => new CorrelationContext(correlationId.ToString());

        public static implicit operator string(CorrelationContext correlationId) => correlationId;
    }
}
