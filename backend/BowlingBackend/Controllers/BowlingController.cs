using BowlingBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlingController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.GetBowlersWithTeams()
                                  .Where(b => b.Team != null &&
                                                  (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                                  .ToArray();


            return bowlerData;
        }
    }
}
