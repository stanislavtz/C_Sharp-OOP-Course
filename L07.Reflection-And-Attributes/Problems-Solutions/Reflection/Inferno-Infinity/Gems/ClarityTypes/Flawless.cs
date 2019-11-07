using Inferno_Infinity.Gems.Contracts;

namespace Inferno_Infinity.Gems.ClarityTypes
{
    public class Flawless
    {
        private const int COEFICIENT = 10;

        private IGem gem;

        public Flawless(IGem gem)
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
