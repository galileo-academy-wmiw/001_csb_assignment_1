public class eBook: Book, IReadable
{
    //public string Format { get; set; }
    public int FileSize { get; set; }
    //public string FilePath { get; set; }

public override void DisplayDetails()
{
     Console.WriteLine($"Title: {Title}" - $"Author: {Author}");
     Console.WriteLine($"Genre: {Genre}" - $"ISBN: {ISBN}" - $"Publication Year: {PublicationYear}");
     Console.WriteLine($"File Size: {FileSize}");
}

    public void Read()
    {
<<<<<<< HEAD
        Console.WriteLine($"Wordt nu gelezen {Title}...");
    }

    // constructor
    public eBook(string title, string author, string isbn, int publicationYear, string genre, int fileSize) : base(title, author, isbn, publicationYear, genre)
    {
        FileSize = fileSize;
=======
        Console.WriteLine($"Reading {Title}...");
>>>>>>> 80c3c614ba9e2fdfe3cbdfb28ea0aad3afb21af7
    }
}