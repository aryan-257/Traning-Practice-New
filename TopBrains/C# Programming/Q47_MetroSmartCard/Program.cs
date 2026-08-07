using Q47_MetroSmartCard;

string[] firstLine = Console.ReadLine()!.Split(' ');
int    numReq      = int.Parse(firstLine[0]);
double baseFare    = double.Parse(firstLine[1]);
double perKmRate   = double.Parse(firstLine[2]);
double maxCap      = double.Parse(firstLine[3]);

int numStations = int.Parse(Console.ReadLine()!.Trim());

var stList = new List<Station>();
for(int i=0;i<numStations;i++)
{
    string? line2 = Console.ReadLine();
    if(line2 == null) break;
    string[] p  = line2.Split(' ');
    int    id   = int.Parse(p[0]);
    string nm   = p[1];
    int    z    = int.Parse(p[2]);
    double lat  = double.Parse(p[3]);
    double lon  = double.Parse(p[4]);
    stList.Add(new Station(id,nm,z,lat,lon));
}

var mgr = new MetroCardManager(stList,baseFare,perKmRate,maxCap);

for(int i=0;i<numReq;i++)
{
    string? rawLine = Console.ReadLine();
    if(rawLine == null) break;
    string[]  tokens = rawLine.Trim().Split(' ');
    string    cmd    = tokens[0];

    if(cmd == "issueCard")
    {
        int    card = int.Parse(tokens[1]);
        string name = tokens[2].Replace("\"","");
        string type = tokens[3];
        mgr.issueCard(card,name,type);
    }
    else if(cmd == "tapIn")
    {
        int  card = int.Parse(tokens[1]);
        int  stId = int.Parse(tokens[2]);
        long t    = long.Parse(tokens[3]);
        Console.WriteLine(mgr.tapIn(card,stId,t).ToString().ToLower());
    }
    else if(cmd == "tapOut")
    {
        int  card = int.Parse(tokens[1]);
        int  stId = int.Parse(tokens[2]);
        long t    = long.Parse(tokens[3]);
        Console.WriteLine(mgr.tapOut(card,stId,t).ToString().ToLower());
    }
    else if(cmd == "commuterInfo")
    {
        int card = int.Parse(tokens[1]);
        Commuter c = mgr.getCommuterInfo(card);
        if(c == null) continue;
        var s = c.travelSummary;
        Console.WriteLine($"{c.cardNumber} {c.commuterName} {c.commuterType} {s.lastEntryStation} {s.lastExitStation} {s.lastEntryTime} {s.lastExitTime} {Math.Round(s.totalFarePaid,2)} {s.totalTrips} {Math.Round(s.averageFarePerTrip,2)}");
    }
    else if(cmd == "fareHistory")
    {
        int card = int.Parse(tokens[1]);
        foreach(var fare in mgr.fareHistory(card))
           Console.WriteLine(Math.Round(fare,2));
    }
    else if(cmd == "zoneRevenue")
    {
        long st  = long.Parse(tokens[1]);
        long end = long.Parse(tokens[2]);
        foreach(var kv in mgr.getZoneWiseRevenue(st,end))
           Console.WriteLine($"{kv.Key}:{Math.Round(kv.Value,2)}");
    }
    else if(cmd == "frequentRoute")
    {
        int card = int.Parse(tokens[1]);
        foreach(var r in mgr.getFrequentRoute(card))
           Console.WriteLine(r);
    }
    else if(cmd == "dailySavings")
    {
        int  card    = int.Parse(tokens[1]);
        long date    = long.Parse(tokens[2]);
        double savings = mgr.getDailyPassSavings(card,date);
        Console.WriteLine(Math.Round(savings,2));
    }
}
