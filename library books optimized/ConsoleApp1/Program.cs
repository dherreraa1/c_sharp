using System;
using System.Collections.Generic;

class LibraryManager
{
    static void Main()
    {
        List<string> books = new List<string>();
        const int maxBooks = 5;

        while (true)
        {
            Console.WriteLine("\nWould you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine()?.Trim().ToLower();

            if (action == "add")
            {
                if (books.Count >= maxBooks)
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                    continue;
                }

                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(newBook) && !books.Contains(newBook, StringComparer.OrdinalIgnoreCase))
                {
                    books.Add(newBook);
                    Console.WriteLine($"'{newBook}' has been added.");
                }
                else
                {
                    Console.WriteLine("Invalid or duplicate book title.");
                }
            }
            else if (action == "remove")
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                    continue;
                }

                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine()?.Trim();

                if (books.RemoveAll(b => b.Equals(removeBook, StringComparison.OrdinalIgnoreCase)) > 0)
                {
                    Console.WriteLine($"'{removeBook}' has been removed.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("\nAvailable books:");
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                books.ForEach(Console.WriteLine);
            }
        }
    }
}
