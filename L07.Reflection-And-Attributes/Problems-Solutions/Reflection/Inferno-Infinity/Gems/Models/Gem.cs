using Inferno_Infinity.Gems.Contracts;
using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Gems.Models
{
    public abstract class Gem : IGem
    {
        public Gem()
        {
            
        }

        public int StrenghtIncreaseValue { get; set; }
        public int AgilityIncreaseValue { get; set; }
        public int VitalityIncreaseValue { get; set; }

        public abstract void IncreaseWeaponMagicStats(IWeapon weapon);
    }
}
