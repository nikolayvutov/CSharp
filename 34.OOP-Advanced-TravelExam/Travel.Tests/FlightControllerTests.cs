// REMOVE any "using" statements, which start with "Travel." BEFORE SUBMITTING

namespace Travel.Tests
{
    using System.Text;
    using NUnit.Framework;
    using Travel.Core.Controllers;
    using Travel.Core.Controllers.Contracts;
    using Travel.Entities;
    using Travel.Entities.Airplanes;
    using Travel.Entities.Contracts;
    using Travel.Entities.Items;

	[TestFixture]
    public class FlightControllerTests
    {
        private IFlightController flightController;
        private IAirport airport;

        [SetUp]
        public void SetUp()
        {
            this.airport = new Airport();
            this.flightController = new FlightController(airport);
        }

        [Test]
        public void SuccessfulTrip()
        {
            var sb = new StringBuilder();
            var passengers = new[]
            {
                new Passenger("Ivan"),
                new Passenger("Ivan2"),
                new Passenger("Ivan3"),
                new Passenger("Ivan4"),
                new Passenger("Ivan5"),
                new Passenger("Ivan6"),
            };

            var airplane = new LightAirplane();

            foreach (var passenger in passengers)
            {
                airplane.AddPassenger(passenger);
            }

            var trip = new Trip("Sofia", "London", airplane);

            airport.AddTrip(trip);

            var bag = new Bag(passengers[1], new[] { new Colombian() });

            passengers[1].Bags.Add(bag);

            var completedTrip = new Trip("Sofia", "Varna", new LightAirplane());
            completedTrip.Complete();

            airport.AddTrip(completedTrip);

            var actualResult = flightController.TakeOff();

            sb.AppendLine("SofiaLondon1:");
            sb.AppendLine("Overbooked! Ejected Ivan2");
            sb.AppendLine("Confiscated 1 bags ($50000)");
            sb.AppendLine("Successfully transported 5 passengers from Sofia to London.");
            sb.Append("Confiscated bags: 1 (1 items) => $50000");

            Assert.That(actualResult, Is.EqualTo(sb.ToString()));
            Assert.That(trip.IsCompleted, Is.True);
        }
    }
}
