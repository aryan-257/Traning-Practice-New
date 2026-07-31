namespace OOP6_HotelManagement;

public class Hotel
{
    public string hotelName;
    public List<Room> rooms = new List<Room>();
    public List<Booking> bookings = new List<Booking>();

    public Hotel(string name)
    {
        hotelName = name;
    }

    public void AddRoom(Room r) { rooms.Add(r); }

    public void AddBooking(Booking b) { bookings.Add(b); }

    public double TotalRevenueForDay(DateTime date)
    {
        double total = 0;
        foreach(var b in bookings)
        {
            if(b.bookingDate.Date == date.Date)
                total += b.amountPaid;
        }
        return total;
    }

    public Dictionary<string,int> VacantRoomsByType()
    {
        Dictionary<string,int> res = new Dictionary<string,int>();
        foreach(var r in rooms)
        {
            if(!r.isOccupied)
            {
                if(!res.ContainsKey(r.roomType))
                    res[r.roomType] = 0;
                res[r.roomType]++;
            }
        }
        return res;
    }

    public List<Booking> GetCustomersByRoom(int roomNo)
    {
        List<Booking> res = new List<Booking>();
        foreach(var b in bookings)
        {
            if(b.room.roomNo == roomNo)
                res.Add(b);
        }
        return res;
    }
}
