using OOP6_HotelManagement;

Hotel hotel = new Hotel("Grand Taj");
hotel.AddRoom(new Room(101,"Single",1000));
hotel.AddRoom(new Room(102,"Single",1000));
hotel.AddRoom(new Room(201,"Double",2000));
hotel.AddRoom(new Room(202,"Double",2000));
hotel.AddRoom(new Room(301,"Suite",5000));

var today = new DateTime(2026,7,31);
hotel.AddBooking(new Booking("Aryan", hotel.rooms[0], today, false));
hotel.AddBooking(new Booking("Rahul", hotel.rooms[2], today, true));
hotel.AddBooking(new Booking("Priya", hotel.rooms[4], today, false));

Console.WriteLine("Total revenue for today : Rs." + hotel.TotalRevenueForDay(today));

Console.WriteLine("\nVacant rooms by type :");
foreach(var entry in hotel.VacantRoomsByType())
    Console.WriteLine(" - " + entry.Key + " : " + entry.Value + " rooms");

Console.WriteLine("\nCustomers in room 101 :");
foreach(var b in hotel.GetCustomersByRoom(101))
    Console.WriteLine(" - " + b.customerName + " Advanced: " + b.isAdvanced);
