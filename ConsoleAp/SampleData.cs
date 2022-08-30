using Data.Models;

namespace ConsoleAp;

public static class SampleData
{
    public static IEnumerable<Vehicle> GetVehicles => new Vehicle[]
    {
        new Car("Hyundai Accent 2012", 500),
        new Car("Tesla model x", 400),
        new Car("BMW X5", 700),
        new Train("Train", 1000),
        new Airplane("Boeing 737", 5000)
    };
}