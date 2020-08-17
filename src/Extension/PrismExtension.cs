using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Skclusive.Core.Component;

namespace Skclusive.Script.Prism
{
    public static class PrismExtension
    {
        public static void TryAddPrismServices(this IServiceCollection services)
        {
            services.TryAddScoped<IPrismHighlighter, PrismHighlighter>();
            services.AddScoped<IScriptTypeProvider, PrismScriptProvider>();
            services.AddScoped<IStyleTypeProvider, PrismStyleProvider>();
        }
    }
}
