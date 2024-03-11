namespace BowlingBackend.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        public IEnumerable<Bowler> GetBowlersWithTeams();
    }
}
