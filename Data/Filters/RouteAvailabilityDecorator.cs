using Data.Models;

namespace Domain.Filters;

public class RouteAvailabilityDecorator : VehicleFilterDecorator
{
    public RouteAvailabilityDecorator(IVehicleFilter wrapee) : base(wrapee)
    {
    }

    public override IEnumerable<Vehicle> GetVehicles(Route route)
    {
        if (route.IsAvailable)
            return _wrapee.GetVehicles(route);
        return new List<Vehicle>();
    }
}