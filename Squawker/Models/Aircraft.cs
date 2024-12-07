namespace Squawker.Models;

public class Aircraft
{
    public string IcaoCode { get; set; }
    public string Model { get; set; }
    public string WakeTurbulence { get; set; }
    public bool IsMilitary { get; set; }
    public string Description { get; set; }
}
