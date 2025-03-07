public class UI
{

    // auto generated
    public void DisplayBookDetails(Book book)
    {
        book.DisplayDetails();
    }

    public void DisplayEBookDetails(EBook eBook)
    {
        eBook.DisplayDetails();
    }

    public void ReadBook(IReadable readable)
    {
        readable.Read();
    }

    // end auto

//methods
    public void DisplayMenu()
    {
        Console.WriteLine("1. Boek toevoegen");
        Console.WriteLine("2. Boek verwijderen");
        Console.WriteLine("3. Boek zoeken");
        Console.WriteLine("4. Boeken weergeven");
        Console.WriteLine("5. Afsluiten");
    }

    public string GetInput(string prompt)
    {
// kan waarschinlijk korter. Ook door string input geen variabele te maken.

        string input = "";
        while (string.IsNullOrEmpty(input))
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        }
        return input;

    }

    public void Run()
    {
        Library library = new Library();
        string choice = "";
        while (choice != "5")
        {
            DisplayMenu();
            choice = GetInput("Maak een keuze: ");
            switch (choice)
            {
                case "1":
                    AddBook(library);
                    break;
                case "2":
                    RemoveBook(library);
                    break;
                case "3":
                    SearchBooks(library);
                    break;
                case "4":
                    ListBooks(library);
                    break;
                case "5":
                    Console.WriteLine("Tot ziens!");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze.");
                    break;
            }
        }
    }
}