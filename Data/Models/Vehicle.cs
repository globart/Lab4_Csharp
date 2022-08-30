namespace Data.Models;

public abstract class Vehicle
{
    public Vehicle(string name, int maxRange)
    {
        Name = name;
        MaxRange = maxRange;
    }
    
    public string? Name { get; set; }
    public int MaxRange { get; set; }
}