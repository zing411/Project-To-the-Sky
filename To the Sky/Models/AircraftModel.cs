namespace To_the_Sky.Models;

public class AircraftModel
{
    
    // ID of the aircraft
    public int Id { get; set; }
    
    // Name of the aircraft
    public string Name { get; set; }
    
    // Manufacturer of the aircraft
    public string Manufacturer { get; set; }
    
    // the country of origin 
    public string Country { get; set; }
    
    // first flight
    public string FirstFlightNumber { get; set; }
    
    // last flight if applicable  
    public string LastFlightNumber { get; set; }
    
    // description of the aircraft
    public string Description { get; set; }
    
    // image of aircraft
    public string ImageUrl { get; set; }
    
}