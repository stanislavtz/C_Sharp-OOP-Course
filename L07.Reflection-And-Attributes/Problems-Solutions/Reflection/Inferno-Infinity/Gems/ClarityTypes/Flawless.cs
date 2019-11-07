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
