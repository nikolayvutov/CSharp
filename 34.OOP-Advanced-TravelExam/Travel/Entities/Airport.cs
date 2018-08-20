namespace Travel.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Contracts;
	
    public class Airport : IAirport
	{
        private List<IBag> checkedBags;
        private List<IBag> confiscatedBags;
        private List<ITrip> trips;
        private List<IPassenger> passengers;

        public Airport()
        {
            this.checkedBags = new List<IBag>();
            this.confiscatedBags = new List<IBag>();
            this.trips = new List<ITrip>();
            this.passengers = new List<IPassenger>();
        }

        public IReadOnlyCollection<IBag> CheckedInBags => this.checkedBags.AsReadOnly();

        public IReadOnlyCollection<IBag> ConfiscatedBags => this.confiscatedBags.AsReadOnly();

        public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

        public IReadOnlyCollection<ITrip> Trips => this.trips.AsReadOnly();

        public IPassenger GetPassenger(string username) => this.passengers.FirstOrDefault(p => p.Username == username);

        public ITrip GetTrip(string id) => this.trips.FirstOrDefault(t => t.Id == id);

        public void AddPassenger(IPassenger passenger) => this.passengers.Add(passenger);

        public void AddTrip(ITrip trip) => this.trips.Add(trip);

        public void AddCheckedBag(IBag bag) => this.checkedBags.Add(bag);

        public void AddConfiscatedBag(IBag bag) => this.confiscatedBags.Add(bag);
	}
}