using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Gems.Contracts
{
    public interface IGem
    {
        int StrenghtIncreaseValue { get; set; }
        int AgilityIncreaseValue { get; set; }
        int VitalityIncreaseValue { get; set; }

        void IncreaseWeaponMagicStats(IWeapon weapon);
    }
}
