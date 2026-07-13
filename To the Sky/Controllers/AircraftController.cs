using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using To_the_Sky.Data;
using To_the_Sky.Models;

namespace To_the_Sky.Controllers;

public class AircraftController : Controller
{
    private readonly AppDBContexts _context;

    public AircraftController(AppDBContexts context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var aircraft = await _context.Aircraft.ToListAsync();
        return View("~/Views/Gallery/Index.cshtml", aircraft);
    }
    

    public async Task<IActionResult> Detailed(int id)
    {
        var aircraft = await _context.Aircraft
            .FirstOrDefaultAsync(a => a.Id == id);

        if (aircraft == null)
        {
            return NotFound();
        }

        return View("~/Views/Gallery/Detailed.cshtml", aircraft);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] AircraftModel model)
    {
        _context.Aircraft.Add(model);
        await _context.SaveChangesAsync();
        return Ok(model);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] AircraftModel updated)
    {
        var aircraft = await _context.Aircraft.FindAsync(id);
        if (aircraft == null) return NotFound();
        
        aircraft.Name = updated.Name;
        aircraft.Manufacturer = updated.Manufacturer;
        aircraft.Category = updated.Category;
        aircraft.Country = updated.Country;
        aircraft.FirstFlight = updated.FirstFlight;
        aircraft.LastFlight = updated.LastFlight;
        aircraft.Description = updated.Description;
        aircraft.DetailedDescription = updated.DetailedDescription;
        aircraft.ImageUrl = updated.ImageUrl;
        aircraft.History = updated.History;
        aircraft.Development = updated.Development;
        aircraft.Specifications = updated.Specifications;
        aircraft.Operators = updated.Operators;
        aircraft.OperationalHistory = updated.OperationalHistory;   
        aircraft.ImageUrlMore = updated.ImageUrlMore;
        
        await _context.SaveChangesAsync();
        return Ok(aircraft);
    }
}