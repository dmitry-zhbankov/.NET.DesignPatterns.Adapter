using System;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksAnalyzer booksAnalyzer = new BooksAnalyzer();

            Library library = new Library();
            XmlToJsonAdapter adapter = new XmlToJsonAdapter(library);

            Book oldestBook = booksAnalyzer.GetOldestBook(adapter.GetBooksJson());

            Console.WriteLine("Result:");
            Console.WriteLine($"Id={oldestBook.Id}, Author=\"{oldestBook.Author}\", Title=\"{oldestBook.Title}\", Date={oldestBook.Date.Year}");
            Console.ReadKey();
        }
    }
}
