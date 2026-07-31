namespace Q17_LibraryManagement;

public class UserMenu
{
    private Library library;

    public UserMenu(Library library)
    {
        this.library = library;
    }

    public void HandleChoice(string choice)
    {
        if (choice == "5")
        {
            Console.Write("Search by name: ");
            library.SearchByName(Console.ReadLine()!);
        }
        else if (choice == "6")
        {
            Console.Write("Search by publisher: ");
            library.SearchByPublisher(Console.ReadLine()!);
        }
        else if (choice == "7")
        {
            library.ViewHighestPricedBook();
        }
        else if (choice == "8")
        {
            library.ViewLowestPricedBook();
        }
    }
}
