using MilitaryEliteVersion2.Enums;

namespace MilitaryEliteVersion2.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corp Corps { get; }
    }
}
