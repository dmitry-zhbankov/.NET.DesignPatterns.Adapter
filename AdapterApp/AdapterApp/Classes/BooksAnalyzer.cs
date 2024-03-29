﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace AdapterApp
{
    class BooksAnalyzer
    {
        public Book GetOldestBook(string jsonBooksList)
        {
            Console.WriteLine("Consuming Json books list");

            List<Book> list = JsonSerializer.Deserialize<List<Book>>(jsonBooksList);

            list.Sort(new BookDateComparer());
            Book oldestBook = list.LastOrDefault<Book>();

            return oldestBook;
        }
    }
}