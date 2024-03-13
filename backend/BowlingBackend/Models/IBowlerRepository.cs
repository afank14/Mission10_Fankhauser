namespace BowlingBackend.Models
{
    // Make the interface for repo pattern
    public interface IBowlerRepository
    {
        // The class will have the following things:

        // Enumerable of type Bowler
        IEnumerable<Bowler> Bowlers { get; }

        // Enumerable of type Team
        IEnumerable<Team> Teams { get; }

        // a method returning an enumerable of type Bowler
        public IEnumerable<Bowler> GetBowlersWithTeams();
    }
}
