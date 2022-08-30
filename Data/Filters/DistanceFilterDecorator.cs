using Data.Models;
using Domain.Repositories;

namespace Domain.Filters;

public class DistanceFilterDecorator : VehicleFilterDecorator
{
    public DistanceFilterDecorator(IVehicleFilter wrapee) : base(wrapee)
    {
    }

    public override IEnumerable<Vehicle> GetVehicles(Route route)
    {
        return base._wrapee.GetVehicles(route)
            .Where(v => v.MaxRange >= route.Distance);
    }
}