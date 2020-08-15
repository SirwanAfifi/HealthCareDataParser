using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ReadXml.LoadRecords("data.xml");
            foreach (var record in data)
            {
                Console.WriteLine(record.SourceName);
            }
        }
    }
}