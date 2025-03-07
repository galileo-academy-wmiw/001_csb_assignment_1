using System;
using System.Collections.Generic;
using System.Linq;
public class Library 
{
    public List<Book> Books { get; set; }

// Methods
    /// Adds a book to the library.
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        // Implementation here
        Books.Add(book);
        
    }

    /// Removes a book from the library based on its ISBN.
    /// <param name="isbn">The ISBN of the book to remove.</param>
    public void RemoveBook(string isbn)
    {
        // Implementation here

        var bookToRemove = Books.FirstOrDefault(book => book.ISBN == isbn);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
        }
        else
        {
            Console.WriteLine("Boek met ISBN {0} niet gevonden.", isbn);
        }
    }

    /// Searches for books in the library that match the given query.
    /// <param name="query">The search query.</param>
    /// <returns>A list of books that match the search query.</returns>
    public List<Book> SearchBooks(string query)
    {
        // Implementation here
        var searchResults = new List<Book>();
        foreach (var book in Books)
        {
            if (book.IsMatch(query))
            {
                searchResults.Add(book);
            }
        }

        if(searchResults.Count == 0)
        {
            Console.WriteLine("Geen boek komt overeen met de zoekterm.");
        }
        else
        {
            Console.WriteLine("Gevonden boeken:");
            foreach (var book in searchResults)
            {
                Console.WriteLine(book.Title);
            }
        }


    }

    /// Lists all books in the library, sorted by a certain criterion (e.g. title).
    public void ListBooks()
    {
        // Implementation here
        var sortedBooks = Books.OrderBy(book => book.Title);
        foreach (var book in sortedBooks)
        {
            Console.WriteLine(book.Title);
        }


    }


}
