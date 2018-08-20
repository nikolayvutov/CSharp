namespace KingsGambit.Contracts
{
    using System.Collections.Generic;

    public interface IBoss
    {
        IReadOnlyCollection<ISubordinate> Subordinates { get; }

        void AddSubordinate(ISubordinate subordinate);

        void OnSubordinateDeath(object sender);
    }
}
