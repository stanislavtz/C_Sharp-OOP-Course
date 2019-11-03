using System.Collections.Generic;

using Inferno_Infinity.Core;
using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity
{
    class AppStartUp
    {
        static void Main(string[] args)
        {
            IReadOnlyCollection<IWeapon> weapons = new List<IWeapon>();
            var engine = new CodeExecute(weapons as IList<IWeapon>);
            engine.Run();
        }
    }
}
