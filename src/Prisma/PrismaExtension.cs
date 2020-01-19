using Microsoft.Extensions.DependencyInjection;

namespace Skclusive.Script.Prisma
{
    public static class PrismaExtension
    {
        public static void AddPrisma(this IServiceCollection services)
        {
            services.AddSingleton<IPrismaHighlighter, PrismaHighlighter>();
        }
    }
}
