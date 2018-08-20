namespace Travel.Core.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Contracts;
	using Entities;
	using Entities.Contracts;
	using Entities.Factories;
	using Entities.Factories.Contracts;
    using Constants;
    using Travel.Entities.Airplanes;
    using Travel.Entities.Airplanes.Contracts;
    using Travel.Entities.Items.Contracts;

	public class AirportController : IAirportController
	{
		private const int BagValueConfiscationThreshold = 3_000;

		private IAirport airport;

        private IAirplaneFactory airplaneFactory;
		private IItemFactory itemFactory;

		public AirportController(IAirport airport)
		{
			this.airport = airport;
			this.airplaneFactory = new AirplaneFactory();
			this.itemFactory = new ItemFactory();
		}

		public string RegisterPassenger(string username)
		{
			if (this.airport.GetPassenger(username) != null)
			{
                throw new InvalidOperationException(string.Format(Constants.AlreadyHasPassenger, username));
			}

			var passenger = new Passenger(username);

			this.airport.AddPassenger(passenger);

            return string.Format(Constants.SuccessRegistredPassenger, passenger.Username);
		}

        public string RegisterTrip(string source, string destination, string planeType)
        {
            IAirplane airplane = this.airplaneFactory.CreateAirplane(planeType);

            ITrip trip = new Trip(source, destination, airplane);

            this.airport.AddTrip(trip);

            return string.Format(Constants.SuccessRegistredTrip, trip.Id);
        }

		public string RegisterBag(string username, IEnumerable<string> bagItems)
		{
            IPassenger passenger = this.airport.GetPassenger(username);
            List<IItem> items = new List<IItem>();

            foreach (var itemName in bagItems)
            {
                IItem createdItem = this.itemFactory.CreateItem(itemName);
                items.Add(createdItem);
            }

			var bag = new Bag(passenger, items);

			passenger.Bags.Add(bag);

            return $"Registered bag with {string.Join(", ", bagItems)} for {passenger.Username}";
		}


		public string CheckIn(string username, string tripId, IEnumerable<int> bagIndices)
		{
            IPassenger passenger = this.airport.GetPassenger(username);

            ITrip trip = this.airport.Trips.FirstOrDefault(t => t.Id == tripId);

            bool isCheckedIn = trip.Airplane.Passengers.Any(p => p.Username == username);

            //var trip = new Trip();
            //var checkedIn = this.trip.Passengers.Any(p => p.Username == username);
            if (isCheckedIn)
			{
                throw new InvalidOperationException(string.Format(Constants.AlreadyCheckedIn, username));
			}

			var confiscatedBags = CheckInBags(passenger, bagIndices);
			trip.Airplane.AddPassenger(passenger);

			return
				$"Checked in {passenger.Username} with {bagIndices.Count() - confiscatedBags}/{bagIndices.Count()} checked in bags";
		}

		private int CheckInBags(IPassenger passenger, IEnumerable<int> bagsToCheckIn)
		{
			var bags = passenger.Bags;

			var confiscatedBagCount = 0;
			foreach (var i in bagsToCheckIn)
			{
				var currentBag = bags[i];
				bags.RemoveAt(i);

				if (ShouldConfiscate(currentBag))
				{
					airport.AddConfiscatedBag(currentBag);
					confiscatedBagCount++;
				}
				else
				{
					this.airport.AddCheckedBag(currentBag);
				}
			}

			return confiscatedBagCount;
		}

		private bool ShouldConfiscate(IBag bag)
		{
			var luggageValue = 0;

            var itemsArray = bag.Items.ToArray();

            for (int i = 0; i < itemsArray.Length; i++)
			{
                luggageValue += itemsArray[i].Value;
			}

			var shouldConfiscate = luggageValue > BagValueConfiscationThreshold;
			return shouldConfiscate;
		}

	}
}