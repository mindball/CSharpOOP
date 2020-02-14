namespace ExercisesKingsGambitExtended.Contracts
{
    using System.Collections.Generic;
    public interface IKing : INameble, IAttackable
    {
        IReadOnlyCollection<ISubordinateble> Subordinates { get; }

        void AddSubordinate(ISubordinateble subordinate);

        void OnSubordinateDeatch(object sender);
    }
}
