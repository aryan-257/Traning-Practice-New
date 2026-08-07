namespace Q47_MetroSmartCard;

public class Station
{
    public int    stationId;
    public string stationName;
    public int    zone;
    public double latitude;
    public double longitude;

    public Station(int id,string name,int z,double lat,double lon)
    {
       stationId   = id;
       stationName = name;
       zone = z;
       latitude  = lat;
       longitude = lon;
    }
}
