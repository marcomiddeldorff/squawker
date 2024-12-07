namespace Squawker.Models;

public class PilotClient
{
    public int? Id { get; set; }
    public int? UserId { get; set; }
    public string? Callsign { get; set; }
    public string? ServerId { get; set; }
    public string? SoftwareTypeId { get; set; }
    public string? SoftwareVersion { get; set; }
    public int? Rating { get; set; }
    public int? Time { get; set; }
    public PilotSession? PilotSession { get; set; }
    public LastTrack? LastTrack { get; set; }
    public object? FlightPlan { get; set; }
}
