using Squawker.Models;
using System.Runtime.InteropServices;

namespace Squawker.Services;

public class IvaoApiService
{
    // For production
    // private readonly string BaseUrl = "https://api.ivao.aero/v2/tracker/whazzup";

    // For local development; Change the path accordingly to your own whazzup.json file location
    private readonly string BaseUrl = "C:\\Users\\nc-mi\\Downloads\\whazzup.json";

    public Whazzup Data { get; private set; }

    private static readonly Random random = new Random();

    public void SetCurrentData()
    {
        
    }

    public string GetNewSquawk()
    {
        string[] reservedCodes = { "7500", "7600", "7700", "2000" }; // Notfallcodes
        string squawkCode;

        do
        {
            squawkCode = GenerateSquawk();
        }
        while (Array.Exists(reservedCodes, code => code == squawkCode) || IsSquawkAssignedToAircraft(squawkCode));

        return squawkCode;
    }

    /// <summary>
    /// Generates a valid squawk based on random data. Excludes default emergency and vfr squawk codes.
    /// </summary>
    /// <returns>The squawk as a string.</returns>
    private string GenerateSquawk()
    {
        char[] squawkCode = new char[4];

        // Jede Stelle des Codes wird zufällig zwischen 0 und 7 erzeugt
        for (int i = 0; i < 4; i++)
        {
            squawkCode[i] = random.Next(0, 8).ToString()[0]; // Zufällige Zahl zwischen 0 und 7
        }


        return new string(squawkCode);
    }

    private bool IsSquawkAssignedToAircraft(string squawk)
    {
        return false;

        // For now this feature going to be deactivated.
        // var existingSquawks = GetCurrentSquawksInUse();
        // return existingSquawks.Contains(squawk);
    }

    private HashSet<string> GetCurrentSquawksInUse()
    {
        HashSet<string> existingSquawks = new HashSet<string>();

        if (Data != null && Data.Clients != null)
        {
            Data.Clients.Pilots!.ForEach(pilot =>
            {
                if (pilot.LastTrack != null)
                {
                    existingSquawks.Add(pilot.LastTrack.Transponder.ToString());
                }
            });
        }

        return existingSquawks;
    }
}
