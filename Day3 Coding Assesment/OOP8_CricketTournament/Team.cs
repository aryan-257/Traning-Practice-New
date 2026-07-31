namespace OOP8_CricketTournament;

public class Team
{
    public string teamName;
    public List<Player> players = new List<Player>();

    public Team(string name)
    {
        teamName = name;
    }

    public void AddPlayer(Player p)
    {
        players.Add(p);
    }
}
