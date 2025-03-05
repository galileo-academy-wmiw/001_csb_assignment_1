/// <summary>
/// Represents a book with properties such as Title, Author, ISBN, PublicationYear, and Genre.
/// </summary>

// Implement the IReadable-interface in the Book - class: 
// Methoden: Read(): a method which can be implemented by the Book-class, to indicate the book is being read (e.g. "Reading [Booktitle]...").

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public string Genre { get; set; }

//Methods
    public void DisplayDetails()
    {
        // Method implementation goes here
        Console.WriteLine($"Title: {Title}" - $"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}" - $"ISBN: {ISBN}" - $"Publication Year: {PublicationYear}");
        
        


    }

    /// <param name="searchQuery">The search query to match against.</param>
    /// <returns><c>true</c> if the book matches the search query; otherwise, <c>false</c>.</returns>

    public bool IsMatch(string searchQuery)
    {
        // Method implementation goes here
    }
}

interface IReadable
{
    void Read();
}s