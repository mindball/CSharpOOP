using System.Collections.Generic;

namespace MilitaryEliteVersion2.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
        void AddPrivate(IPrivate privateSoldier);
    }
}
