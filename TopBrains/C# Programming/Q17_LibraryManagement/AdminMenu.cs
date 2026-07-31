namespace Q17_LibraryManagement;

public class AdminMenu
{
    private Library library;

    public AdminMenu(Library library)
    {
        this.library = library;
    }

    public void HandleChoice(string choice)
    {
        if (choice == "1")
        {
            Console.Write("Title: "); string title = Console.ReadLine()!;
            Console.Write("Publisher: "); string publisher = Console.ReadLine()!;
            Console.Write("Price: "); double.TryParse(Console.ReadLine(), out double price);
            library.AddBook(title, publisher, price);
        }
        else if (choice == "2")
        {
            Console.Write("Book ID to update: "); int.TryParse(Console.ReadLine(), out int id);
            Console.Write("New Title: "); string title = Console.ReadLine()!;
            Console.Write("New Publisher: "); string publisher = Console.ReadLine()!;
            Console.Write("New Price: "); double.TryParse(Console.ReadLine(), out double price);
            library.UpdateBook(id, title, publisher, price);
        }
        else if (choice == "3")
        {
            Console.Write("Book ID to delete: "); int.TryParse(Console.ReadLine(), out int id);
            library.DeleteBook(id);
        }
        else if (choice == "4")
        {
            library.ViewAllBooks();
        }
    }
}
