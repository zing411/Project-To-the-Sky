using Microsoft.AspNetCore.Mvc;
using To_the_Sky.Models;

namespace To_the_Sky.Controllers;

// Temporary mock data until database integration is added.
public class AircraftController : Controller
{
    private static readonly List<AircraftModel> Aircraft =
    [
        new AircraftModel
        {
            Id = 1,
            Name = "F-22 Raptor",
            Manufacturer = "Lockheed Martin",
            Category = "Fighter",
            Country = "USA",
            FirstFlight = "1997",
            LastFlight = "Active",
            Description = "A fifth-generation stealth tactical fighter aircraft used by the U.S. Air Force.",
            DetailedDescription = "The F-22 was designed for air superiority, with stealth, supercruise, and advanced avionics.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e2/F-22_Raptor_edit1.jpg",
            History = "Developed in the 1990s as the Air Force's next-generation air dominance fighter.",
            Development = "Built under the Advanced Tactical Fighter program and optimized for stealth and agility.",
            Specifications = "Twin-engine stealth fighter with high speed, advanced sensors, and long-range capability.",
            Operators = "United States Air Force",
            OperationalHistory = "Entered service in 2005 and has remained a cornerstone of U.S. air superiority.",
            ImageUrlMore = "https://www.lockheedmartin.com/content/dam/lockheed-martin/aero/photo/f22/F-22-1.jpg.pc-adaptive.full.medium.jpg"
        },
        new AircraftModel
        {
            Id = 2,
            Name = "Concorde",
            Manufacturer = "Aero Spacelines/BAC",
            Category = "Passenger",
            Country = "UK/France",
            FirstFlight = "1969",
            LastFlight = "2003",
            Description = "A supersonic passenger airliner known for crossing the Atlantic in under 4 hours.",
            DetailedDescription = "Concorde was a supersonic airliner that combined speed, luxury, and aerodynamic design.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Concorde_1_94-9-5_kix_%28cropped%29.jpg/3840px-Concorde_1_94-9-5_kix_%28cropped%29.jpg",
            History = "A joint UK-French program that became the most famous supersonic transport aircraft.",
            Development = "Designed to carry passengers at Mach 2 while maintaining transatlantic range.",
            Specifications = "Delta-wing supersonic airliner with four turbojet engines and 100-passenger capacity.",
            Operators = "British Airways and Air France",
            OperationalHistory = "Entered commercial service in 1976 and retired in 2003.",
            ImageUrlMore = "https://www.wanderlustmagazine.com/wp-content/uploads/2025/02/Overture-4-scaled.jpg"
        }
    ];

    // Getting these models to the galley page 
    public IActionResult Index()
    {
        return View("~/Views/Gallery/Index.cshtml", Aircraft);
    }

    public IActionResult Detailed(int id)
    {
        var aircraft = Aircraft.Find(item => item.Id == id);

        if (aircraft == null)
        {
            return NotFound();
        }

        return View("~/Views/Gallery/Detailed.cshtml", aircraft);
    }
}
