namespace OOP8_CricketTournament;

public class Tournament
{
    public List<Team> teams = new List<Team>();
    public List<Fixture> fixtures = new List<Fixture>();

    public void AddTeam(Team t) { teams.Add(t); }
    public void AddFixture(Fixture f) { fixtures.Add(f); }

    public int TotalTeams() { return teams.Count; }

    public List<Fixture> GetFixturesByTeam(string teamName)
    {
        List<Fixture> res = new List<Fixture>();
        foreach(var f in fixtures)
        {
            if(f.team1.teamName.ToLower() == teamName.ToLower() || f.team2.teamName.ToLower() == teamName.ToLower())
                res.Add(f);
        }
        return res;
    }

    public List<Player> GetPlayersByTeam(string teamName)
    {
        foreach(var t in teams)
        {
            if(t.teamName.ToLower() == teamName.ToLower())
                return t.players;
        }
        return new List<Player>();
    }
}
