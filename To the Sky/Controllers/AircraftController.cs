using To_the_Sky.Models;

namespace To_the_Sky.Controllers;




public class AircraftController
{
    public IEnumerable<AircraftModel> AircraftList { get; set; }
    
}


// Getting the specific aircraft displayed
public class AircraftModel
{
    public string Id { get; set; }
}