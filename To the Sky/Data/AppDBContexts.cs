using Microsoft.EntityFrameworkCore;
using To_the_Sky.Models;

namespace To_the_Sky.Data;

public class AppDBContexts : DbContext
{
    public AppDBContexts(DbContextOptions<AppDBContexts> options) : 
        base(options)
    {
        
        
    }
    public DbSet<AircraftModel> Aircraft => Set<AircraftModel>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AircraftModel>().HasData(
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
                OperationalHistory = "Entered service in 2005 and has remained a cornerstone of U.S. air superiority. And has remained in service until the 2030s",
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
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Concorde_1_94-9-5_kix_(cropped).jpg/3840px-Concorde_1_94-9-5_kix_(cropped).jpg",
                History = "A joint UK-French program that became the most famous supersonic transport aircraft.",
                Development = "Designed to carry passengers at Mach 2 while maintaining transatlantic range.",
                Specifications = "Delta-wing supersonic airliner with four turbojet engines and 100-passenger capacity.",
                Operators = "British Airways and Air France",
                OperationalHistory = "Entered commercial service in 1976 and retired in 2003.",
                ImageUrlMore = "https://www.wanderlustmagazine.com/wp-content/uploads/2025/02/Overture-4-scaled.jpg"
            },
            
            new AircraftModel()
            {
                Id = 3,
                Name = "Boeing 747",
                Manufacturer = "Boeing",
                Category = "Passenger",
                Country = "USA",
                FirstFlight = "1969",
                LastFlight = "Active",
                Description = "A wide-body commercial airliner known as the 'Queen of the Skies'.",
                DetailedDescription = "The Boeing 747 revolutionized air travel with its size, range, and passenger capacity.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/B-747_Iberia.jpg/1280px-B-747_Iberia.jpg",
                History = "Introduced in 1970, it became an iconic symbol of long-haul air travel.",
                Development = "Developed to meet the growing demand for international air travel and cargo transport.",
                Specifications = "Four-engine wide-body aircraft with a distinctive hump and seating for over 400 passengers.",
                Operators = "Various airlines worldwide",
                OperationalHistory = "Has been in continuous service since its introduction, with multiple variants developed over the years.",
                ImageUrlMore = "https://www.flightworx.aero/wp-content/uploads/2022/11/ba747mattcarter-copy.jpg"
            });
    }
}