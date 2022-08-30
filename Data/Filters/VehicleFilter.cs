using Data.Models;
using Domain.Repositories;

namespace Domain.Filters;

public class VehicleFilter : IVehicleFilter
{
    private readonly VehiclesRepository _vehiclesRepository;

    public VehicleFilter(VehiclesRepository vehiclesRepository)
    {
        _vehiclesRepository = vehiclesRepository;
    }

    public virtual IEnumerable<Vehicle> GetVehicles(Route route)
    {
        return _vehiclesRepository.GetAll();
    }
}