using Q34_BikeRental;

var utility = new BikeUtility();
bool running = true;

while (running)
{
    Console.WriteLine("\n1. Add Bike Details");
    Console.WriteLine("2. Group Bikes By Brand");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine()!;

    if (choice == "1")
    {
        Console.Write("Enter the model: "); string model = Console.ReadLine()!;
        Console.Write("Enter the brand: "); string brand = Console.ReadLine()!;
        Console.Write("Enter the price per day: "); int.TryParse(Console.ReadLine(), out int price);
        utility.AddBikeDetails(model, brand, price);
    }
    else if (choice == "2")
    {
        var grouped = utility.GroupBikesByBrand();
        foreach (var entry in grouped)
        {
            foreach (var bike in entry.Value)
                Console.WriteLine($"{entry.Key} {bike.Model}");
        }
    }
    else if (choice == "3")
    {
        running = false;
    }
}
