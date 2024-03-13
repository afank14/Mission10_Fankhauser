using BowlingBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// Main controller for this project
namespace BowlingBackend.Controllers
{
    // the route will just be  the name of the controller "Bowling"
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        // Create an instance of the repository
        private IBowlerRepository _bowlerRepository;

        // instantiate the instance in the constructor
        public BowlingController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        // Make a get request for the API that returns an enumerable of type Bowler
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Data calls the GetBowlersWithTeams method (in the EFBowlerRepository file)
            // Then filters the data to bowlers with a team that is not null AND is either the Marlins or Sharks
            var bowlerData = _bowlerRepository.GetBowlersWithTeams()
                                  .Where(b => b.Team != null &&
                                                  (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                                  .ToArray();

            // Return the bowler data, which will display as a JSON
            return bowlerData;
        }
    }
}
