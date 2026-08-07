namespace Q47_MetroSmartCard;

public class Commuter
{
    public int    cardNumber;
    public string commuterName;
    public string commuterType;
    public TravelSummary travelSummary;

    public Commuter(int card,string name,string type)
    {
       cardNumber    = card;
       commuterName  = name;
       commuterType  = type;
       travelSummary = new TravelSummary();
    }
}
