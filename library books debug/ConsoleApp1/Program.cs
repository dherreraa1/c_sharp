using System;

class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true)
        {
            Console.WriteLine("\nWould you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine()?.Trim().ToLower(); // Normalize input

            if (action == "add")
            {
                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(newBook))
                {
                    Console.WriteLine("Book title cannot be empty.");
                    continue;
                }

                if (string.IsNullOrEmpty(book1))
                    book1 = newBook;
                else if (string.IsNullOrEmpty(book2))
                    book2 = newBook;
                else if (string.IsNullOrEmpty(book3))
                    book3 = newBook;
                else if (string.IsNullOrEmpty(book4))
                    book4 = newBook;
                else if (string.IsNullOrEmpty(book5))
                    book5 = newBook;
                else
                    Console.WriteLine("The library is full. No more books can be added.");
            }
            else if (action == "remove")
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(removeBook))
                {
                    Console.WriteLine("Book title cannot be empty.");
                    continue;
                }

                if (string.Equals(removeBook, book1, StringComparison.OrdinalIgnoreCase))
                    book1 = "";
                else if (string.Equals(removeBook, book2, StringComparison.OrdinalIgnoreCase))
                    book2 = "";
                else if (string.Equals(removeBook, book3, StringComparison.OrdinalIgnoreCase))
                    book3 = "";
                else if (string.Equals(removeBook, book4, StringComparison.OrdinalIgnoreCase))
                    book4 = "";
                else if (string.Equals(removeBook, book5, StringComparison.OrdinalIgnoreCase))
                    book5 = "";
                else
                    Console.WriteLine("Book not found.");
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
                continue;
            }

            // Display available books, filtering out empty slots
            Console.WriteLine("\nAvailable books:");
            string[] books = { book1, book2, book3, book4, book5 };
            bool hasBooks = false;

            foreach (string book in books)
            {
                if (!string.IsNullOrEmpty(book))
                {
                    Console.WriteLine("- " + book);
                    hasBooks = true;
                }
            }

            if (!hasBooks)
            {
                Console.WriteLine("No books in the library.");
            }
        }
    }
}
