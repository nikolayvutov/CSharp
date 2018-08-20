namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;
    using System.Reflection;
    using System.Linq;
    using System;

	public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{
            var allTypes = Assembly.GetCallingAssembly().GetTypes();

            var setTypes = allTypes.Where(t => typeof(IAirplane).IsAssignableFrom(t))
                                   .FirstOrDefault(t => t.Name == type);

            var result = (IAirplane)Activator.CreateInstance(setTypes);

            return result;
		}
	}
}