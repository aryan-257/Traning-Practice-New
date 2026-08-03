using System.Collections;

ArrayList numbers = new ArrayList();
bool running = true;

while(running)
{
    Console.WriteLine("\n1.Add  2.Remove  3.Display  4.Exit");
    Console.Write("Choice : ");
    string choice = Console.ReadLine()!;

    if(choice == "1")
    {
        Console.Write("Enter number : ");
        if(int.TryParse(Console.ReadLine() , out int num))
        {
            numbers.Add(num);
            Console.WriteLine(num + " added.");
        }
        else Console.WriteLine("Invalid number.");
    }
    else if(choice == "2")
    {
        Console.Write("Enter number to remove : ");
        if(int.TryParse(Console.ReadLine() , out int num))
        {
            if(numbers.Contains(num)) { numbers.Remove(num); Console.WriteLine(num + " removed."); }
            else Console.WriteLine("Number not found.");
        }
    }
    else if(choice == "3")
    {
        if(numbers.Count == 0) Console.WriteLine("List is empty.");
        else { Console.Write("Numbers : "); foreach(var n in numbers) Console.Write(n + " "); Console.WriteLine(); }
    }
    else if(choice == "4") running = false;
}
