using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Skclusive.Script.Prism
{
    public interface IPrismHighlighter
    {
        Task<MarkupString> HighlightAsync(string code, string language);
    }
}
