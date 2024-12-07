namespace Squawker.Models;

public class LastTrack
{
    public int Altitude { get; set; }
    public int AltitudeDifference { get; set; }
    public int ArrivalDistance { get; set; }
    public int DepartureDistance { get; set; }
    public int GroundSpeed { get; set; }
    public int Heading { get; set; }
    public int Latitude { get; set; }
    public int Longitude { get; set; }
    public bool OnGround { get; set; }
    public string? State { get; set; }
    public string? Timestamp { get; set; }
    public int Transponder { get; set; }
    public string? TransponderMode { get; set; }
    public int Time { get; set; }
}
