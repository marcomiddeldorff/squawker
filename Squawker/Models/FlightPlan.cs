namespace Squawker.Models;

public class FlightPlan
{
    public int Id { get; set; }
    public int Revision { get; set; }
    public string AircraftId { get; set; }
    public int AircraftNumber { get; set; }
    public string DepartureId { get; set; }
    public string ArrivalId { get; set; }
    public string AlternativeId { get; set; }
    public string? Alternative2Id { get; set; }
    public string Route { get; set; }
    public string Remarks { get; set; }
    public string Speed { get; set; }
    public string Level { get; set; }
    public string FlightRules { get; set; }
    public string FlightType { get; set; }
    public int Eet { get; set; }
    public int Endurance { get; set; }
    public int DepartureTime { get; set; }
    public int ActualDepartureTime { get; set; }
    public int PeopleOnBoard { get; set; }
    public string CreatedAt { get; set; }
    public Aircraft Aircraft { get; set; }
    public string AircraftEquipments { get; set; }
    public string AircraftTransponderTypes { get; set; }
}
