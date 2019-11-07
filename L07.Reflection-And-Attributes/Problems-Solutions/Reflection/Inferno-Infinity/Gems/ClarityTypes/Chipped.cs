using Inferno_Infinity.Gems.Contracts;

namespace Inferno_Infinity.Gems.ClarityTypes
{
    public class Chipped
    {
        private const int COEFICIENT = 1;

        private IGem gem;

        public Chipped(IGem gem)
        {
            this.gem = gem;
            this.increaseGemStats(this.gem);
        }

        private void increaseGemStats(IGem gem)
        {
            gem.StrenghtIncreaseValue += COEFICIENT;
            gem.AgilityIncreaseValue += COEFICIENT;
            gem.VitalityIncreaseValue += COEFICIENT;
        }
    }
}
