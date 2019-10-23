using _03BarracksFactory.Models.Units;

namespace P03_BarraksWars.Models.Units
{
    public class Gunner: Unit
    {
        private const int DefaultHealth = 21;
        private const int DefaultDamage = 20;

        public Gunner()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
