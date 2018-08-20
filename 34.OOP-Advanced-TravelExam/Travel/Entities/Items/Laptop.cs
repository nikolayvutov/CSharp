namespace Travel.Entities.Items
{
	public class Laptop : Item
	{
        private const int value = 3_000;

		public Laptop()
            : base(value)
		{
		}
	}
}