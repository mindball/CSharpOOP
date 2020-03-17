using System.Collections.Generic;

namespace DotnetLeadRealExample.Contracts
{
    public interface IMediator<T>
    {
        List<IColleague<T>> ColleagueList { get; }

        void DistributeMessage(IColleague<T> sender, T message);

        void Register(IColleague<T> colleague);
    }
}
