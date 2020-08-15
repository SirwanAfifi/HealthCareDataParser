using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Models;

namespace ConsoleApp
{
    public static class ReadXml
    {
        public static IList<Record> LoadRecords(string xmlFilePath)
        {
            using var xmlReader = new XmlTextReader(xmlFilePath);
            var serializer = new XmlSerializer(typeof(List<Record>), new XmlRootAttribute("HealthData"));
            return (List<Record>)serializer.Deserialize(xmlReader);
        }
    }
}