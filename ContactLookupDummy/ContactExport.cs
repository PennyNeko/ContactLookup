using System.Collections.Generic;

namespace ContactLookupDummy
{
    class ContactExport
    {
        FileType serializingOption;
        public ContactExport(FileType serializingOption)
        {
            this.serializingOption = serializingOption;
        }

        public void SaveContacts(ICollection<Contact> contacts, string fileName = "contacts")
        {
            switch (serializingOption)
            {
                case FileType.xml:
                    new XmlSerialize<ICollection<Contact>>().Save(contacts, fileName);
                    break;
                case FileType.json:
                    new JsonSerialize<ICollection<Contact>>().Save(contacts, fileName);
                    break;
                default:
                    throw new System.Exception("Not supported serialization");
            }
        }
    }
}
