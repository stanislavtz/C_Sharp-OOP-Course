using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Weapons.Models
{
    public abstract class Weapon : IWeapon
    {
        protected Weapon(string name, int minDamage, int maxDamage, int numSokets)
        {
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.NumSockets = numSokets;
        }

        public string Name { get; }

        public int MinDamage { get; set ; }

        public int MaxDamage { get ; set ; }

        public int NumSockets { get; }
    }
}
