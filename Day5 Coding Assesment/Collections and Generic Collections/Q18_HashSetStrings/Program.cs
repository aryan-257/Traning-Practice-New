HashSet<string> stringSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
bool running = true;

while(running)
{
    Console.WriteLine("\n1.Add  2.Remove  3.Search  4.Display  5.Exit");
    Console.Write("Choice : ");
    string choice = Console.ReadLine()!;

    if(choice == "1")
    {
        Console.Write("Enter string : ");
        string val = Console.ReadLine()!;
        if(stringSet.Add(val))
            Console.WriteLine("'" + val + "' added.");
        else
            Console.WriteLine("Duplicate! '" + val + "' already exists.");
    }
    else if(choice == "2")
    {
        Console.Write("Enter string to remove : ");
        string val = Console.ReadLine()!;
        if(stringSet.Remove(val)) Console.WriteLine("Removed.");
        else Console.WriteLine("Not found.");
    }
    else if(choice == "3")
    {
        Console.Write("Search : ");
        string val = Console.ReadLine()!;
        Console.WriteLine(stringSet.Contains(val) ? "Found!" : "Not found.");
    }
    else if(choice == "4")
    {
        if(stringSet.Count == 0) { Console.WriteLine("Set empty."); continue; }
        Console.Write("Items : ");
        foreach(var s in stringSet) Console.Write(s + "  ");
        Console.WriteLine();
    }
    else if(choice == "5") running = false;
}
