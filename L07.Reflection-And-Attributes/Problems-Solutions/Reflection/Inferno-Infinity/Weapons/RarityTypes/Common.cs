using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.WeaponRarities
{
    public class Common
    {
        private const int CHANGE_COEFICIENT = 1;

        private readonly IWeapon weapon;

        public Common(IWeapon weapon)
        {
            this.weapon = weapon;
            this.IncreaseDamage();
        }

        private IWeapon IncreaseDamage()
        {
            this.weapon.MinDamage *= CHANGE_COEFICIENT;
            this.weapon.MaxDamage *= CHANGE_COEFICIENT;

            return this.weapon;
        }
    }
}
