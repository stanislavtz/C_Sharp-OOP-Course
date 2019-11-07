using Inferno_Infinity.Gems.Contracts;

namespace Inferno_Infinity.Gems.ClarityTypes
{
    public class Perfect
    {
        private const int COEFICIENT = 5;

        private IGem gem;

        public Perfect(IGem gem)
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
