namespace Data.Models;

public class Route
{
    public string? From { get; set; }
    public string? To { get; set; }
    public int Distance { get; set; }
    public bool IsAvailable { get; set; }
    
    public List<string> AvailableVehicleTypes { get; set; } = new List<string>();
}