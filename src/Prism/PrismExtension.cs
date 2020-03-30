using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Skclusive.Script.Prism
{
    public static class PrismExtension
    {
        public static void TryAddPrismServices(this IServiceCollection services)
        {
            services.TryAddScoped<IPrismHighlighter, PrismHighlighter>();
        }
    }
}
