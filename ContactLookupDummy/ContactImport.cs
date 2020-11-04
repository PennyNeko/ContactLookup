using System.Collections.Generic;

namespace ContactLookupDummy
{
    class ContactImport
    {
        readonly FileType serializingOption;
        public ContactImport(FileType serializingOption)
        {
            this.serializingOption = serializingOption;
        }
        public ICollection<Contact> ImportContacts(string fileName = "contacts")
        {
            return serializingOption switch
            {
                FileType.xml => new XmlDeserialize<ICollection<Contact>>().Load(fileName),
                FileType.json => new JsonDeserialize<ICollection<Contact>>().Load(fileName),
                _ => throw new System.Exception("Not supported serialization"),
            };
        }
    }
}
