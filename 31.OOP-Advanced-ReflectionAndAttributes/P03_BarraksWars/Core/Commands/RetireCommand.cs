namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];

            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No such units in repository.", ex);
            }
        }
    }
}
