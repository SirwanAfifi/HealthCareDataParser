using System;
using System.Xml.Serialization;

namespace Models
{
    public class Record
    {
        [XmlAttribute("type")]
        public RecordType Type { get; set; }
        [XmlAttribute("unit")]
        public Unit Unit { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("sourceName")]
        public string SourceName { get; set; }
        [XmlAttribute("sourceVersion")]
        public string SourceVersion { get; set; }
        [XmlAttribute("device")]
        public string Device { get; set; }
        [XmlAttribute("creationDate")]
        public string CreationDate { get; set; }
        [XmlAttribute("startDate")]
        public string StartDate { get; set; }
        [XmlAttribute("endDate")]
        public string EndDate { get; set; }
    }
}