namespace Q15_AirlineReservation;

public interface IBookable
{
    void Book(Passenger p);
}

public interface ICancelable
{
    void Cancel(string passportNo);
}
