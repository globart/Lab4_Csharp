using ConsoleAp;
using Data.Models;
using Domain.Filters;
using Domain.Repositories;

var vehiclesRepository = new VehiclesRepository();
vehiclesRepository.AddRange(SampleData.GetVehicles);

IVehicleFilter vehicleFilter = new VehicleFilter(vehiclesRepository);

var route = new Route()
{
    AvailableVehicleTypes = new List<string>() { typeof(Car).Name, typeof(Train).Name },
    Distance = 500,
    IsAvailable = true
};

vehicleFilter = new DistanceFilterDecorator(vehicleFilter);
vehicleFilter = new VehicleTypeFilterDecorator(vehicleFilter);
vehicleFilter = new RouteAvailabilityDecorator(vehicleFilter);

var vehicles = vehicleFilter.GetVehicles(route);

Console.WriteLine("Available transport:");
foreach (var vehicle in vehicles)
{
    Console.WriteLine($"{vehicle.Name}. MaxRange: {vehicle.MaxRange}");
}