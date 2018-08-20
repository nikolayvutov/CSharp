namespace KingsGambit.Contracts
{
    public delegate void SubordinateDeathEventHandler(object sender);

    public interface ISubordinate : INameble, IMortal
    {
        event SubordinateDeathEventHandler DeathEvent;

        string Action { get; }

        void ReactToAttack();
    }
}