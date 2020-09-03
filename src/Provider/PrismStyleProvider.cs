using Skclusive.Core.Component;

namespace Skclusive.Script.Prism
{
    public class PrismStyleProvider : StyleTypeProvider
    {
        public PrismStyleProvider() : base(typeof(PrismLightStyle), typeof(PrismDarkStyle))
        {
        }
    }
}
