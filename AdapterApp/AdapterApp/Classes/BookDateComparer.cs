using System.Collections.Generic;

namespace AdapterApp
{
    class BookDateComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return (x.Date - y.Date).Days;
        }
    }
}
