namespace OOP6_HotelManagement;

public class Booking
{
    public string customerName;
    public Room room;
    public DateTime bookingDate;
    public bool isAdvanced;
    public double amountPaid;

    public Booking(string cname , Room r , DateTime date , bool advanced)
    {
        customerName = cname;
        room = r;
        bookingDate = date;
        isAdvanced = advanced;
        amountPaid = advanced ? r.basePrice * 0.9 : r.basePrice;
        r.isOccupied = true;
    }
}
