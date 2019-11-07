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
            this.increaseGemStats();
        }

        private IGem increaseGemStats()
        {
            this.gem.StrenghtIncreaseValue += COEFICIENT;
            this.gem.AgilityIncreaseValue += COEFICIENT;
            this.gem.VitalityIncreaseValue += COEFICIENT;

            return this.gem;
        }
    }
}
