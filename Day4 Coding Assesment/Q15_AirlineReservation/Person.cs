namespace Q15_AirlineReservation;

public abstract class Person
{
    public string name;
    public string passportNo;

    public Person(string n , string passport)
    {
        name = n; passportNo = passport;
    }
}
