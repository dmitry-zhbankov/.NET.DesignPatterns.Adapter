using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace AdapterApp
{
    public class XmlToJsonAdapter
    {
        Library library;

        public XmlToJsonAdapter(Library library)
        {
            this.library = library;
        }

        public string GetBooksJson()
        {
            string booksListXml = library.GetBooksXML();

            Console.WriteLine("Converting XML books list to Json format");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            MemoryStream ms = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(ms);
            streamWriter.Write(booksListXml);
            streamWriter.Flush();

            ms.Position = 0;
            List<Book> list = xmlSerializer.Deserialize(ms) as List<Book>;

            streamWriter.Dispose();
            string booksListJson = JsonSerializer.Serialize(list);
            return booksListJson;
        }
    }
}
