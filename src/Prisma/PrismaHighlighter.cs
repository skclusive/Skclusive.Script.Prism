using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Skclusive.Script.Prisma
{
    public class PrismaHighlighter : IPrismaHighlighter
    {
        private IJSRuntime JSRuntime { get; }

        public PrismaHighlighter(IJSRuntime jsruntime)
        {
            JSRuntime = jsruntime;
        }

        public async Task<MarkupString> HighlightAsync(string code, string language)
        {
            string hilighted = await JSRuntime.InvokeAsync<string>("Skclusive.Script.Prisma.highlight", code, language);

            return new MarkupString(hilighted);
        }
    }
}
