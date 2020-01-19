using Skclusive.Core.Component;

namespace Skclusive.Script.Prisma
{
    public class CoreStyleComponentBase : StaticComponentBase
    {
        protected readonly string media = "@media";

        protected readonly string keyframes = "@keyframes";

        protected readonly string webkitKeyframes = "@-webkit-keyframes";
    }
}
