
using Microsoft.EntityFrameworkCore;

namespace BowlingBackend.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;

        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<Bowler> GetBowlersWithTeams()
        {
            return _context.Bowlers.Include(s => s.Team);
        }
    }
}
