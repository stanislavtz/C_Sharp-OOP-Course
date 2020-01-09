using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }

        void AddSoldier(ISoldier soldier); 
    }
}
