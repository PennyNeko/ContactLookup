using System.Collections.Generic;

namespace ContactLookupDummy
{
    class ContactExport : JsonExport<ICollection<Contact>>, IContactExport
    {
        public void SetContacts(ICollection<Contact> contacts, string fileName = "contacts")
        {
            JsonSave(contacts, fileName);
        }
    }
}
