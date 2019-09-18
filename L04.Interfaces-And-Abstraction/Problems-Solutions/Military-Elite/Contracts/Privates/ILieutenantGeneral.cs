using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddSoldier(IPrivate soldier); 
    }
}
