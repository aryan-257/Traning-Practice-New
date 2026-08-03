LinkedList<string> students = new LinkedList<string>();
bool running = true;

while(running)
{
    Console.WriteLine("\n1.Add  2.Display  3.Update  4.Delete  5.Clear  6.Exit");
    Console.Write("Choice : ");
    string choice = Console.ReadLine()!;

    if(choice == "1")
    {
        Console.Write("Enter student name : ");
        string name = Console.ReadLine()!;
        students.AddLast(name);
        Console.WriteLine(name + " added.");
    }
    else if(choice == "2")
    {
        if(students.Count == 0) { Console.WriteLine("List empty."); continue; }
        Console.Write("Students : ");
        foreach(var s in students) Console.Write(s + "  ");
        Console.WriteLine();
    }
    else if(choice == "3")
    {
        Console.Write("Old name : "); string old = Console.ReadLine()!;
        Console.Write("New name : "); string newName = Console.ReadLine()!;
        var node = students.Find(old);
        if(node == null) { Console.WriteLine("Not found."); continue; }
        node.Value = newName;
        Console.WriteLine("Updated.");
    }
    else if(choice == "4")
    {
        Console.Write("Name to delete : "); string name = Console.ReadLine()!;
        if(students.Remove(name)) Console.WriteLine("Deleted.");
        else Console.WriteLine("Not found.");
    }
    else if(choice == "5")
    {
        students.Clear();
        Console.WriteLine("List cleared.");
    }
    else if(choice == "6") running = false;
}
