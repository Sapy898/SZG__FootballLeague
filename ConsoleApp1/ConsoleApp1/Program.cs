namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            League league = new League("Premier League");
            Team team1 = new Team("Manchester United");
            Team team2 = new Team("Liverpool");
            Team team3 = new Team("New Castle");
            
            league.AddTeam(team1);
            league.AddTeam(team2);
            league.AddTeam(team3);

            league.AddMatch(team1, team2);
            league.AddMatch(team2, team3);
            league.AddMatch(team3, team1);
            league.AddMatch(team1, team1);

            Match match1 = league.Matches[0];
            Match match2 = league.Matches[1];
            Console.WriteLine(match1.Play(2, 1)); 
            Console.WriteLine(match2.Play(0,3));
            Console.WriteLine(match1.Play(2,2));
            
            Console.WriteLine($"nem játszott csapatok: {league.UnplayedCount()}");

            Console.WriteLine($"Első meccs: {match1.Describe()}");
            Console.WriteLine($"Második meccs: {match2.Describe()}");
            Console.WriteLine($"Harmadik meccs: {match1.Describe()}");

            Console.WriteLine(team1.Describe()); 
            Console.WriteLine(team2.Describe());
            Console.WriteLine(team3.Describe());

            Console.WriteLine($"A tabella tetején lévő csapat: {league.Leader().Describe()}");

        }
    }
}
