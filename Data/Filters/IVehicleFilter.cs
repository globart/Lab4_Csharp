using Data.Models;

namespace Domain.Filters;

public interface IVehicleFilter
{
    IEnumerable<Vehicle> GetVehicles(Route route);
}