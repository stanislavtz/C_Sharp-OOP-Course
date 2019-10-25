using _03BarracksFactory.Contracts;

namespace P03_BarraksWars.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository unitRepository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository unitRepository, IUnitFactory unitFactory)
        {
            this.data = data;
            this.unitRepository = unitRepository;
            this.unitFactory = unitFactory;
        }

        protected string[] Data => this.data;

        protected IRepository UnitRespository => this.unitRepository;
        
        protected IUnitFactory UnitFactory => this.unitFactory;

        public abstract string Execute();
    }
}
