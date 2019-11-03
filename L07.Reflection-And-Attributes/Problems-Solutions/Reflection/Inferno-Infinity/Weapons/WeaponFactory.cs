using System;
using System.Linq;
using System.Reflection;

using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Weapons
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string name)
        {
            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == weaponType);

            if (type == null)
            {
                throw new ArgumentException();
            }

            var instance = (IWeapon)Activator.CreateInstance(type, name);

            return instance;
        }
    }
}
