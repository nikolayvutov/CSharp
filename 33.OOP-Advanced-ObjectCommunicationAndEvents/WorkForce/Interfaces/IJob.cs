namespace WorkForce.Interfaces
{
    public interface IJob
    {
        string Name { get; }
        int RequiredWorkHours { get; }
        bool IsDone { get; set; }

        IEmployee Employee { get; }

        void Update();
    }
}
