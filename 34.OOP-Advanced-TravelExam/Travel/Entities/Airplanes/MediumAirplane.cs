namespace Travel.Entities.Airplanes
{
    public class MediumAirplane : Airplane
	{
        private const int seatsCount = 10;
        private const int bagsCount = 14;

        public MediumAirplane()
            : base(seatsCount, bagsCount)
		{
		}
	}
}