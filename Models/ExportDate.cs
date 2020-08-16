using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class ExportDate
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}