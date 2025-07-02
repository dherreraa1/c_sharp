using System;

class LibraryManager
{
    static void Main()
    {
        string[] books = new string[5]; // Array to store up to five book titles
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    AddBook(books);
                    break;
                case "2":
                    RemoveBook(books);
                    break;
                case "3":
                    DisplayBooks(books);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
    
    static void AddBook(string[] books)
    {
        Console.Write("Enter the title of the book to add: ");
        string newBook = Console.ReadLine();
        
        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
            {
                books[i] = newBook;
                Console.WriteLine("Book added successfully.");
                return;
            }
        }
        Console.WriteLine("Library is full! Cannot add more books.");
    }
    
    static void RemoveBook(string[] books)
    {
        Console.Write("Enter the title of the book to remove: ");
        string bookToRemove = Console.ReadLine();
        
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Equals(bookToRemove, StringComparison.OrdinalIgnoreCase))
            {
                books[i] = null;
                Console.WriteLine("Book removed successfully.");
                return;
            }
        }
        Console.WriteLine("Book not found in the library.");
    }
    
    static void DisplayBooks(string[] books)
    {
        Console.WriteLine("\nCurrent Books in Library:");
        bool isEmpty = true;
        
        foreach (var book in books)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine("- " + book);
                isEmpty = false;
            }
        }
        
        if (isEmpty)
            Console.WriteLine("No books in the library.");
    }
}
