using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Skclusive.Script.Prisma
{

    public interface IPrismaHighlighter
    {
        Task<MarkupString> HighlightAsync(string code, string language);
    }
}
