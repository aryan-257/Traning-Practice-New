using OOP8_CricketTournament;

Tournament tournament = new Tournament();

var india = new Team("India");
india.AddPlayer(new Player("Rohit","Batsman"));
india.AddPlayer(new Player("Kohli","Batsman"));
india.AddPlayer(new Player("Bumrah","Bowler"));

var aus = new Team("Australia");
aus.AddPlayer(new Player("Warner","Batsman"));
aus.AddPlayer(new Player("Starc","Bowler"));
aus.AddPlayer(new Player("Smith","Batsman"));

var eng = new Team("England");
eng.AddPlayer(new Player("Root","Batsman"));
eng.AddPlayer(new Player("Anderson","Bowler"));

tournament.AddTeam(india);
tournament.AddTeam(aus);
tournament.AddTeam(eng);

tournament.AddFixture(new Fixture(india,aus,new DateTime(2026,8,1),"Mumbai"));
tournament.AddFixture(new Fixture(india,eng,new DateTime(2026,8,3),"Delhi"));
tournament.AddFixture(new Fixture(aus,eng,new DateTime(2026,8,5),"Chennai"));

Console.WriteLine("Total teams : " + tournament.TotalTeams());

Console.WriteLine("\nFixtures for India :");
foreach(var f in tournament.GetFixturesByTeam("India"))
    Console.WriteLine(" - " + f.team1.teamName + " vs " + f.team2.teamName + " on " + f.matchDate.ToShortDateString() + " at " + f.venue);

Console.WriteLine("\nPlayers of Australia :");
foreach(var p in tournament.GetPlayersByTeam("Australia"))
    Console.WriteLine(" - " + p.playerName + " [" + p.role + "]");
