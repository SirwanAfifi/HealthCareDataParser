using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class HealthData
    {
        [XmlAttribute("locale")]
        public string Locale { get; set; }

        public Me Me { get; set; }
        
        [XmlElement("Record")]
        public List<Record> Records { get; set; }
    }
}