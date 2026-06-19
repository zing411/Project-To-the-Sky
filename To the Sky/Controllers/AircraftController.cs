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
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e2/F-22_Raptor_edit1.jpg"
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
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Concorde_1_94-9-5_kix_%28cropped%29.jpg/3840px-Concorde_1_94-9-5_kix_%28cropped%29.jpg"
        }
    ];

    public IActionResult Index()
    {
        return View("~/Views/Gallery/Index.cshtml", Aircraft);
    }
}
