using System;
using System.Collections.Generic;

class LibraryManager
{
    static List<string> books = new List<string>(); // Library collection
    static List<string> borrowedBooks = new List<string>(); // Books borrowed by user
    const int maxBooksInLibrary = 5;
    const int maxBorrowedBooks = 3;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an action: add, remove, search, borrow, return, exit");
            string action = Console.ReadLine()?.Trim().ToLower();

            switch (action)
            {
                case "add":
                    AddBook();
                    break;
                case "remove":
                    RemoveBook();
                    break;
                case "search":
                    SearchBook();
                    break;
                case "borrow":
                    BorrowBook();
                    break;
                case "return":
                    ReturnBook();
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'borrow', 'return', or 'exit'.");
                    break;
            }

            DisplayBooks();
        }
    }

    static void AddBook()
    {
        if (books.Count >= maxBooksInLibrary)
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
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

    static void RemoveBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
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

    static void SearchBook()
    {
        Console.WriteLine("Enter the title of the book to search:");
        string searchBook = Console.ReadLine()?.Trim();

        if (books.Exists(b => b.Equals(searchBook, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"'{searchBook}' is available in the library.");
        }
        else
        {
            Console.WriteLine($"'{searchBook}' is not in the collection.");
        }
    }

    static void BorrowBook()
    {
        if (borrowedBooks.Count >= maxBorrowedBooks)
        {
            Console.WriteLine("You have reached the borrowing limit (3 books). Return a book before borrowing more.");
            return;
        }

        Console.WriteLine("Enter the title of the book to borrow:");
        string borrowBook = Console.ReadLine()?.Trim();

        if (books.RemoveAll(b => b.Equals(borrowBook, StringComparison.OrdinalIgnoreCase)) > 0)
        {
            borrowedBooks.Add(borrowBook);
            Console.WriteLine($"You have borrowed '{borrowBook}'.");
        }
        else
        {
            Console.WriteLine("Book not available or already borrowed.");
        }
    }

    static void ReturnBook()
    {
        if (borrowedBooks.Count == 0)
        {
            Console.WriteLine("You haven't borrowed any books.");
            return;
        }

        Console.WriteLine("Enter the title of the book to return:");
        string returnBook = Console.ReadLine()?.Trim();

        if (borrowedBooks.RemoveAll(b => b.Equals(returnBook, StringComparison.OrdinalIgnoreCase)) > 0)
        {
            books.Add(returnBook);
            Console.WriteLine($"'{returnBook}' has been returned to the library.");
        }
        else
        {
            Console.WriteLine("You haven't borrowed this book.");
        }
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nAvailable books in the library:");
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            books.ForEach(Console.WriteLine);
        }

        Console.WriteLine("\nBooks you have borrowed:");
        if (borrowedBooks.Count == 0)
        {
            Console.WriteLine("No books borrowed.");
        }
        else
        {
            borrowedBooks.ForEach(Console.WriteLine);
        }
    }
}
