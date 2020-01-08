using Military_Elite.Enumerators;

namespace Military_Elite.Contracts.SpecialForces
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; set; }
    }
}
