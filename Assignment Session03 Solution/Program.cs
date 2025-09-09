namespace Assignment_Session02_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book("1", "C# Basics", new string[]{"Abdo", "Gaber"}, new DateTime(2020, 3, 1), 150),
            new Book("2", "OOP Concepts", new string[]{"Mohamed"}, new DateTime(2021, 4, 15), 200)
        };

            Console.WriteLine("=== Using User-defined Delegate ===");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            Console.WriteLine("\n=== Using BCL Delegate (Func<>) ===");
            LibraryEngine.ProcessBooks(books, new BookFunctionDelegate(BookFunctions.GetAuthors));

            Console.WriteLine("\n=== Using Anonymous Method (GetISBN) ===");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("\n=== Using Lambda Expression (GetPublicationDate) ===");
            LibraryEngine.ProcessBooks(books, (b) => b.PublicationDate.ToShortDateString());


        }
    }
}
