using System;
using System.Diagnostics.CodeAnalysis;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            BooksAnalyzer booksAnalyzer = new BooksAnalyzer();
            XmlToJsonAdapter adapter = new XmlToJsonAdapter(library);            
            Book oldestBook= booksAnalyzer.GetOldestBook(adapter.GetBooksJson());
            Console.WriteLine("Result:");
            Console.WriteLine($"Id={oldestBook.Id}, Author=\"{oldestBook.Author}\", Title=\"{oldestBook.Title}\", Date={oldestBook.Date.Year}");
            Console.ReadKey();
        }
    }
}
