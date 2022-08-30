using Data.Models;

namespace Domain.Filters;

public class VehicleTypeFilterDecorator : VehicleFilterDecorator
{
    public VehicleTypeFilterDecorator(IVehicleFilter wrapee) : base(wrapee)
    {
    }

    public override IEnumerable<Vehicle> GetVehicles(Route route)
    {
        return base._wrapee.GetVehicles(route)
            .Where(v => route.AvailableVehicleTypes.Contains(v.GetType().Name));
    }
}