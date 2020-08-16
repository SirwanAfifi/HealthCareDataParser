using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ReadXml.LoadRecords("data.xml");
            Console.WriteLine(data.Locale);
        }
    }
}