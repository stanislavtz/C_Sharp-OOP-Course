using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

using Inferno_Infinity.Weapons;
using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Core
{
    public class CodeExecute
    {
        private string weaponName;
        private readonly IList<IWeapon> weapons;

        public CodeExecute(IList<IWeapon> weapons)
        {
            this.weapons = weapons;
        }
       
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                var args = input.Split(";");

                if (args[0] == "Create")
                {
                    string weaponRarity = args[1].Split()[0];
                    string weaponType = args[1].Split()[1];

                    this.weaponName = args[2];

                    IWeapon weapon = new WeaponFactory()
                        .CreateWeapon(weaponType, this.weaponName);

                    Type type = Assembly
                        .GetCallingAssembly()
                        .GetTypes()
                        .FirstOrDefault(x => x.Name == weaponRarity);

                    var instance = Activator
                        .CreateInstance(type, weapon);

                    this.weapons.Add(weapon);
                }
                else if (args[0] == "Add")
                {
                    this.weaponName = args[1];

                    int soketIndex = int.Parse(args[2]);
                    string gemName = args[3];
                }
                else if (args[0] == "Remove")
                {
                    this.weaponName = args[1];

                    int soketIndex = int.Parse(args[2]);
                }
                else if (args[0] == "Print")
                {
                    this.weaponName = args[1];
                }

                input = Console.ReadLine();
            }
        }
    }
}
