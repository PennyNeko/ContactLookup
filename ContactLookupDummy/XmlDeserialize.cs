using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ContactLookupDummy
{
    class XmlDeserialize<Type> : IDeserialize<Type>
    {
        XmlSerializer xmlSerializer;
        public XmlDeserialize()
        {
            xmlSerializer = new XmlSerializer(typeof(Type));
        }

        private Type ReadFromXml(string fileName, string path)
        {
            path = path + fileName + ".xml";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            using XmlReader reader = XmlReader.Create(stream, new XmlReaderSettings());
            return (Type)xmlSerializer.Deserialize(reader);
        }

        public Type Load(string fileName, string path = @"./../../../data/")
        {
            return ReadFromXml(fileName, path);
        }
    }
}