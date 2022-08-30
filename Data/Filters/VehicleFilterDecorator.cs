using Data.Models;
using Domain.Repositories;

namespace Domain.Filters;

public abstract class VehicleFilterDecorator: IVehicleFilter
{
    protected readonly IVehicleFilter _wrapee;

    public VehicleFilterDecorator(IVehicleFilter wrapee)
    {
        _wrapee = wrapee;
    }

    public abstract IEnumerable<Vehicle> GetVehicles(Route route);
}