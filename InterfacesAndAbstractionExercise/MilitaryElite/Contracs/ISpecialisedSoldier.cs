using MilitaryElite.Enums;

namespace MilitaryElite.Contracs
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corp Corps { get; }
    }
}
