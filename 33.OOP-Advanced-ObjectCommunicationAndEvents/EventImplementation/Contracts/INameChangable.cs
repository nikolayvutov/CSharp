namespace EventImplementation.Contracts
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);


    public interface INameChangable
    {
        string Name { get; set; }

        void OnNameChange(NameChangeEventArgs args);

        event NameChangeEventHandler NameChange;
    }
}
