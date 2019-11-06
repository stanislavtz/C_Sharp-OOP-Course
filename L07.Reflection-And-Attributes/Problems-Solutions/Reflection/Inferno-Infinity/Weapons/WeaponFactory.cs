using System;
using System.Linq;
using System.Reflection;

using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Weapons
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string weaponRarity, string name)
        {
            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == weaponType);

            if (type == null)
            {
                throw new ArgumentException();
            }

            var weapon = (IWeapon)Activator
                .CreateInstance(type, name);

            Type rarityType = Assembly
                        .GetCallingAssembly()
                        .GetTypes()
                        .FirstOrDefault(x => x.Name == weaponRarity);

            var rarityInstance = Activator
                .CreateInstance(rarityType, weapon);

            return weapon;
        }
    }
}
