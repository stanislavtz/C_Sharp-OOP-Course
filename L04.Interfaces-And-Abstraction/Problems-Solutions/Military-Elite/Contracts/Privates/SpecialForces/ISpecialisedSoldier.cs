using Military_Elite.Enumerators;

namespace Military_Elite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
