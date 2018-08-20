namespace EventImplementation.Contracts
{
    public interface INameChangeHandler
    {
        void OnDispatcherNameCHange(object sender, NameChangeEventArgs args);
    }
}
