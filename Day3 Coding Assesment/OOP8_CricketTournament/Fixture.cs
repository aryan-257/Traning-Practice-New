namespace OOP8_CricketTournament;

public class Fixture
{
    public Team team1;
    public Team team2;
    public DateTime matchDate;
    public string venue;

    public Fixture(Team t1 , Team t2 , DateTime date , string ven)
    {
        team1 = t1;
        team2 = t2;
        matchDate = date;
        venue = ven;
    }
}
