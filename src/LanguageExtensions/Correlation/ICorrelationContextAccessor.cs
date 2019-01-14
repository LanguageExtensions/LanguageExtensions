using System.Threading;

namespace LanguageExtensions.Correlation
{
    public interface ICorrelationContextAccessor
    {
        CorrelationContext CorrelationContext { get; set; }
    }

    internal class CorrelationContextAccessor : ICorrelationContextAccessor
    {
        private static AsyncLocal<CorrelationContext> _correlationContext = new AsyncLocal<CorrelationContext>();

        public CorrelationContext CorrelationContext
        {
            get => _correlationContext.Value;
            set => _correlationContext.Value = value;
        }
    }
}
