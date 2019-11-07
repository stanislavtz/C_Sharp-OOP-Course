using Inferno_Infinity.Gems.Contracts;

namespace Inferno_Infinity.Gems.ClarityTypes
{
    public class Regular
    {

        private const int COEFICIENT = 2;

        private IGem gem;

        public Regular(IGem gem)
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
