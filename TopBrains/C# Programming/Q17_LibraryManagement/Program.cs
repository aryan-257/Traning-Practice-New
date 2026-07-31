using Q17_LibraryManagement;

var library = new Library();
var adminMenu = new AdminMenu(library);
var userMenu = new UserMenu(library);

bool running = true;

while (running)
{
    Console.WriteLine("\n--- Library Menu ---");
    Console.WriteLine("1. Add Book");
    Console.WriteLine("2. Update Book");
    Console.WriteLine("3. Delete Book");
    Console.WriteLine("4. View All Books");
    Console.WriteLine("5. Search by Name");
    Console.WriteLine("6. Search by Publisher");
    Console.WriteLine("7. Highest Priced Book");
    Console.WriteLine("8. Lowest Priced Book");
    Console.WriteLine("9. Exit");
    Console.Write("Choice: ");

    string choice = Console.ReadLine()!;

    if (choice == "9")
        running = false;
    else if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
        adminMenu.HandleChoice(choice);
    else
        userMenu.HandleChoice(choice);
}
