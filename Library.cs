public class Library
{
    public List<Book> Books { get; set; }

// Methods
    /// Adds a book to the library.
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        // Implementation here
    }

    /// Removes a book from the library based on its ISBN.
    /// <param name="isbn">The ISBN of the book to remove.</param>
    public void RemoveBook(string isbn)
    {
        // Implementation here
    }

    /// Searches for books in the library that match the given query.
    /// <param name="query">The search query.</param>
    /// <returns>A list of books that match the search query.</returns>
    public List<Book> SearchBooks(string query)
    {
        // Implementation here
    }

    /// Lists all books in the library, sorted by a certain criterion (e.g. title).
    public void ListBooks()
    {
        // Implementation here
    }
}
