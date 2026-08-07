namespace Q47_MetroSmartCard;

public class MetroCardManager : IMetroOperations
{
    private Dictionary<int,Station>  stations       = new Dictionary<int,Station>();
    private Dictionary<int,Commuter> commuters = new Dictionary<int,Commuter>();
    private Dictionary<int,Journey>  activeJourneys = new Dictionary<int,Journey>();

    private Dictionary<int,LinkedList<double>>       fareHistories = new Dictionary<int,LinkedList<double>>();
    private Dictionary<int,Dictionary<long,double>>  dailyFares = new Dictionary<int,Dictionary<long,double>>();
    private Dictionary<int,Dictionary<string,int>>   routeFreq  = new Dictionary<int,Dictionary<string,int>>();

    private List<(long time,int card,int entrySt,int exitSt,double fare)> journeyLog
        = new List<(long,int,int,int,double)>();

    private double baseFare;
    private double perKmRate;
    private double maxDailyCap;

    public MetroCardManager(List<Station> stationList,double baseFare,double perKmRate,double maxDailyCap)
    {
        this.baseFare    = baseFare;
        this.perKmRate   = perKmRate;
        this.maxDailyCap = maxDailyCap;

        foreach(var s in stationList)
           stations[s.stationId] = s;
    }

    public void issueCard(int cardNumber,string commuterName,string commuterType)
    {
        if(commuters.ContainsKey(cardNumber)) return;

        commuters[cardNumber]     = new Commuter(cardNumber,commuterName,commuterType);
        fareHistories[cardNumber] = new LinkedList<double>();
        dailyFares[cardNumber]    = new Dictionary<long,double>();
        routeFreq[cardNumber]     = new Dictionary<string,int>();
    }

    public bool tapIn(int cardNumber,int stationId,long epochTime)
    {
        if(!commuters.ContainsKey(cardNumber))     return false;
        if(!stations.ContainsKey(stationId))       return false;
        if(activeJourneys.ContainsKey(cardNumber)) return false;

        activeJourneys[cardNumber] = new Journey(stationId,epochTime);
        commuters[cardNumber].travelSummary.lastEntryStation = stationId;
        commuters[cardNumber].travelSummary.lastEntryTime = epochTime;
        return true;
    }

    public bool tapOut(int cardNumber,int stationId,long epochTime)
    {
        if(!commuters.ContainsKey(cardNumber))      return false;
        if(!activeJourneys.ContainsKey(cardNumber)) return false;
        if(!stations.ContainsKey(stationId))        return false;

        var journey = activeJourneys[cardNumber];

        if(epochTime <= journey.entryTime)   return false;
        if(stationId == journey.entryStationId) return false;

        var entrySt = stations[journey.entryStationId];
        var exitSt  = stations[stationId];

        double dist = calculateDistance(entrySt,exitSt);
        double duration = (epochTime - journey.entryTime) / (1000.0*60);

        double fare;
        if(duration > 120)
            fare = baseFare*3;
        else
           fare = baseFare + (dist * perKmRate);

        fare = applyDiscount(fare,commuters[cardNumber].commuterType);

        long dateKey    = epochTime / 86400000L;
        double todayAmt = dailyFares[cardNumber].ContainsKey(dateKey) ? dailyFares[cardNumber][dateKey] : 0;

        if(todayAmt >= maxDailyCap)
            fare = 0;
        else if(todayAmt + fare > maxDailyCap)
            fare = maxDailyCap - todayAmt;

        if(!dailyFares[cardNumber].ContainsKey(dateKey))
           dailyFares[cardNumber][dateKey] = 0;
        dailyFares[cardNumber][dateKey] += fare;

        var ts = commuters[cardNumber].travelSummary;
        ts.lastExitStation   = stationId;
        ts.lastExitTime      = epochTime;
        ts.totalFarePaid    += fare;
        ts.totalTrips++;
        ts.averageFarePerTrip = ts.totalFarePaid / ts.totalTrips;

        var hist = fareHistories[cardNumber];
        hist.AddFirst(fare);
        if(hist.Count > 5) hist.RemoveLast();

        string routeKey = entrySt.stationName + " to " + exitSt.stationName;
        if(!routeFreq[cardNumber].ContainsKey(routeKey))
           routeFreq[cardNumber][routeKey] = 0;
        routeFreq[cardNumber][routeKey]++;

        journeyLog.Add((epochTime,cardNumber,journey.entryStationId,stationId,fare));
        activeJourneys.Remove(cardNumber);
        return true;
    }

    private double applyDiscount(double fare,string commuterType)
    {
        if(commuterType == "SENIOR")  return fare * 0.50;
        if(commuterType == "STUDENT") return fare * 0.75;
        if(commuterType == "CHILD")   return fare * 0.25;
        return fare;
    }

    private double calculateDistance(Station s1,Station s2)
    {
        double lat1 = toRad(s1.latitude);
        double lon1 = toRad(s1.longitude);
        double lat2 = toRad(s2.latitude);
        double lon2 = toRad(s2.longitude);

        double dlat = lat2 - lat1;
        double dlon = lon2 - lon1;

        double a = Math.Pow(Math.Sin(dlat/2),2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Pow(Math.Sin(dlon/2),2);

        double c = 2 * Math.Asin(Math.Sqrt(a));
        return 6371 * c;
    }

    private double toRad(double deg) => deg * Math.PI / 180.0;

    public Commuter getCommuterInfo(int cardNumber)
    {
        if(!commuters.ContainsKey(cardNumber)) return null!;
        return commuters[cardNumber];
    }

    public List<double> fareHistory(int cardNumber)
    {
        if(!fareHistories.ContainsKey(cardNumber)) return new List<double>();
        var list = new List<double>(fareHistories[cardNumber]);
        list.Sort((a,b) => b.CompareTo(a));
        return list;
    }

    public Dictionary<string,double> getZoneWiseRevenue(long startTime,long endTime)
    {
        var rev = new Dictionary<string,double>();

        foreach(var j in journeyLog)
        {
            if(j.time < startTime || j.time > endTime) continue;

            var en = stations[j.entrySt];
            var ex = stations[j.exitSt];

            int z1 = Math.Min(en.zone,ex.zone);
            int z2 = Math.Max(en.zone,ex.zone);

            string key = $"Zone{z1}-Zone{z2}";
            if(!rev.ContainsKey(key)) rev[key] = 0;
            rev[key] += j.fare;
        }

        return new Dictionary<string,double>(rev.OrderByDescending(x => x.Value));
    }

    public List<string> getFrequentRoute(int cardNumber)
    {
        if(!routeFreq.ContainsKey(cardNumber)) return new List<string>();

        return routeFreq[cardNumber]
               .OrderByDescending(x => x.Value)
               .Take(3)
               .Select(x => x.Key)
               .ToList();
    }

    public double getDailyPassSavings(int cardNumber,long date)
    {
        if(!dailyFares.ContainsKey(cardNumber)) return 0;

        string ds  = date.ToString();
        long dateKey;

        if(ds.Length == 8)
        {
            int yr  = int.Parse(ds.Substring(0,4));
            int mon = int.Parse(ds.Substring(4,2));
            int day = int.Parse(ds.Substring(6,2));
            var d   = new DateTime(yr,mon,day,0,0,0,DateTimeKind.Utc);
            dateKey = new DateTimeOffset(d).ToUnixTimeMilliseconds() / 86400000L;
        }
        else
        {
            dateKey = date / 86400000L;
        }

        if(!dailyFares[cardNumber].ContainsKey(dateKey)) return 0;

        double actualAmt = dailyFares[cardNumber][dateKey];
        double passCost  = maxDailyCap * 0.8;
        double savings   = actualAmt - passCost;

        return savings < 0 ? 0 : savings;
    }
}
