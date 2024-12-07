namespace Squawker.Models;

public class Server
{
    public string? Id { get; set; }

    public string? Hostname { get; set; }

    public string? Ip { get; set; }
    
    public string? Description { get; set; }

    public string? CountryId { get; set; }

    public int? CurrentConnection { get; set; }

    public int? MaximumConnections { get; set; }
}
