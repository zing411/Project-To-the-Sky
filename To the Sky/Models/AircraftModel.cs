namespace To_the_Sky.Models;

public class AircraftModel
{
    
    // ID of the aircraft
    public int Id { get; set; }
    
    // Name of the aircraft
    public required string Name { get; set; }
    
    // Manufacturer of the aircraft
    public required string Manufacturer { get; set; }
    
    // Category of aircraft
    public required string Category { get; set; }
    
    // the country of origin 
    public required string Country { get; set; }
    
    // first flight
    public required string FirstFlight { get; set; }
    
    // last flight if applicable  
    public required string LastFlight { get; set; }
    
    // description of the aircraft
    public required string Description { get; set; }
    
    // more detailed description
    public required string DetailedDescription { get; set; }
    
    // image of aircraft
    public required string ImageUrl { get; set; }
    
    // history
    public required string History { get; set; }
    
    // development
    public required string Development { get; set; }
    
    // specifications
    public required string Specifications { get; set; }
    
    // Operators
    public required string Operators  { get; set; }
    
    // Combat history
    public required string OperationalHistory { get; set; }
    
    // gallery images 
    public required string ImageUrlMore { get; set; }
    
}