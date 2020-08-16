using System.Xml.Serialization;

namespace Models
{
    public class Me
    {
        [XmlAttribute]
        public string HKCharacteristicTypeIdentifierDateOfBirth { get; set; }
        [XmlAttribute]
        public string HKCharacteristicTypeIdentifierBiologicalSex { get; set; }
        [XmlAttribute]
        public string HKCharacteristicTypeIdentifierBloodType { get; set; }
        [XmlAttribute]
        public string HKCharacteristicTypeIdentifierFitzpatrickSkinType { get; set; }
    }
}