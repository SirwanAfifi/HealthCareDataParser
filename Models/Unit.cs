using System.Xml.Serialization;

namespace Models
{
    public enum Unit
    {
        [XmlEnum("count")]
        Count,
        [XmlEnum("km")]
        Km
    }
}