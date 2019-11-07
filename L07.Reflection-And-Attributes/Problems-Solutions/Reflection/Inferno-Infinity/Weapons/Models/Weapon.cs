using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Weapons.Models
{
    public abstract class Weapon : IWeapon
    {
        private const int INITIAL_STRENGHT = 0;
        private const int INITIAL_AGILITY = 0;
        private const int INITIAL_VITALITY = 0;

        protected Weapon(string name, int minDamage, int maxDamage, int numSokets)
        {
            this.Name = name;

            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.NumSockets = numSokets;

            this.Strength = INITIAL_STRENGHT;
            this.Agility = INITIAL_AGILITY;
            this.Vitality = INITIAL_VITALITY;
        }

        public string Name { get; }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int NumSockets { get; }

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
    }
}
