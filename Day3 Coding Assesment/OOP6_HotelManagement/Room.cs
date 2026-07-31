namespace OOP6_HotelManagement;

public class Room
{
    public int roomNo;
    public string roomType;
    public double basePrice;
    public bool isOccupied;

    public Room(int no , string type , double price)
    {
        roomNo = no;
        roomType = type;
        basePrice = price;
        isOccupied = false;
    }
}
