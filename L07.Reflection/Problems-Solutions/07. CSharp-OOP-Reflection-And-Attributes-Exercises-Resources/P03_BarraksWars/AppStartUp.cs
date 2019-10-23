namespace _03BarracksFactory
{
    using Data;
    using Core;
    using Contracts;
    using Core.Factories;
    using System.Collections;
    using System.Collections.Generic;

    class AppStartUp
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> army = new SortedDictionary<string, int>();
            IRepository repository = new UnitRepository(army);
            IUnitFactory unitFactory = new UnitFactory();

            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
