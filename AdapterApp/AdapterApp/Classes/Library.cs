using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AdapterApp
{
    public class Library
    {
        public string getBooksXML()
        {
            Console.WriteLine("Getting books list in XML format");

            List<Book> list = new List<Book>(){
                new Book { Id = 1, Author = "Jerome David Salinger", Title = "The Catcher in the Rye" , Date=new DateTime(1951,1,1)},
                new Book { Id = 2, Author = "Erich Maria Remarque", Title = "Three Comrades", Date=new DateTime(1936,1,1) },
                new Book { Id = 3, Author = "Aldous Huxley", Title = "Brave New World", Date=new DateTime(1932,1,1) }
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            MemoryStream ms = new MemoryStream();
            xmlSerializer.Serialize(ms, list);

            ms.Position = 0;
            StreamReader streamReader = new StreamReader(ms);
            string res = streamReader.ReadToEnd();
            streamReader.Dispose();

            return res;
        }
    }
}
