using System.Collections.Generic;

namespace MilitaryEliteVersion2.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepairs(IRepair repair);
    }
}
