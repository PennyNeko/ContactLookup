using System;
using System.Collections.Generic;
using System.Text;

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
