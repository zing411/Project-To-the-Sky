# To the Sky

To the Sky is an ASP.NET Core MVC website about aircraft. It shows a gallery of aircraft loaded from a SQLite database, includes detailed aircraft pages, and has static pages like Home, About, and Privacy.

## Tech Stack

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core + SQLite
- Razor Views
- Bootstrap + custom CSS
- Vanilla JavaScript (gallery country filter)

## Project Structure

To the Sky/
├── Controllers/
│   ├── AircraftController.cs   # Gallery + detail + basic add/update endpoints
│   ├── HomeController.cs       # Home + Privacy
│   └── AboutController.cs      # About
├── Data/
│   └── AppDBContexts.cs        # EF Core DbContext + seeded aircraft data
├── Models/
│   └── AircraftModel.cs        # Aircraft data model
├── Views/
│   ├── Gallery/                # Gallery and detailed aircraft pages
│   ├── Home/                   # Home and Privacy pages
│   ├── About/                  # About page
│   └── Shared/_Layout.cshtml   # Shared site layout and nav
├── wwwroot/
│   ├── css/site.css            # Styling
│   ├── js/site.js              # Country filter logic for aircraft gallery
│   └── Images/                 # Local images
├── Program.cs                  # App startup, services, middleware, routes
└── appsettings.json            # Connection string for SQLite


## How it Works

Press the green arrow button at the top of the screen. If not, type in the console "dotnet build"
The AppDBContexts is the seed aircraft data, and creates a SQLITE Database and that information is displayed within the website's gallery 

## Requirements

Requires a SDK of 10 of ASP.NET 