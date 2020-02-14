using System.Collections.Generic;

namespace MilitaryElite.Contracs
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    
    }
}
