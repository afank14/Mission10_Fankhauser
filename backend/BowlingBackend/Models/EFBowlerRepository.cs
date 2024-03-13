
using Microsoft.EntityFrameworkCore;

namespace BowlingBackend.Models
{
    // Make an EF Repo class that inherits from the interface
    public class EFBowlerRepository : IBowlerRepository
    {
        // create a private instance of the database from the context file
        private BowlingLeagueContext _context;

        // populate the private instance in the constructor
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        
        // Create the bowlers table in the instance
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        
        // Create the teams table in the instance
        public IEnumerable<Team> Teams => _context.Teams;

        // Create a method that returns the bowlers with the teams
        public IEnumerable<Bowler> GetBowlersWithTeams()
        {
            return _context.Bowlers.Include(s => s.Team);
        }
    }
}
