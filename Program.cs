using System;

class LibraryBooks
{
    private string name, code;

    public LibraryBooks(string name, string code)
    {
        this.name = name;
        this.code = code;
    }

    public string Name
    {
        get { return name; }
    }

    public string Code
    {
        get { return code; }
    }
}

class GetBooks
{
    static void Main()
    {
        int totalBooks;
        Console.Write("Enter the number of books to store: ");
        totalBooks = int.Parse(Console.ReadLine());

        LibraryBooks[] books = new LibraryBooks[totalBooks];

        for (int i = 0; i < books.Length; i++)
        {
            Console.Write($"Enter name for book {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter code for book {i + 1}: ");
            string code = Console.ReadLine();

            books[i] = new LibraryBooks(name, code);
        }

        Console.WriteLine("\nBooks in the Library:");
        Console.WriteLine("-----------------------");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: Code = {books[i].Code}, Name = {books[i].Name}");
        }
    }
}
