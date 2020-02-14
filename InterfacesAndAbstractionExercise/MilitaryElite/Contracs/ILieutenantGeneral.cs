using System.Collections.Generic;

namespace MilitaryElite.Contracs
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

        void AddPrivate(IPrivate privateSoldier);
    }
}
