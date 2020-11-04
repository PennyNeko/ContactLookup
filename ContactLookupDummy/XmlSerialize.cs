using System.IO;
using System.Xml.Serialization;

namespace ContactLookupDummy
{
    class XmlSerialize<Type> : ISerialize<Type>
    {
        XmlSerializer xmlSerializer;

        public XmlSerialize()
        {
            xmlSerializer = new XmlSerializer(typeof(Type));
        }
        private void WriteToXml(Type obj, string fileName, string path)
        {
            path = path + fileName + ".xml";
            Stream writer = new FileStream(path, FileMode.Create);
            xmlSerializer.Serialize(writer, obj);
            writer.Close();
        }

        public void Save(Type objectToSerialize, string fileName, string path = @"./../../../data/")
        {
            WriteToXml(objectToSerialize, fileName, path);
        }
    }
}
