using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Models;

namespace ConsoleApp
{
    public static class ReadXml
    {
        public static HealthData LoadRecords(string xmlFilePath)
        {
            using var xmlReader = new XmlTextReader(xmlFilePath);
            var serializer = new XmlSerializer(typeof(HealthData));
            return (HealthData)serializer.Deserialize(xmlReader);
        }
    }
}