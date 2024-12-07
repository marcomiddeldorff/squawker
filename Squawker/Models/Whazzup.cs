namespace Squawker.Models;

public class Whazzup
{
    public string? UpdatedAt { get; set; }

    public List<Server>? Servers { get; set; }

    public List<VoiceServer>? VoiceServers { get; set; }

    public Connection? Connections { get; set; }

    public Clients? Clients { get; set; }

}
