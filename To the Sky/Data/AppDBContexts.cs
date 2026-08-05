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



    // This is the creation of the database and how to enter the data into it.
    // All about aircraft
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
                DetailedDescription =
                    "The F-22 was designed for air superiority, with stealth, supercruise, and advanced avionics.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e2/F-22_Raptor_edit1.jpg",
                History = "Developed in the 1990s as the Air Force's next-generation air dominance fighter.",
                Development =
                    "Built under the Advanced Tactical Fighter program and optimized for stealth and agility.",
                Specifications =
                    "Twin-engine stealth fighter with high speed, advanced sensors, and long-range capability.",
                Operators = "United States Air Force",
                OperationalHistory =
                    "Entered service in 2005 and has remained a cornerstone of U.S. air superiority. And has remained in service until the 2030s",
                ImageUrlMore =
                    "https://www.lockheedmartin.com/content/dam/lockheed-martin/aero/photo/f22/F-22-1.jpg.pc-adaptive.full.medium.jpg"
            },

            new AircraftModel
            {
                Id = 2,
                Name = "Concorde",
                Manufacturer = "BAC (British Aircraft cooperation)/Aérospatiale",
                Category = "Passenger",
                Country = "UK/France",
                FirstFlight = "1969",
                LastFlight = "2003",
                Description = "A supersonic passenger airliner known for crossing the Atlantic in under 4 hours.",
                DetailedDescription =
                    "Concorde was a supersonic airliner that combined speed, luxury, and aerodynamic design.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Concorde_1_94-9-5_kix_(cropped).jpg/3840px-Concorde_1_94-9-5_kix_(cropped).jpg",
                History = "A joint UK-French program that became the most famous supersonic transport aircraft.",
                Development = "Designed to carry passengers at Mach 2 while maintaining transatlantic range.",
                Specifications =
                    "Delta-wing supersonic airliner with four turbojet engines and 100-passenger capacity.",
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
                DetailedDescription =
                    "The Boeing 747 revolutionized air travel with its size, range, and passenger capacity.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/B-747_Iberia.jpg/1280px-B-747_Iberia.jpg",
                History = "Introduced in 1970, it became an iconic symbol of long-haul air travel.",
                Development = "Developed to meet the growing demand for international air travel and cargo transport.",
                Specifications =
                    "Four-engine wide-body aircraft with a distinctive hump and seating for over 400 passengers.",
                Operators = "Various airlines worldwide",
                OperationalHistory =
                    "Has been in continuous service since its introduction, with multiple variants developed over the years.",
                ImageUrlMore = "https://www.flightworx.aero/wp-content/uploads/2022/11/ba747mattcarter-copy.jpg"
            },

            new AircraftModel()
            {
                Id = 4,
                Name = "Tu-160 Blackjack",
                Manufacturer = "Tupolev",
                Category = "Bomber",
                Country = "Russia",
                FirstFlight = "1981",
                LastFlight = "Active",
                Description =
                    "A supersonic strategic bomber and the largest and heaviest combat aircraft in the world.",
                DetailedDescription =
                    "The Tu-160 is a variable-sweep wing heavy bomber capable of carrying nuclear and conventional weapons.",
                ImageUrl = "https://aerocorner.com/wp-content/uploads/2021/07/Tupolev-Tu-160-Blackjack-1-scaled.jpg",
                History =
                    "Developed during the Cold War to replace the Tu-95, it remains a key component of Russia's strategic bomber fleet.",
                Development =
                    "Designed for long-range missions with high speed and payload capacity, featuring variable-sweep wings for versatility.",
                Specifications =
                    "Twin-engine supersonic bomber with a maximum speed of Mach 2.05 and a range of over 7,000 km.",
                Operators = "Russian Aerospace Forces",
                OperationalHistory =
                    "Entered service in 1987 and has been modernized over the years to maintain its strategic capabilities.",
                ImageUrlMore =
                    "https://ml5psubhxdln.i.optimole.com/cb:78--.b845/w:1667/h:1080/q:96/f:best/https://migflug.com/wp-content/uploads/2026/07/tupolev-tu-160-blackjack-formation-flight.jpg"
            },

            new AircraftModel()
            {
                Id = 5,
                Name = "J-20 Might Dragon",
                Manufacturer = "Chengdu Aircraft Corporation",
                Category = "Fighter",
                Country = "China",
                FirstFlight = "2011",
                LastFlight = "Active",
                Description =
                    "A twin-engine fifth generation stealth fighter, first fifth generation aircraft for the People's Liberation Army Air Force.",
                DetailedDescription =
                    "The J-20 is designed for long-range air superiority and precision strike missions, featuring stealth technology and advanced avionics.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/7/73/J-20_at_CCAS2022_%2820220827103424%29.jpg",
                History =
                    "Developed by the Chengdu Aircraft Corporation, the J-20 is a key component of China's modern air force.",
                Development =
                    "Designed to meet the needs of a modern air force, the J-20 features advanced stealth technology and avionics.",
                Specifications =
                    "Twin-engine fifth generation stealth fighter with a maximum speed of Mach 2.0 and a range of over 3,000 km.",
                Operators = "People's Liberation Army Air Force",
                OperationalHistory = "Entered service in 2011 and has been used in various operations since then.",
                ImageUrlMore =
                    "https://static0.simpleflyingimages.com/wordpress/wp-content/uploads/2024/06/shutterstock_2347911499-16x9-cropped.jpg?q=49&fit=contain&w=750&h=422&dpr=2"
            },

            new AircraftModel()
            {
                Id = 6,
                Name = "Dassault Rafale",
                Manufacturer = "Dassault Aviation",
                Category = "Multirole Fighter",
                Country = "France",
                FirstFlight = "1986 ",
                LastFlight = "Active",
                Description =
                    "A French multirole fighter aircraft, the Rafale is known for its versatility and advanced avionics.",
                DetailedDescription =
                    "The Dassault Rafale is a twin-engine, canard configuration, multirole fighter designed and built by Dassault Aviation.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Rafale_-_RIAT_2009_%283751416421%29.jpg/1920px-Rafale_-_RIAT_2009_%283751416421%29.jpg",
                History = "The Rafale was developed in the 1980s as a replacement for the Mirage 2000.",
                Development =
                    "Designed to meet the needs of a modern air force, the Rafale features advanced avionics and a wide range of mission capabilities.",
                Specifications =
                    "Twin-engine multirole fighter with a maximum speed of Mach 2.0 and a range of over 3,000 km.",
                Operators = "French Air Force and Space Force, French Navy, Egyptian Air Force, Indian Air Force",
                OperationalHistory = "Entered service in 1986 and has been used in various operations since then.",
                ImageUrlMore =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Rafale_TNI_AU_over_the_country_%28T-0317_%26_T-0303%29%2C_2026.jpg/1920px-Rafale_TNI_AU_over_the_country_%28T-0317_%26_T-0303%29%2C_2026.jpg"
            },

            new AircraftModel()
            {
                Id = 7,
                Name = "Airbus A400M Atlas",
                Manufacturer = "Airbus Defence and Space",
                Category = "Strategic/tactical airlift",
                Country = "Germany",
                FirstFlight = "2009",
                LastFlight = "Active",
                Description = "A European Multirole Strategic/tactical airlift turboprop military transport aircraft.",
                DetailedDescription =
                    "The Airbus A400M Atlas is a European four-engine turboprop military transport aircraft. It was designed by Airbus Defence and Space, as a tactical airlifter with strategic capabilities.",
                ImageUrl =
                    "https://upload.wikimedia.org/wikipedia/commons/3/31/German_Air_Force_Airbus_A400M_(out_cropped).jpg",
                History =
                    "The A400M Atlas was developed in the late 1980s to replace older transport aircraft such as the Transall C-160 and the Lockheed C-130 Hercules.",
                Development =
                    "A joint venture of between European aeronautic firms to meet the needs of variety of tactical and strategic operations.",
                Specifications =
                    "Four-engine turboprop transport aircraft with a max speed of Mach 0.72, max cargo capacity of 37 tonnes and range between 3,300-6,400 km depending on the payload.",
                Operators =
                    "Primarily German Air Force, French Air and Space Force, Royal Air Force, Spanish Air and Space Force",
                OperationalHistory = "Entered service in 2013, used ever since in European military operations.",
                ImageUrlMore =
                    "https://upload.wikimedia.org/wikipedia/commons/5/58/A400_-_Tag_der_Bundeswehr_2026_1.jpg"
            },
            new AircraftModel()
            {
                Id = 8,
                Name = "UH-60 Black Hawk",
                Manufacturer = "Sikorsky Aircraft",
                Category = "Utility helicopter",
                Country = "United States",
                FirstFlight = "1974",
                LastFlight = "Active",
                Description = "A four-blade, twin-engine, medium-lift utility helicopter.",
                DetailedDescription =
                    "The UH-60 Black Hawk is a four-blade, twin-engine, medium-lift utility helicopter manufactured by Sikorsky Aircraft. It is used primarily by the United States Army.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/National-Guard-UH-60-Black-Hawk-operations-at-Fort-McCoy.jpg/1280px-National-Guard-UH-60-Black-Hawk-operations-at-Fort-McCoy.jpg?utm_source=en.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail",
                History = "The Black Hawk was developed in the 1970s to replace the UH-1 Iroquois.",
                Development = "Developed by Sikorsky Aircraft for the United States Army.",
                Specifications =
                    "Four-blade, twin-engine utility helicopter with a max speed of 183 mph, range of 1,381 miles, and service ceiling of 19,000 feet.",
                Operators = "Primarily United States Army, also used by various other countries",
                OperationalHistory =
                    "Entered service in 1979 and has been used in various military operations since then.",
                ImageUrlMore = "https://i0.wp.com/unitedaerogroup.com/wp-content/uploads/2024/04/iStock-855861034.jpg?fit=724%2C483&ssl=1"
            });
    }
}