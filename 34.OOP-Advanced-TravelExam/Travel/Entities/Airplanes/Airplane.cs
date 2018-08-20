namespace Travel.Entities.Airplanes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.Immutable;
	using System.Linq;
	using Entities.Contracts;
    using Travel.Entities.Airplanes.Contracts;
    using Travel.Entities.Items;

    // migrated from java. please do the needful kind sir
    public abstract class Airplane : IAirplane
    {
        private readonly List<IBag> baggage;
        private readonly List<IPassenger> passengers;

        protected Airplane(int seats, int bags) 
        {
            this.Seats = seats;
            this.BaggageCompartments = bags;

            this.baggage = new List<IBag>();
            this.passengers = new List<IPassenger>();
		}
        public int Seats { get; }
		
        public bool IsOverbooked => this.Passengers.Count() > this.Seats;

        public IReadOnlyCollection<IBag> BaggageCompartment => this.baggage.AsReadOnly();

        public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

        public int BaggageCompartments { get; }

        public void AddPassenger(IPassenger passenger)
        {
            this.passengers.Add(passenger);
		}

        public IPassenger RemovePassenger(int indexSeat) 
        {	
            var passenger = this.passengers[indexSeat];
            this.passengers.RemoveAt(indexSeat);

            return passenger;
		}

        public IEnumerable<IBag>EjectPassengerBags(IPassenger passenger) 
        {		
            var passengerBags = this.baggage
				.Where(b => b.Owner == passenger)
				.ToArray();

			foreach (var bag in passengerBags)
				this.baggage.Remove(bag);

			return passengerBags;
		}

		public void LoadBag(IBag bag) 
        {
			var isBaggageCompartmentFull = this.BaggageCompartment.Count + 1
                                               > this.BaggageCompartments;
			if (isBaggageCompartmentFull)
				throw new InvalidOperationException($"No more bag room in {this.GetType().ToString()}!");

			this.baggage.Add(bag);
		}
	}
}