using Microsoft.Extensions.DependencyInjection;

namespace Skclusive.Script.Prism
{
    public static class PrismExtension
    {
        public static void AddPrism(this IServiceCollection services)
        {
            services.AddSingleton<IPrismHighlighter, PrismHighlighter>();
        }
    }
}
